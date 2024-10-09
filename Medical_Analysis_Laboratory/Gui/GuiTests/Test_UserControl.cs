using Bunifu.UI.WinForms;
using Medical_Analysis_Laboratory.Classes;
using Medical_Analysis_Laboratory.Classes.Connection.TestProcess;
using Medical_Analysis_Laboratory.Classes.Connection.UsersProcess;
using Medical_Analysis_Laboratory.Forms.FormsFollowUp;
using Medical_Analysis_Laboratory.Forms.FormsPatient;
using Medical_Analysis_Laboratory.Forms.FormsTests;
using Medical_Analysis_Laboratory.Properties;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Medical_Analysis_Laboratory.Gui.GuiTest
{
    public partial class Test_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Var
        private int id = 0;
        private DataTable dataTableNode;
        private DataRow[] filteredRows;
        public static Test_UserControl TestControl;
        private Form formMain;
        Cls_TestDB action = new Cls_TestDB();
        private int testCount;
        private int categoryCount;
        private int total = 0;
        private int nodeTracker = 0;
        #endregion
        public Test_UserControl(Form form)
        {
            InitializeComponent();
            loadInitConfig(form);
        }
        #region Function
        public static Test_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return TestControl ?? (new Test_UserControl(form));
        }
        private void loadInitConfig(Form form)
        {
            this.formMain = form;
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
            getData();
            loadDataToDGV();
        }
        private void getData()
        {
            try
            {
                // استرجاع البيانات من قاعدة البيانات
                dataTableNode = action.getDataTest();
                testCount = dataTableNode.Rows.Count;
                categoryCount = 0;
                // تنظيف TreeView قبل الإضافة
                TR_Tests.Nodes.Clear();
                TR_CategoryTest.Nodes.Clear();

                // استخدام Dictionary لتتبع العقد الأبناء والآباء
                Dictionary<int, TreeNode> nodeLookup = new Dictionary<int, TreeNode>();
                Dictionary<int, TreeNode> categoryNodeLookup = new Dictionary<int, TreeNode>();

                // إنشاء العقد في TreeView بناءً على البيانات
                foreach (DataRow row in dataTableNode.Rows)
                {
                    try
                    {
                        // التحقق من القيم قبل التحويل
                        int id = row["المعرف"] != DBNull.Value ? Convert.ToInt32(row["المعرف"]) : 0;
                        string name = row["الاسم"].ToString();
                        int? parentId = row["رقم الأب"] != DBNull.Value ? (int?)Convert.ToInt32(row["رقم الأب"]) : null;
                        bool isCategoryNode = row["هل هو صنف"] != DBNull.Value && Convert.ToBoolean(row["هل هو صنف"]);

                        // إنشاء عقدة جديدة لـ TR_Tests
                        TreeNode newNodeForTests = new TreeNode(name) { Tag = id };

                        // إنشاء عقدة جديدة لـ TR_CategoryTest (فقط في حال كانت صنف)
                        TreeNode newNodeForCategory = new TreeNode(name) { Tag = id };

                        // إضافة العقدة الجديدة إلى TR_Tests
                        if (parentId.HasValue && nodeLookup.ContainsKey(parentId.Value))
                        {
                            nodeLookup[parentId.Value].Nodes.Add(newNodeForTests);
                        }
                        else
                        {
                            // إذا لم يكن لديها أب، أضفها كعقدة رئيسية
                            TR_Tests.Nodes.Add(newNodeForTests);
                        }

                        // أضف العقدة الجديدة إلى الـ Dictionary الخاص بـ TR_Tests
                        nodeLookup[id] = newNodeForTests;

                        // إذا كانت العقدة من نوع الفئة، أضفها إلى TR_CategoryTest
                        if (isCategoryNode)
                        {
                            categoryCount++;
                            // إضافة العقدة الجديدة إلى TR_CategoryTest
                            if (parentId.HasValue && categoryNodeLookup.ContainsKey(parentId.Value))
                            {
                                categoryNodeLookup[parentId.Value].Nodes.Add(newNodeForCategory);
                            }
                            else
                            {
                                // إذا لم يكن لديها أب، أضفها كعقدة رئيسية
                                TR_CategoryTest.Nodes.Add(newNodeForCategory);

                            }

                            // أضف العقدة الجديدة إلى الـ Dictionary الخاص بـ TR_CategoryTest
                            categoryNodeLookup[id] = newNodeForCategory;
                        }
                    }
                    catch (Exception ex)
                    {
                        // معالجة أي استثناءات تحدث داخل الحلقة لكل عقدة
                        MessageBox.Show($"خطأ أثناء معالجة العقدة: {ex.Message}");
                    }
                }

                // توسيع جميع العقد بعد الإضافة
                TR_Tests.ExpandAll();
                TR_CategoryTest.ExpandAll();
            }
            catch (Exception ex)
            {
                // معالجة أي استثناءات عامة أثناء استرجاع البيانات أو بناء الشجرة
                MessageBox.Show($"خطأ عام أثناء تحميل البيانات: {ex.Message}");
            }
        }
        private int getIdCurrentNode()
        {
            if (TR_Tests.SelectedNode != null)
            {
   
                if (int.TryParse(TR_Tests.SelectedNode.Tag.ToString(), out int id))
                {
                    return id;
                }
            }
            return 0;
        }
        private int getIdCurrentNodeToDelete(TreeNode node)
        {
            if (node!= null)
            {
                if (int.TryParse(node.Tag.ToString(), out int id))
                {
                    return id;
                }
            }
            return 0;
        }
        private void hideCulomnFromDGV()
        {
            dataGridViewCurrentNodeInfo.Columns[1].Visible = false;
            dataGridViewCurrentNodeInfo.Columns[2].Visible = false;

        }
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void showSuccessDeleteMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessDeleteData, BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopRight);

        }

        private void searchTreeView(TreeNodeCollection nodes, string searchText)
        {
          /*  bool isFound=false;*/
            foreach (TreeNode node in nodes)
            {
/*                Console.WriteLine("==========-----Name");
                Console.WriteLine("nodeTracker" + node.Text.ToString());*/
                // تحقق مما إذا كان النص المطلوب موجودًا في اسم العقدة الحالية
                if (node.Text.ToLower().Contains(searchText.ToLower()))
                {
                    // إذا كانت العقدة تحتوي على النص المطلوب، قم بتحديدها وتوسيعها
                    TR_Tests.SelectedNode = node;
                    TR_Tests.Focus();
                    node.EnsureVisible(); // التأكد من أن العقدة مرئية بعد التوسيع
                   /* isFound=true;*/
                    nodeTracker = 0;
                    break; // إذا أردت إيقاف البحث عند أول نتيجة
                }

                // إذا كانت العقدة الحالية تحتوي على عقد فرعية، قم بإجراء البحث بشكل تكراري
                if (node.Nodes.Count > 0)
                {
                    searchTreeView(node.Nodes, searchText);

                }
                nodeTracker++;
            }
/*
            Console.WriteLine("==========-----");
            Console.WriteLine("nodeTracker" + nodeTracker.ToString());
            Console.WriteLine("==========");
            Console.WriteLine(total.ToString());*/
            /*!isFound &&*/
            if ( total == nodeTracker)
            {
                ClsMessageCollections.WarningDataIsEmptyMessageData();
                nodeTracker = 0;
            }



        }

        private void searchData(string searchText)
        {
            searchTreeView(TR_Tests.Nodes, searchText);
        }
        private void loadAfterAvtion()
        {
            getData();
            dataGridViewCurrentNodeInfo.DataSource = null;
            setTotalValue();
        }
        #endregion
        #region Event
        private void BTN_Export_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    dataGridViewCurrentNodeInfo.DataSource= action.getDataTest();
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("التحاليل");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewCurrentNodeInfo.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewCurrentNodeInfo.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }
                    int excelRowIndex = 2; 
                    foreach (DataGridViewRow row in dataGridViewCurrentNodeInfo.Rows)
                    {
                        if (row.Visible) 
                        {
                            for (int col = 1; col <= dataGridViewCurrentNodeInfo.Columns.Count; col++)
                            {
                                var cellValue = row.Cells[col - 1].Value != null ? row.Cells[col - 1].Value.ToString() : ""; 
                                worksheet.Cells[excelRowIndex, col].Value = cellValue; 
                            }
                            excelRowIndex++; 
                        }
                    }
                    int numberOfTest = dataGridViewCurrentNodeInfo.Rows.Count;
                    worksheet.Cells["N3"].Value = "عدد التحاليل:";
                    worksheet.Cells["N3"].Style.Font.Bold = true;
                    worksheet.Cells["N3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["N3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["N3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(14).Width = 15;
                    worksheet.Column(15).Width = 15;
                    worksheet.Cells["O3"].Style.Font.Bold = true;
                    worksheet.Cells["O3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["O3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["O3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["O3"].Value = numberOfTest;
                    for (int col = 1; col <= dataGridViewCurrentNodeInfo.Columns.Count; col++)
                    {
                        worksheet.Column(col).AutoFit();

                    }
                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewCurrentNodeInfo.Rows.Count + 1, dataGridViewCurrentNodeInfo.Columns.Count), "جدول_التحاليل");
                    table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;
                    // حفظ الملف
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
                    dataGridViewCurrentNodeInfo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTry Agin");
            }
        }
        private void TX_Search_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        public void setTotalValue()
        {
            testCount = testCount- categoryCount;
            total =testCount+categoryCount;
            dataGridViewTotalValue.Rows[0].Cells[2].Value = testCount;
            dataGridViewTotalValue.Rows[1].Cells[2].Value = categoryCount;
            dataGridViewTotalValue.Rows[2].Cells[2].Value = total;
        }
        public void loadDataToDGV()
        {
            DataTable dataTableTotalValue = new DataTable();
            dataTableTotalValue.Columns.Add("#");
            dataTableTotalValue.Columns.Add("الاسم");
            dataTableTotalValue.Columns.Add("العدد");
            dataTableTotalValue.Rows.Add(1,"التحاليل", 50);
            dataTableTotalValue.Rows.Add(2,"الاصناف", 50);
            dataTableTotalValue.Rows.Add(3, "الكلي", 50);
            dataGridViewTotalValue.DataSource = dataTableTotalValue;
            setTotalValue();
        }
        private TreeNode getSelectedNode()
        {
            TreeNode cuurentNode = null;
            if (TR_Tests.SelectedNode != null)
            {
                cuurentNode = TR_Tests.SelectedNode;
            }
            return cuurentNode;
            
        }
        private bool getStateNodeDelete()
        {
            TreeNode selectedNode = getSelectedNode();
          
            return selectedNode != null && selectedNode.Nodes.Count > 0;
        }
        private void addData()
        {
            try
            {

                if (dataGridViewCurrentNodeInfo.Rows.Count > 0 && TR_Tests.SelectedNode != null)
                {
                    using (Form_AddTests addTests = new Form_AddTests(formMain, getSelectedNode()))
                    {
                        addTests.ShowDialog();
                    }

                    loadAfterAvtion();
                }
                else
                {
                    ClsMessageCollections.showWarningSelectPanentNodeMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteAllNodeChild(TreeNodeCollection nodes, string proc)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count > 0)
                {
                   
                    deleteAllNodeChild(node.Nodes, proc);
                }
                action.deleteTest(getIdCurrentNodeToDelete(node), proc);
            }
        }

        // استدعاء الدالة للعقدة المحددة
        private void deleteSelectedNodeWithChildren(TreeNode selectedNode, string proc)
        {
            deleteAllNodeChild(selectedNode.Nodes, proc);
            action.deleteTest(getIdCurrentNodeToDelete(selectedNode), proc);
        }

        private void deleteData()
        {
            bool isDelete = false;
            try
            {

                if (dataGridViewCurrentNodeInfo.Rows.Count > 0 && TR_Tests.SelectedNode != null)
                {
                    if (getStateNodeDelete())
                    {
                        using(FormDelete formDelete = new FormDelete())
                        {
                            formDelete.configFormTest(getSelectedNode().Text);
                            formDelete.ShowDialog();
                            if (formDelete.getResult() == 1)
                            {
                                deleteSelectedNodeWithChildren(getSelectedNode(), "deleteTestParentWithoutChild");
                                action.deleteTest(getIdCurrentNode(), "deleteTest");
                                isDelete =true;
                            }
                            else if (formDelete.getResult() == 2)
                            {
                                deleteSelectedNodeWithChildren(getSelectedNode(), "deleteTestParentWithChild");
                           /*     deleteAllNodeChild(getSelectedNode().Nodes, "deleteTest");*/
                                isDelete = true;
                            }
                        }
                    }
                    else
                    {
                        if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                        {
                            action.deleteTest(getIdCurrentNode(), "deleteTest");
                            isDelete = true;
                        }
                    }
                    if (isDelete)
                    {
                        showSuccessDeleteMessageData();
                        loadAfterAvtion();
                        isDelete = false;
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
        private void updateData()
        {
           /* try*/
            {
                if (dataGridViewCurrentNodeInfo.Rows.Count > 0 && TR_Tests.SelectedNode != null)
                {
                   using (Form_AddTests updateTests= new Form_AddTests(formMain, filteredRows))
                    {
                        updateTests.ShowDialog();
                        loadAfterAvtion();
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
        /*    catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:79-FG_User ", "خطأ");
            }*/
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addData();
        }
        
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void TR_Tests_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TR_Tests.SelectedNode != null && dataTableNode.Rows.Count > 0)
            {

                // استرجاع الصفوف التي تطابق المعرف الحالي
                 filteredRows = dataTableNode.Select("المعرف = " + getIdCurrentNode());

                if (filteredRows.Length > 0)
                {
                    // تحويل DataRow[] إلى DataTable لتعيينه إلى DataGridView
                    DataTable filteredTable = filteredRows.CopyToDataTable();
                    dataGridViewCurrentNodeInfo.DataSource = filteredTable;
                    hideCulomnFromDGV();
                }
                else
                {
                    // في حال عدم وجود بيانات مطابقة
                    dataGridViewCurrentNodeInfo.DataSource = null;
                }
            }

        }

        private void TR_Tests_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          /*  if ((e.Button == MouseButtons.Right))
            {
                BTN_Update.PerformClick();
            }*/
        }

        private void TR_Tests_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
        
                TreeNode clickedNode = TR_Tests.GetNodeAt(e.X, e.Y);

                if (clickedNode != null)
                {
                 
                    TR_Tests.SelectedNode = clickedNode;
                }
            }
          
        }

        private void TR_Tests_KeyDown(object sender, KeyEventArgs e)
        {
            if (BTN_Delete.Enabled)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    BTN_Delete.PerformClick();
                }
            }
           
        }

        private void TSM_addData_Click(object sender, EventArgs e)
        {
            BTN_Add.PerformClick();
        }

        private void TSM_updateData_Click(object sender, EventArgs e)
        {
            BTN_Update.PerformClick();
        }

        private void TSM_deleteData_Click(object sender, EventArgs e)
        {
            BTN_Delete.PerformClick();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (TX_Search.Text != "")
            {
                searchData(TX_Search.Text);
                nodeTracker = 0;
            }
        }

        private void TX_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Search.PerformClick();
            }
        }

        private void CMS_TRTests_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TR_Tests.SelectedNode == null|| !BTN_Delete.Enabled) 
            {
                e.Cancel = true; 
            }
        }
    }
}
