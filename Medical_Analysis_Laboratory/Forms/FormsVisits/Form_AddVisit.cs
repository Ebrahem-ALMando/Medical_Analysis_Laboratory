using Bunifu.UI.WinForms;
using Medical_Analysis_Laboratory.Classes;
using Medical_Analysis_Laboratory.Classes.Connection.PatientProcess;
using Medical_Analysis_Laboratory.Classes.Connection.UsersProcess;
using Medical_Analysis_Laboratory.Classes.Connection.VisitsProcess;
using Medical_Analysis_Laboratory.Classes.Connection.VisitTestsProcess;
using Medical_Analysis_Laboratory.Forms.Forms_TestsVisit;
using Medical_Analysis_Laboratory.Properties;
using System;
using System.Data;
using System.Windows.Forms;


namespace Medical_Analysis_Laboratory.Forms.FormsVisits
{
    public partial class Form_AddVisit : DevExpress.XtraEditors.XtraForm
    {
        private Form formMain;
        private Form formBackground;
        Cls_PatientsDB patientsDB = new Cls_PatientsDB();
        Cls_VisitsDB action=new Cls_VisitsDB();
        Cls_VisitTestDB visitTestDB = new Cls_VisitTestDB();
        private int idPatient;
        private int id=0;
        private bool isClose;

