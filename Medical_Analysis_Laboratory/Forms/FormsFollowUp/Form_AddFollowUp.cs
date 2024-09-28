using Bunifu.UI.WinForms;
using Medical_Analysis_Laboratory.Classes;
using Medical_Analysis_Laboratory.Classes.Connection.PatientProcess;
using Medical_Analysis_Laboratory.Classes.Connection.FollowUpProcess;
using Medical_Analysis_Laboratory.Classes.Connection.UsersProcess;
using Medical_Analysis_Laboratory.Properties;
using System;
using System.Windows.Forms;
using Medical_Analysis_Laboratory.Classes.Connection.TestProcess;

namespace Medical_Analysis_Laboratory.Forms.FormsFollowUp
{
    public partial class Form_AddFollowUp : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        Form formMain;
        private bool isClose;
        private int id = 0;
        private bool isReferral = false;
        private bool isTest = false;
        private int idPatient = 0;
        private float temperatureMeasurement;
        private int burnDrawer;
        private float burnRate;
        private string noteToTest="";
        private DateTime? nextVisit=null;
        Cls_PatientsDB PatientDB = new Cls_PatientsDB();
        Cls_TestDB TestDB = new Cls_TestDB();    
        Cls_FollowUpDB action = new Cls_FollowUpDB();
        #endregion
        public Form_AddFollowUp(Form form)
        {
            InitializeComponent();
            loadInitConfig(form);
        }
        #region Function
        private void loadInitConfig(Form form)
        {
            this.formMain = form;
            TX_PressureMeasurement.Select();
            PAN_Test.Visible = false;
            loadNamePatient();
            validNextDate();
        }
        public void validNextDate() =>
           DTP_NextData.MinDate = DateTime.Now;
        public void loadNamePatient()
        {
            COMP_NamePatient.DataSource = PatientDB.getDataPatientsToFollowUp();
            COMP_NamePatient.DisplayMember= "الاسم";
            COMP_NamePatient.ValueMember = "المعرف";
            COMP_NamePatient.SelectedIndex = -1;
            COMP_NamePatient.Select();
            checkIsLoadNumberOfVist();
        }
        public void checkIsLoadNumberOfVist()
        {
            if (COMP_NamePatient.SelectedIndex != -1)
            {
                loadNumberOfVist();
            }
            else
            {
                LB_NumberOfVist.Text="";
            }
        }
        public void loadNumberOfVist()=>
            LB_NumberOfVist.Text = action.getDataNumberOfVist(getIdPatientSelected()).Rows[0][0].ToString();
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
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
        public int getIdPatientSelected()
        {
            try
            {
                if (COMP_NamePatient.SelectedIndex != -1)
                {
                    int idPatient;
                    Int32.TryParse(COMP_NamePatient.SelectedValue.ToString(), out idPatient);
                    return idPatient;
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
            TX_PressureMeasurement.Clear();
            TX_TissueMeasurement.Clear();
            TX_MeasureHeartRate.Clear();
            TX_TemperatureMeasurement.Clear();
            COMP_PsychologicalEffects.SelectedIndex = -1;
            COMP_BurnDrawer.SelectedIndex = -1;
            TX_BurnRate.Clear();
            RTX_Nerve_or_tendon_area.Clear();
            COMP_TypeExercise.SelectedIndex = -1;
            COMP_Pharmaceutical.SelectedIndex = -1;
            LB_NumberOfVist.Text = "";
            DTP_NextData.Value =DateTime.Now;
            RIT_Note.Clear();
        }
        public void checkSetIsReferral()
        {
            try
            {
                if (isReferral)
                {
                    PatientDB.setIsReferral(idPatient,"نعم");
                    isReferral = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void showPAN_Test()
        {
            PAN_Test.Visible = true;
            DTP_NextData.Visible = false;
            BTN_Monthly.Visible = false;
            BTN_Weekley.Visible = false;
        }
        public void hidePAN_Test()
        {
            PAN_Test.Visible = false;
            DTP_NextData.Visible = true;
            BTN_Monthly.Visible = true;
            BTN_Weekley.Visible = true;
        }
        public void loadDataToTest()
        {
            if(TX_TemperatureMeasurement.Text!=""&& COMP_BurnDrawer.SelectedIndex!=-1&&
               TX_BurnRate.Text != "")
            {
                temperatureMeasurement = Convert.ToSingle(TX_TemperatureMeasurement.Text);
                burnDrawer = Convert.ToInt32(COMP_BurnDrawer.Text);
                burnRate = Convert.ToSingle(TX_BurnRate.Text);
                isTest = (temperatureMeasurement >= 35 && temperatureMeasurement <= 39)
                    &&(burnDrawer==1||burnDrawer==2)&&burnRate<=5;

                if(isTest && !isReferral)
                {
                    showPAN_Test();
                }
                else
                {
                    hidePAN_Test();
                }
            }
            else
            {
                temperatureMeasurement = 0;
                burnDrawer = 0;
                burnRate= 0;
                hidePAN_Test();
            }
           

        }
        public int getIdCurrentFollowUp()
        {
            try
            {
                return Int32.Parse(action.getDataIdCurrentFollowUp().Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
         
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public void checkSetIsTest(int idCurrentFollowUp)
        {
            try
            {
                if (isTest&&!isReferral)
                {
                    PatientDB.setIsTest(idPatient, "نعم");
                    /* تعديلها لحذفها كانت للتخريج*/
                   /* TestDB.insertTest(idPatient,idCurrentFollowUp,noteToTest);*/
                    isTest = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void checkIsTest()
        {
                        if (isTest  &&!isReferral)
                        {
                            nextVisit =null;
                        }
                        else
                        {
                            nextVisit = DTP_NextData.Value;
                        }
        }
        private void addData()
        {
            try
            {
                if (Cls_UsersDB.idUser==0|| COMP_NamePatient.SelectedIndex==-1 || TX_PressureMeasurement.Text == "" || TX_TissueMeasurement.Text == "" || TX_MeasureHeartRate.Text == ""||
                    TX_TemperatureMeasurement.Text==""|| COMP_PsychologicalEffects.SelectedIndex==-1||
                    COMP_BurnDrawer.SelectedIndex==-1|| TX_BurnRate.Text==""||
                    RTX_Nerve_or_tendon_area.Text==""|| COMP_TypeExercise.SelectedIndex==-1||
                    COMP_Pharmaceutical.SelectedIndex==-1|| LB_NumberOfVist.Text==""|| DTP_NextData.Text=="")
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        idPatient = getIdPatientSelected();

                        checkIsTest();
                        action.insertFollowUp(idPatient, Cls_UsersDB.idUser,TX_PressureMeasurement.Text,TX_TissueMeasurement.Text,
                            TX_MeasureHeartRate.Text,TX_TemperatureMeasurement.Text,COMP_PsychologicalEffects.Text,COMP_BurnDrawer.Text
                            ,TX_BurnRate.Text,RTX_Nerve_or_tendon_area.Text,COMP_TypeExercise.Text,COMP_Pharmaceutical.Text,
                            LB_NumberOfVist.Text,RIT_Note.Text, nextVisit, DateTime.Now);
                        showSuccessAddMessageData();
                        PatientDB.incrementNumberVists(idPatient);
                        isReferral = Convert.ToSingle(TX_BurnRate.Text) > 30;
                        checkSetIsReferral();
                        checkSetIsTest(getIdCurrentFollowUp());
                        clearField();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_FollowUp ", "خطأ");
            }
        }
        private void saveData()
        {
            addData();
            loadNamePatient();
        }
        #endregion
        #region Event
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }
        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TX_NameCourse_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void RIT_NoteCourse_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void COMP_NamePatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIsLoadNumberOfVist();
        }
        private void COMP_NamePatient_TextChanged(object sender, EventArgs e)
        {
            checkIsLoadNumberOfVist();
        }
        private void TX_PressureMeasurement_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender,e);
        }
        private void TX_TissueMeasurement_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_MeasureHeartRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_TemperatureMeasurement_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_BurnRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void BTN_Weekley_Click(object sender, EventArgs e)
        {
            DTP_NextData.Value=DateTime.Now.AddDays(7);
        }
        private void BTN_Monthly_Click(object sender, EventArgs e)
        {
            DTP_NextData.Value = DateTime.Now.AddMonths(1);
        }
        private void TX_TemperatureMeasurement_TextChanged(object sender, EventArgs e)
        {
            loadDataToTest();
        }
        private void COMP_BurnDrawer_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataToTest();
        }
        private void TX_BurnRate_TextChanged(object sender, EventArgs e)
        {
            loadDataToTest();
        }
        private void BTN_AddNoteTest_Click(object sender, EventArgs e)
        {
            Form_AddNoteToTest addNoteToTest = new Form_AddNoteToTest();
            addNoteToTest.ShowDialog();
            noteToTest=addNoteToTest.getNote();
            addNoteToTest.Dispose();
        }
        #endregion
    }
}