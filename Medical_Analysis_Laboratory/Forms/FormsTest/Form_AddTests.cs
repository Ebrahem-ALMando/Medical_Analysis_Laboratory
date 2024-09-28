using Bunifu.UI.WinForms;
using Medical_Analysis_Laboratory.Classes.Connection.PatientProcess;
using Medical_Analysis_Laboratory.Properties;
using System;
using System.Windows.Forms;
using ClsMessageCollections = Medical_Analysis_Laboratory.Classes.ClsMessageCollections;
using Medical_Analysis_Laboratory.Classes.Connection.UsersProcess;
using Medical_Analysis_Laboratory.Classes.Connection.TestProcess;
using System.Drawing;
using System.Data;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace Medical_Analysis_Laboratory.Forms.FormsTests
{
    public partial class Form_AddTests : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        private int id=0;
        private bool isClose;
        private int idCurrentNode = -1;
        private int idParentNode=-1;
        private TreeNode cuurentNode=null;
        private Form formMain;
        Cls_TestDB action = new Cls_TestDB();
        private string isReferral="لا";
        #endregion
        public Form_AddTests(Form formMain, TreeNode cuurentNode)
        {
            InitializeComponent();
            loadInitConfig(formMain,cuurentNode);
         }

        public Form_AddTests(Form formMain, DataRow[] filteredRows)
        {
            InitializeComponent();
            loadData(formMain,filteredRows);
            dsiableGUIToolWithUpdate();
        }
        private string getDataFilteredRows(DataRow[] filteredRows, string data)
        {
            if (!string.IsNullOrEmpty(data) && filteredRows.Length > 0 && !filteredRows[0].IsNull(data))
            {
                return filteredRows[0][data].ToString();
            }
            return "";
        }

        private void dsiableGUIToolWithUpdate()
        {
            COMP_isRoot.Enabled = false;
            RB_No.Enabled = false;
            RB_Yes.Enabled = false;
            TX_RangeBegin.ReadOnly = true;
            TX_RangeEnd.ReadOnly = true;
            RTB_diagnosisValueLessThanBegin.ReadOnly = true;
            RTB_diagnosisValueBetweenRange.ReadOnly = true;
            RTB_diagnosisValueBiggerThanEnd.ReadOnly = true;
        }
        #region Method

        private bool checkIsBeginValLessThanEndValRange()
        {
            if (string.IsNullOrEmpty(TX_RangeBegin.Text)|| string.IsNullOrEmpty(TX_RangeEnd.Text))
            {
                return true;
            }
            var bRange = Convert.ToSingle(TX_RangeBegin.Text);
            var eRange = Convert.ToSingle(TX_RangeEnd.Text);

            return eRange >= bRange;
        }
        private void getMessageCheckIsValueRange()
        {
            if (!checkIsBeginValLessThanEndValRange()) 
            {
                ClsMessageCollections.showWarningBValBiggerThanEValMessageData();
                TX_RangeBegin.Clear();
                TX_RangeEnd.Clear();

            }
        }
        private void loadInitConfig(Form formMain, TreeNode cuurentNode)
        {
            this.formMain = formMain;
            TX_NameTest.Select();
            TX_ParentName.Text=cuurentNode.Text;
            idParentNode = Convert.ToInt32(cuurentNode.Tag);
            this.cuurentNode = cuurentNode;
            RB_No.Checked = true;
            COMP_isRoot.SelectedIndex = 1;
            this.Text = "اضافة تحليل";
        }
        private void hideTXValueParentName() =>
            TX_ParentName.Clear();
        private void setTXValueParentName() =>
            TX_ParentName.Text = cuurentNode.Text??"";
        private bool getIsRootNode()
        {
            bool isRootNode = COMP_isRoot.SelectedIndex == 0&&COMP_isRoot.SelectedIndex!=-1;
            return isRootNode;
        }
        private bool getIsCategoryNode()
        {
            bool isCategoryNode = RB_Yes.Checked;
            return isCategoryNode;
        }
        private void setConfigByIsCategory()
        {
            if (getIsCategoryNode())
            {
                GC_diagnosisValue.Visible = false;
                GC_rangeValue.Visible = false;
                LBL_RangeValue.Visible = false;
                LBL_Note.Location=new Point(892, 307);
                RTB_Note.Location = new Point(490, 296);
            }
            else
            {
                GC_diagnosisValue.Visible = true;
                GC_rangeValue.Visible = true;
                LBL_RangeValue.Visible = true;
                LBL_Note.Location = new Point(887, 443);
                RTB_Note.Location = new Point(490, 440);
            }
        }
        private void changeStateByCompo()
        {
            if (getIsRootNode())
            {
                hideTXValueParentName();
            }
            else if(cuurentNode != null) 
            {
                setTXValueParentName();
            }
        }
        private bool checkAddDataByCaseIsNodeCategory()
        {
            if (TX_NameTest.Text != "" && Cls_UsersDB.idUser != 0)
            {
                if (!getIsRootNode())
                {
                    if (TX_ParentName.Text != "")
                    {
                        return true;
                    }
                    return false;

                }
               return true;
            }
            return false;
        }
        private bool checkAddDataByCaseIsNodeRoot()
        {
            if(getIsCategoryNode())
            {
                return checkAddDataByCaseIsNodeCategory();
            }
            else
            {
                if(TX_NameTest.Text!=""&&TX_RangeBegin.Text!=""&&TX_RangeEnd.Text!=""&&RTB_diagnosisValueLessThanBegin.Text!=""
                    & RTB_diagnosisValueBetweenRange.Text != "" && RTB_diagnosisValueBiggerThanEnd.Text != "")
                {
                    return true;
                }
                return false;
            }
        }
        private bool checkAddDataByCaseIsNodeCatAndRoot()
        {
            
                if (checkAddDataByCaseIsNodeCategory() && checkAddDataByCaseIsNodeRoot())
                {
                    return true;
                }
                return false;
      
        }
        private bool checkAddDataByCaseIsNodeOnly()
        {
            if (TX_ParentName.Text!=""&&TX_NameTest.Text != "" && TX_RangeBegin.Text != "" && TX_RangeEnd.Text != "" && RTB_diagnosisValueLessThanBegin.Text != ""
                   & RTB_diagnosisValueBetweenRange.Text != "" && RTB_diagnosisValueBiggerThanEnd.Text != "")
            {
                return true;
            }
            return false;
        }
        private void addDataByCase(string caseText)
        {
            if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
            {
                switch (caseText)
                {
                    case "C&R":
                        action.insertTest(null, Cls_UsersDB.idUser, TX_NameTest.Text, RB_Yes.Checked,
                            null, null, null, null, null, RTB_Note.Text);
                        break;
                    case "C":
                        action.insertTest(idParentNode, Cls_UsersDB.idUser, TX_NameTest.Text, RB_Yes.Checked,
                            null, null, null, null, null, RTB_Note.Text);
                        break;
                    case "R":
                        action.insertTest(null, Cls_UsersDB.idUser, TX_NameTest.Text, RB_Yes.Checked,
                            Convert.ToSingle(TX_RangeBegin.Text), Convert.ToSingle(TX_RangeEnd.Text)
                            , RTB_diagnosisValueLessThanBegin.Text, RTB_diagnosisValueBetweenRange.Text
                            , RTB_diagnosisValueBiggerThanEnd.Text, RTB_Note.Text);
                        break;
                    default:
                        action.insertTest(idParentNode, Cls_UsersDB.idUser, TX_NameTest.Text, RB_Yes.Checked,
                          Convert.ToSingle(TX_RangeBegin.Text), Convert.ToSingle(TX_RangeEnd.Text)
                          , RTB_diagnosisValueLessThanBegin.Text, RTB_diagnosisValueBetweenRange.Text
                          , RTB_diagnosisValueBiggerThanEnd.Text, RTB_Note.Text);
                        break;
                }
                    
                   

                showSuccessAddMessageData();
                clearField();
                if (isClose)
                {
                    this.Close();
                }
            }
        }
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void loadData(Form formMain, DataRow[] filteredRows)
        {
            id = Int32.Parse(filteredRows[0]["المعرف"].ToString());
            bool isCategory = Convert.ToBoolean(getDataFilteredRows(filteredRows, "هل هو صنف"));
            TX_NameTest.Text = getDataFilteredRows(filteredRows, "الاسم");
            TX_ParentName.Text = getDataFilteredRows(filteredRows, "اسم الاب");
            RTB_Note.Text = getDataFilteredRows(filteredRows, "ملاحظات");
            int? parentId = filteredRows[0]["رقم الأب"] != DBNull.Value ? (int?)Convert.ToInt32(getDataFilteredRows(filteredRows, "رقم الأب")) : null;
            RB_Yes.Checked = isCategory;
            RB_No.Checked = !isCategory;
            COMP_isRoot.SelectedIndex = !parentId.HasValue ? 0 : 1;
            TX_RangeBegin.Text = getDataFilteredRows(filteredRows, "بداية المجال");
            TX_RangeEnd.Text = getDataFilteredRows(filteredRows, "نهاية المجال");
            RTB_diagnosisValueLessThanBegin.Text = getDataFilteredRows(filteredRows, "الشتخيص أصغر");
            RTB_diagnosisValueBetweenRange.Text = getDataFilteredRows(filteredRows, "التشخيص طبيعي");
            RTB_diagnosisValueBiggerThanEnd.Text = getDataFilteredRows(filteredRows, "التشخيص أكبر");
            this.formMain = formMain;
            TX_NameTest.Select();
        
        }
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
        }
        private void clearField()
        {
          /*  TX_NamePatient.Clear();*/
            TX_NameTest.Clear();
       /*     TX_Address.Clear();
            COMP_GenderPatient.SelectedIndex = -1;
            TX_Phone.Clear();*/
            RTB_diagnosisValueLessThanBegin.Clear();
            RB_No.Checked = true;
        }
        private void addData()
        {
            try
            {
                if(getIsCategoryNode()&&getIsRootNode())
                {

                    if (checkAddDataByCaseIsNodeCatAndRoot())
                    {
                        addDataByCase("C&R");
                    }
                    else
                    {
                        ClsMessageCollections.showEmptyMessageData();
                    }
                }
                else if (getIsCategoryNode())
                {

                    if (checkAddDataByCaseIsNodeCategory())
                    {
                        addDataByCase("C");
                    }
                    else
                    {
                        ClsMessageCollections.showEmptyMessageData();
                    }
                }
                else if (getIsRootNode())
                {

                    if (checkAddDataByCaseIsNodeRoot())
                    {
                        addDataByCase("R");
                    }
                    else
                    {
                        ClsMessageCollections.showEmptyMessageData();
                    }
                }
                else
                {

                    if (checkAddDataByCaseIsNodeOnly())
                    {
                        addDataByCase("ALL");
                    }
                    else
                    {
                        ClsMessageCollections.showEmptyMessageData();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135- ", "خطأ");
            }
        }
        private void updateData()
        {
            try
            {
                if (TX_NameTest.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateTest(id, TX_NameTest.Text, RTB_Note.Text);
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
        }
        private void saveData()
        {
            if (id != 0)
            {
                updateData();
            }
            else
            {
                addData();
            }
        }
        #endregion
        #region Event
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void RB_Yes_CheckedChanged(object sender, EventArgs e)
        {
            setConfigByIsCategory();

        }
        private void RB_No_CheckedChanged(object sender, EventArgs e)
        {
            setConfigByIsCategory();
        }
        private void BTN_Add_Click_1(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }
        private void BTN_AddClose_Click_1(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }

        #endregion

        private void COMP_isRoot_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeStateByCompo();
        }

        private void TX_NameTest_KeyDown(object sender, KeyEventArgs e)
        {
                chickEnter(sender, e);
        }

        private void TX_RangeBegin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_RangeEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void RTB_diagnosisValueLessThanBegin_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void RTB_diagnosisValueBetweenRange_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void RTB_diagnosisValueBiggerThanEnd_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_RangeBegin_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_RangeEnd_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void TX_RangeBegin_Leave(object sender, EventArgs e)
        {
            getMessageCheckIsValueRange();
        }

        private void TX_RangeEnd_Leave(object sender, EventArgs e)
        {
            getMessageCheckIsValueRange();
        }
    }
}