        public Form_AddVisit(Form formMain,Form formBackground)
        {
            InitializeComponent();
            loadInitConfig(formMain, formBackground);

        }
        public void loadInitConfig(Form formMain, Form formBackground)
        {
            this.formMain = formMain;
            this.formBackground = formBackground;
            loadNamePatient();
        }
        public void loadNamePatient()
        {
            COMP_NamePatient.DataSource = patientsDB.getDataPatientsToVisits();
            COMP_NamePatient.DisplayMember = "الاسم";
            COMP_NamePatient.ValueMember = "المعرف";
            COMP_NamePatient.SelectedIndex = -1;
            COMP_NamePatient.Select();
        }
        private void showSuccessAddMessageData(Form form)
        {
            MessageShow.Show(form, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
        }
        public int getIdCompoSelected(ComboBox comboBox)
        {
            try
            {
                if (COMP_NamePatient.SelectedIndex != -1)
                {
                    int id;
                    Int32.TryParse(comboBox.SelectedValue.ToString(), out id);
                    return id;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void clearField()
        {
            COMP_NamePatient.SelectedIndex = -1;
            idPatient = 0;
            TX_testsNumber.Clear();
            RTB_Note.Clear();
            /*config ==> DGV SUR ==>*/
            dataGridViewTestsVisit.DataSource = null;
            StorageCacheVisit.StorageCacheVisits.Clear();
        }
        public int getIdCurrentVisit()
        {
            try
            {
                
                return Int32.Parse(action.getDataIdCurrentVisit().Rows[0][0].ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        
        private int getTestNumber()
        {
            try
            {
                Int32.TryParse(TX_testsNumber.Text, out int testNumber);
                return testNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        private int getRemainingNumber()
        {
            try
            {
                int total = 20;
                bool isEmptyText = TX_testsNumber.Text != "";
                if (isEmptyText)
                 {
                     if (getTestNumber() >= 0 && getTestNumber() <= 20)
                     {
                         int remainingNumber = total - getTestNumber();
                         return remainingNumber;
                     }
                     ClsMessageCollections.showWarningInputvalueGreaterthan20MessageData();
                     TX_testsNumber.Clear();
                     return total;
                 }
                return total;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        private void updateRemainingNumber()=>
            LBL_remainingNumber.Text = getRemainingNumber().ToString();

        private void insertTestToVisit()
        {
            try
            {
                foreach (var test in StorageCacheVisit.StorageCacheVisits)
                {
                    var testVal = Convert.ToSingle(test.NameTextValue.Text);
                    visitTestDB.insertTestToVisit(getIdCurrentVisit(),getIdCompoSelected(test.NameCompoTest)
                        , Cls_UsersDB.idUser, testVal, test.NameRichDiagnosis.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addData()
        {
            try
            {
                if (COMP_NamePatient.SelectedIndex==-1 || TX_testsNumber.Text == "" || dataGridViewTestsVisit.Rows.Count == 0)
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        var testNumber = dataGridViewTestsVisit.Rows.Count;
                        action.insertVisit(Cls_UsersDB.idUser, getIdCompoSelected(COMP_NamePatient), testNumber, RTB_Note.Text);
                        insertTestToVisit();
                        clearField();
                        
                        if (isClose)
                        {
                            showSuccessAddMessageData(formMain);
                            this.Close();
                        }
                        else
                        {
                            showSuccessAddMessageData(formBackground);
                        }
                     
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_Visit ", "خطأ");
            }
        }
  /*      private void updateData()
        {
            try
            {
                if (TX_NamePatient.Text == "" || TX_AgePatient.Text == "" || TX_Address.Text == "" || COMP_GenderPatient.SelectedIndex == -1 ||
                     TX_Phone.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updatePatient(id, TX_NamePatient.Text, TX_AgePatient.Text, COMP_GenderPatient.Text,
                                TX_Address.Text, TX_Phone.Text, RIT_NotePatient.Text);

                        showSuccessUpdateMessageData();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:185-FA_User ", "خطأ");
            }
        }*/
        private void saveData()
        {
            if (id != 0)
            {
                /*updateData();*/
            }
            else
            {
                addData();
            }
        }


        private void TX_testsNumber_TextChanged(object sender, EventArgs e)
        {
            updateRemainingNumber();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            isClose=true;
            saveData();
        }

        private void loadTestToDGV(bool checkData)
        {
            
            if(StorageCacheVisit.StorageCacheVisits.Count > 0)
            {
                if (checkData)
                {
                      dataGridViewTestsVisit.DataSource = null;
                      var i = 0;
                      DataTable dataTable = new DataTable();
                      dataTable.Columns.Add("ID");
                      dataTable.Columns.Add("#");
                      dataTable.Columns.Add("اسم التحليل");
                      dataTable.Columns.Add("القيمة");
                      foreach (var test in StorageCacheVisit.StorageCacheVisits)
                      {
                          dataTable.Rows.Add(test.Id,++i, test.NameCompoTest.Text, test.NameTextValue.Text);
                      }
                      dataGridViewTestsVisit.DataSource = dataTable;
                      dataGridViewTestsVisit.Columns[0].Visible = false;
                }
         
            }
           
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }

        private void TX_testsNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_testsNumber_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void COMP_NamePatient_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void BTN_AddTestsToVisit_Click(object sender, EventArgs e)
        {
            if (COMP_NamePatient.SelectedIndex != -1 && !string.IsNullOrEmpty(TX_testsNumber.Text))
            {
                using (Form_AddTestsVisit addTestsVisit = new Form_AddTestsVisit(getTestNumber(),COMP_NamePatient.Text))
                {
                    addTestsVisit.ShowDialog();
                    addTestsVisit.Dispose();
                    loadTestToDGV(addTestsVisit.checkData(StorageCacheVisit.StorageCacheVisits));
                }
            }
            else
            {
                ClsMessageCollections.showEmptyMessageData();
            }
         
            /*if(dataGridViewTestsVisit.Rows.Count == 0)
            {
               
            }
            else
            {
                MessageBox.Show("سيتم مسح بيانات التحاليل السابقة");
            }*/

        }
        private Guid getIdTestFromCurrentRow()
        {
            
                Guid.TryParse(dataGridViewTestsVisit.CurrentRow.Cells[0].Value.ToString(), out var idTest);

                return idTest;
      
            
        }
        private void deleteTest()
        {
           if (dataGridViewTestsVisit.CurrentRow != null)
           {
                if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                {
                    new StorageCacheVisit().RemoveItemById(getIdTestFromCurrentRow(), dataGridViewTestsVisit);
                }
           }
           else
           {
               ClsMessageCollections.showEmptySelectedMessageData();
           }
        

        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            deleteTest();
        }
    }
    
}