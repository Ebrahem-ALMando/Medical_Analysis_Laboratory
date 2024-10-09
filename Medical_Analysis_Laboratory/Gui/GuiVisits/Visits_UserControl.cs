using Bunifu.UI.WinForms;
using Medical_Analysis_Laboratory.Classes;
using Medical_Analysis_Laboratory.Classes.Connection.TestProcess;
using Medical_Analysis_Laboratory.Classes.Connection.UsersProcess;
using Medical_Analysis_Laboratory.Classes.Connection.VisitsProcess;
using Medical_Analysis_Laboratory.Forms;
using Medical_Analysis_Laboratory.Forms.FormsVisits;
using Medical_Analysis_Laboratory.Properties;
using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Medical_Analysis_Laboratory.Gui.GuiVisits
{
    public partial class Visits_UserControl : UserControl
    {
        private Form formMain;
        private static Visits_UserControl visitControl;
        Cls_VisitsDB action=new Cls_VisitsDB();
        Cls_UsersDB users=new Cls_UsersDB();
        Cls_TestDB testDB=new Cls_TestDB();
        private int id;
        private string namePatient;
        private string nameLaboratory;

        private string testCount;
        private string agePatient;
        private string genderPatient;
        private string visitData;

        public Visits_UserControl(Form formMain)
        {
            InitializeComponent();
            loadInitConfig(formMain);
        }
        public static Visits_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return visitControl ?? (new Visits_UserControl(form));
        }
        private void loadInitConfig(Form formMain)
        {
            this.formMain = formMain;
            userVerification();
        }
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser.Trim() == "مسؤول")
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;
                BTN_Add.Enabled = false;
                BTN_Update.Enabled = false;
                BTN_Delete.Enabled = false;
                BTN_Export.Width = 600;
                BTN_Export.Location = new Point(460, 11);
                BTN_Export.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                COMP_FilterData.Visible = false;
                label1.Visible = false;
               
            }
            loadUsersDataEntryists();
            getData();
        }
        public void getData() =>
            dataGridViewVisits.DataSource = action.getDataVisits();
        public void getDataVisitByUser(int idUser) =>
            dataGridViewVisits.DataSource = action.getDataVisitByUser(idUser);
        private void showSuccessDeleteMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessDeleteData, BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void loadUsersDataEntryists()
        {
            COMP_FilterData.DataSource = users.getDataUsersLaboratory();
            COMP_FilterData.ValueMember = "المعرف";
            COMP_FilterData.DisplayMember = "الاسم";
            COMP_FilterData.SelectedIndex = -1;
        }
        public void loadFilterData()
        {
            if (COMP_FilterData.SelectedIndex != -1)
            {
                getDataVisitByUser(getIdUsers());
            }
            else
            {
                if (COMP_FilterData.Text == "")
                {
                    getData();
                }
            }
            TX_Search.Clear();
        }
        private int getIdUsers()
        {

            try
            {
                if (COMP_FilterData.SelectedIndex != -1)
                {
                    int IdUser;
                    Int32.TryParse(COMP_FilterData.SelectedValue.ToString(), out IdUser);
                    return IdUser;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CODE:LI-88-FAUS");
                return 0;
            }
        }
        private void searchData(string searchText)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewVisits.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dataGridViewVisits.Rows)
            {
                bool rowVisible = false;
                if (row.Cells["المعرف"].Value != null && row.Cells["المعرف"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["اسم المريض"].Value != null && row.Cells["اسم المريض"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["اسم المخبري"].Value != null && row.Cells["اسم المخبري"].Value.ToString().ToLower().Contains(searchText.ToLower()))
                {
                    rowVisible = true;
                }
                row.Visible = rowVisible;
            }

            currencyManager.ResumeBinding();
        }
        private void getDataFromDGV()
        {
            if (dataGridViewVisits.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewVisits.CurrentRow.Cells[0].Value);
                namePatient = dataGridViewVisits.CurrentRow.Cells[3].Value.ToString();
                agePatient = dataGridViewVisits.CurrentRow.Cells[4].Value.ToString();
                genderPatient = dataGridViewVisits.CurrentRow.Cells[5].Value.ToString();
                nameLaboratory = dataGridViewVisits.CurrentRow.Cells[6].Value.ToString();
                testCount = dataGridViewVisits.CurrentRow.Cells[7].Value.ToString();
                visitData = dataGridViewVisits.CurrentRow.Cells[9].Value.ToString();
            }


        }
        private void deleteData()
        {
            try
            {

                if (id != 0)
                {

                    if (ClsMessageCollections.showWarningClrearVisitTestsMessageData() == DialogResult.OK)
                    {
                        action.deleteVisit(id);
                        showSuccessDeleteMessageData();
                        getData();
                        id = 0;
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:385-FG_User ", "خطأ");
            }
        }

        private void configCellSheet(ExcelWorksheet worksheet,string nameCell,string valCell,string bgColor)
        {
            worksheet.Cells[nameCell].Value = valCell;
            worksheet.Cells[nameCell].Style.Font.Bold = true;
            worksheet.Cells[nameCell].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            worksheet.Cells[nameCell].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml(bgColor));
            worksheet.Cells[nameCell].Style.Font.Color.SetColor(System.Drawing.Color.White);
            

        }

        private void exportData(bool isAllVisits)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    string worksheets = isAllVisits ? "الزيارات" : "تحاليل الزيارة";
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(worksheets);
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true;
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    if(!isAllVisits)
                    {
                        dataGridViewVisits.DataSource= testDB.getDataPatientTestsByVisit(id);
                        dataGridViewVisits.Columns[2].Visible = false;
                        dataGridViewVisits.Columns[6].Visible = false;


                    }
                    for (int col = 1; col <= dataGridViewVisits.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewVisits.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    }
                    int excelRowIndex = 2;
                    foreach (DataGridViewRow row in dataGridViewVisits.Rows)
                    {
                        if (row.Visible)
                        {
                            for (int col = 1; col <= dataGridViewVisits.Columns.Count; col++)
                            {
                                var cellValue = row.Cells[col - 1].Value != null ? row.Cells[col - 1].Value.ToString() : "";
                                worksheet.Cells[excelRowIndex, col].Value = cellValue;
                            }
                            excelRowIndex++;
                        }
                    }
                    for (int col = 1; col <= dataGridViewVisits.Columns.Count; col++)
                    {
                        worksheet.Column(col).AutoFit();
                    }
               
                    if (!isAllVisits)
                    {
                        var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewVisits.Rows.Count + 1, dataGridViewVisits.Columns.Count), "جدول_التحاليل");
                        table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;
                        worksheet.DeleteColumn(3);
                        worksheet.DeleteColumn(6);
                        configCellSheet(worksheet, "H2", "رقم الزيارة:", "#b40100");
                        configCellSheet(worksheet, "I2", id.ToString(), "#383838");
                        configCellSheet(worksheet, "H3", "اسم المخبري:", "#b40100");
                        configCellSheet(worksheet, "I3", nameLaboratory, "#383838");
                        configCellSheet(worksheet, "H4", "اسم المريض:", "#b40100");
                        configCellSheet(worksheet, "I4", namePatient, "#383838");
                        configCellSheet(worksheet, "H5", "عمر المريض:", "#b40100");
                        configCellSheet(worksheet, "I5", agePatient, "#383838");
                        configCellSheet(worksheet, "H6", "جنس المريض:", "#b40100");
                        configCellSheet(worksheet, "I6", genderPatient, "#383838");
                        configCellSheet(worksheet, "H7", "تاريخ الزيارة:", "#b40100");
                        configCellSheet(worksheet, "I7", visitData, "#383838");
                        configCellSheet(worksheet, "H8", "عدد التحاليل:", "#b40100");
                        configCellSheet(worksheet, "I8", testCount, "#383838");
                        worksheet.Column(8).AutoFit();
                        worksheet.Column(9).AutoFit();
                    }
                    else
                    {
                        var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewVisits.Rows.Count + 1, dataGridViewVisits.Columns.Count), "جدول_الزيارات");
                        table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;
                        string numberOfVisit = dataGridViewVisits.Rows.Count.ToString();
                        configCellSheet(worksheet, "L3", "عدد الزيارات:", "#b40100");
                        configCellSheet(worksheet, "M3", numberOfVisit, "#383838");
                        worksheet.Column(12).AutoFit();
                        worksheet.Column(13).AutoFit();
                    }
         
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "ملفات Excel (*.xlsx)|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);
                        showSuccessExportDataMessageData();
                        Task.Delay(1500);
                        System.Diagnostics.Process.Start(excelFile.FullName);
                    }
                    if(!isAllVisits)
                    {
                        dataGridViewVisits.DataSource = null;
                        loadFilterData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTry Agin");
                loadFilterData();
            }
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_background form_Background = new Form_background())
                {
                    form_Background.Show();
                    using (Form_AddVisit addVisit = new Form_AddVisit(formMain,form_Background))
                    {
                        addVisit.ShowDialog();
                        addVisit.Dispose();
                        form_Background.Close();
                        form_Background.Dispose();
                        getData();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BTN_Delete_Click(object sender, EventArgs e)
        {
                deleteData();
        }

        private void dataGridViewVisits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewVisits_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridViewVisits_KeyDown(object sender, KeyEventArgs e)
        {
         
                if (e.KeyData == Keys.Delete)
                {
                    if (BTN_Delete.Enabled)
                    {
                        BTN_Delete.PerformClick();
                    }
                }
            
        }

        private void COMP_FilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFilterData();
        }

        private void COMP_FilterData_TextChanged(object sender, EventArgs e)
        {
            loadFilterData();
        }

        private void TX_Search_TextChanged(object sender, EventArgs e)
        {
            if (TX_Search.Text != "")
            {
                searchData(TX_Search.Text);
            }
            else
            {
                loadFilterData();
            }
        }

        private void BTN_Export_Click(object sender, EventArgs e)
        {
            exportData(true);
        }

        private void BTN_View_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {

                    using (Form_background form_Background = new Form_background())
                    {

                        object[] data = { formMain, form_Background, id,namePatient, testCount };
                        form_Background.Opacity = 0.8;
                        form_Background.Show();
                        using (Form_ViewVisitTests visitTests = new Form_ViewVisitTests(data))
                        {
                            visitTests.ShowDialog();
                            visitTests.Dispose();
                            form_Background.Close();
                            form_Background.Dispose();
                        }
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ExportVisit_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                exportData(false);
            }
            else
            {
                ClsMessageCollections.showWarningIdSelectMessageData();
            }
         
        }
    }
}
