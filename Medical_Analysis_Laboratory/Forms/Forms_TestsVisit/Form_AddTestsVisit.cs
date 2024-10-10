using Medical_Analysis_Laboratory.Classes;
using Medical_Analysis_Laboratory.Classes.Connection.TestProcess;
using Medical_Analysis_Laboratory.Classes.Connection.VisitsProcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Analysis_Laboratory.Forms.Forms_TestsVisit
{
    public partial class Form_AddTestsVisit : DevExpress.XtraEditors.XtraForm
    {
        #region VAR
        Cls_TestDB testDB =new Cls_TestDB();
        private DataTable cachedDataTestToVisit;
        private DataTable cachedDataNameTestToVisit;
        int numberCompo = 1;
        private int testNumber = -1;
        private bool isUpdating = false;
        #endregion
        public Form_AddTestsVisit(int testNumber,string namePatient)
        {
            InitializeComponent();
            loadData(testNumber, namePatient);
           /*enabledCompo();*/
        }
        #region Function
        /*     private void enabledCompo()
             {
                 MessageBox.Show(numberCompo.ToString());
                 // العثور على الـ ComboBox الحالي بناءً على الرقم الحالي
                 var comboBoxToUpdate = this.Controls.Find($"COMP_NameTest_{numberCompo}", true).FirstOrDefault() as ComboBox;

                 if (comboBoxToUpdate != null)
                 {
                     comboBoxToUpdate.Enabled = true;

                     // تحقق مما إذا كان قد تم تحديد عنصر في comboBox الحالي
                     if (comboBoxToUpdate.SelectedIndex != -1)
                     {
                         // زيادة الرقم للوصول إلى الـ ComboBox التالي
                         numberCompo++;

                         // العثور على الـ ComboBox التالي لتفعيله
                         var comboBoxToUpdateNext = this.Controls.Find($"COMP_NameTest_{numberCompo}", true).FirstOrDefault() as ComboBox;

                         if (comboBoxToUpdateNext != null)
                         {
                             comboBoxToUpdateNext.Enabled = true; // تفعيل الـ ComboBox التالي
                         }
                     }
                     else
                     {
                         // إذا لم يتم تحديد عنصر، تعطيل الـ ComboBox التالي
                         var comboBoxToUpdateNext = this.Controls.Find($"COMP_NameTest_{numberCompo + 1}", true).FirstOrDefault() as ComboBox;

                         if (comboBoxToUpdateNext != null)
                         {
                             comboBoxToUpdateNext.Enabled = false; // تعطيل الـ ComboBox التالي
                         }
                     }
                 }
             }*/
        public void checkInputTextBoxNumber(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                ClsMessageCollections.showWarningInputJustNumberMessageData(); 
            }
            else if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false; 
            }
        }
        private void loadData(int testNumber,string namePatient)
        {
            if (cachedDataTestToVisit == null)
            {
                cachedDataTestToVisit = testDB.getDataTestToVisit(); 
                cachedDataNameTestToVisit = cachedDataTestToVisit;
            }
            this.testNumber = testNumber;
            LBL_NamePatient.Text = namePatient;
            LBL_TestCount.Text = $"“{testNumber}”";
            CreateRepeatedControls(testNumber);
        }
        private Label createLable(string text,Point loc)
        {
            Label labelName = new Label
            {
                Text = text,
                Font = new Font("Cairo", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(180, 1, 0),
                Location = new Point(loc.X,loc.Y),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            return labelName;
        }
        public int getIdTestSelected(ComboBox comboBox)
        {
            try
            {
                if (comboBox.SelectedIndex != -1)
                {
                    int idTest;
                    Int32.TryParse(comboBox.SelectedValue.ToString(), out idTest);
                    return idTest;
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
        private void configTextBoxValue(ComboBox comboBox, TextBox textBoxValue)
        {
            if (comboBox.SelectedIndex != -1)
            {
               textBoxValue.Enabled = true;
               textBoxValue.BackColor = Color.White;
               textBoxValue.Clear();
            }
            else
            {
                textBoxValue.Enabled = false;
                textBoxValue.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void HandleTestSelection(TextBox textBox, ComboBox comboBox)
        {

            if (!isUpdating)
            {
                updateRangeValue(textBox, comboBox);
             /*   updateNameTest(comboBox);*/
            }
           /* getIdTestSelected(comboBox);*/
           
        }
        private void HandleTextChanged(ComboBox comboBox, TextBox textBox, RichTextBox richTextBox)
        {
            loadConfigDiagnosis(comboBox, textBox, richTextBox);
        }
        private void loadConfigDiagnosis(ComboBox comboBox, TextBox textBox, RichTextBox richTextBox)
        {
            if (comboBox.SelectedIndex != -1&&textBox.Text!="")
            {
                DataRow[] dataRow = cachedDataTestToVisit.Select("المعرف =" + getIdTestSelected(comboBox));
                if (dataRow != null)
                {
                    var beginRange = Convert.ToSingle(dataRow[0][2].ToString());
                    var endRange = Convert.ToSingle(dataRow[0][3].ToString());
                    var diagnosisValueLessThanBegin= dataRow[0][4].ToString();
                    var diagnosisValueBetweenRange= dataRow[0][5].ToString();
                    var diagnosisValueBiggerThanEnd= dataRow[0][6].ToString();
                    if (textBox.Text != ".")
                    {
                        float.TryParse(textBox.Text, out var val);
                        if (val < beginRange)
                        {
                            textBox.BackColor = Color.Red;

                            richTextBox.Text = diagnosisValueLessThanBegin;

                        }
                        else if (val > endRange)
                        {
                            textBox.BackColor = Color.Red;

                            richTextBox.Text = diagnosisValueBiggerThanEnd;
                        }
                        else if (val >= beginRange && val <= endRange)
                        {
                            textBox.BackColor = Color.SeaGreen;

                            richTextBox.Text = diagnosisValueBetweenRange;
                        }
                        textBox.ForeColor = Color.White;
                    }
                  
                    /* textBox.Text = $"{beginRange} ~ {endRange}";*/
                }
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                richTextBox.Clear();
            }
        }
        private void updateRangeValue(TextBox textBox, ComboBox comboBox)
        {
            if (comboBox.SelectedIndex != -1)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(comboBox.Name);
                DataRow[] dataRow = cachedDataTestToVisit.Select("المعرف =" + getIdTestSelected(comboBox));
                if (dataRow != null)
                {
                    var beginRange = dataRow[0][2].ToString();
                    var endRange = dataRow[0][3].ToString();

                    textBox.Text = $"{beginRange} ~ {endRange}";
                    
                }
                else
                {
                    textBox.Clear();
                }
                dataRow = null;
            }
        
       
        }
        /*     private void updateNameTest(ComboBox passedComboBox)
             {
            
                 if (cachedDataTestToVisit == null || cachedDataTestToVisit.Rows.Count == 0)
                 {
                     return;
                 }

               
                 int selectedTestId = getIdTestSelected(passedComboBox);

    
                 DataRow[] filteredData = cachedDataTestToVisit.Select("المعرف <> " + selectedTestId);


                 if (filteredData != null && filteredData.Length > 0)
                 {

                     DataTable updatedData = filteredData.CopyToDataTable();

     
                     for (int i = 0; i < testNumber; i++)
                     {
         
                         var comboBoxToUpdate = this.Controls.Find($"COMP_NameTest_{i + 1}", true).FirstOrDefault() as ComboBox;

                         if (comboBoxToUpdate != null && comboBoxToUpdate.Name != passedComboBox.Name)
                         {
                             Console.WriteLine("======Found=====");
                             Console.WriteLine(comboBoxToUpdate.Name);

                     
                             comboBoxToUpdate.BindingContext = new BindingContext();
                             comboBoxToUpdate.DataSource = updatedData;
                             comboBoxToUpdate.DisplayMember = "الاسم";
                             comboBoxToUpdate.ValueMember = "المعرف";
                             comboBoxToUpdate.SelectedIndex = -1;
                         }
                     }
                 }
             }*/
        /*  private void updateNameTest(ComboBox passedComboBox)
          {
              DataRow[] filteredData;
              List<string> selectedIds = new List<string>();
              for (int i = 0; i < testNumber; i++)
              {
                  var compo = this.Controls.Find($"COMP_NameTest_{i + 1}", true).FirstOrDefault() as ComboBox;

                  if (compo != null && compo.SelectedIndex != -1)
                  {
                      string selectedId = getIdTestSelected(compo).ToString();
                      selectedIds.Add(selectedId); 
                  }
              }
              string filterCondition = string.Join(" OR ", selectedIds.Select(id => $"المعرف = {id}"));

              if (selectedIds.Count > 0)
              {
                  string filteredCondition = "المعرف NOT IN (" + string.Join(", ", selectedIds) + ")";
                  filteredData = cachedDataTestToVisit.Select(filteredCondition);
              }
              else
              {
                  filteredData = cachedDataTestToVisit.Select(); 
              }
              if (filteredData != null && filteredData.Length > 0)
              {
                  DataTable updatedData = filteredData.CopyToDataTable();
                  cachedDataNameTestToVisit = updatedData;
                  for (int i = 0; i < testNumber; i++)
                  {
                      var comboBoxToUpdate = this.Controls.Find($"COMP_NameTest_{i + 1}", true).FirstOrDefault() as ComboBox;

                      if (comboBoxToUpdate != null && comboBoxToUpdate.Name != passedComboBox.Name&&
                          (comboBoxToUpdate.SelectedIndex == -1|| comboBoxToUpdate.Text==passedComboBox.Text)
                          )
                      {
                          Console.WriteLine("=-=-=-=-=-=-");
                          Console.WriteLine("======Found=====New");
                          Console.WriteLine(comboBoxToUpdate.Name);
                          isUpdating = true;
                          comboBoxToUpdate.BindingContext = new BindingContext();
                          comboBoxToUpdate.DataSource = updatedData;
                          comboBoxToUpdate.DisplayMember = "الاسم";
                          comboBoxToUpdate.ValueMember = "المعرف";
                          comboBoxToUpdate.SelectedIndex = -1;
                          isUpdating = false;
                      }
                      */
        /*  if(comboBoxToUpdate != null && comboBoxToUpdate.Text != passedComboBox.Text&&
                          comboBoxToUpdate.SelectedIndex!=-1)
                      {
                          string nameTest= comboBoxToUpdate.Text;
                          isUpdating = true;
                          comboBoxToUpdate.BindingContext = new BindingContext();
                          comboBoxToUpdate.DataSource = updatedData;
                          comboBoxToUpdate.DisplayMember = "الاسم";
                          comboBoxToUpdate.ValueMember = "المعرف";
                          comboBoxToUpdate.Text = nameTest;
                          isUpdating = false;
                      } }*/
        /*     foreach (var control in flowLayoutPanel1.Controls)
             {


                 if (control is ComboBox comboBox && comboBox != passedComboBox)
                 {
                     Console.WriteLine(comboBox.Name + "asdasdad");

                     comboBox.BindingContext = new BindingContext();


                     comboBox.DataSource = updatedData;


                     comboBox.DisplayMember = "الاسم";
                     comboBox.ValueMember = "المعرف";

                     comboBox.SelectedIndex = -1;
                 }
             }}}*/
        private void CreateRepeatedControls(int numberOfCopies)
        {
            for (int i = 0; i < numberOfCopies; i++)
            {
                var groupControl = new DevExpress.XtraEditors.GroupControl
                {
                    AppearanceCaption =
                    {
                        TextOptions =
                        {
                            HAlignment = DevExpress.Utils.HorzAlignment.Center,
                        },
                        BackColor = Color.FromArgb(180, 180, 180),
                        BorderColor = Color.FromArgb(232, 178, 178),
                        Font = new Font("Cairo", 12F, FontStyle.Bold),
                    },
                    Text = $"التحليل - {i + 1}",
                    Size = new Size(366, 388),
                    RightToLeft =  RightToLeft.Yes

                };
               
                groupControl.Margin = new Padding(0, 12, 10, 0);
                if (i == 0||i%5==0)
                {
                    groupControl.Margin= new Padding(10, 12, 10, 0);
                }
                if(i== numberOfCopies - 1)
                {
                    groupControl.Margin = new Padding(0, 12, 10, 0);
                }

                Label lblNameTest= createLable("اسم التحليل", new Point(122, 41));
                var COMP_NameTest_ = new ComboBox
                {
                    BackColor = Color.White,
                    Size = new Size(336, 50),
                    Name = $"COMP_NameTest_{i + 1}",
                    Font = new Font("Cairo", 13F),
                    Location = new Point(20, 81),
                    AutoCompleteMode = AutoCompleteMode.Append,
                    AutoCompleteSource = AutoCompleteSource.ListItems,
                    DropDownStyle = ComboBoxStyle.DropDown,
                    DataSource = cachedDataTestToVisit,
                    ValueMember = "المعرف",
                    DisplayMember = "الاسم",
                    TabIndex = 0,
                 };
                COMP_NameTest_.BindingContext = new BindingContext();
                COMP_NameTest_.SelectedIndex = -1;
            
                Label lblValTest =createLable("الـــــقــيــمــة", new Point(211, 134));
                TextBox textBoxValue = new TextBox
                {
                    Name= $"TX_testVal_{i+1}",
                    Size = new Size(158, 45),
                    Font = new Font("Cairo", 12F),
                    Location = new Point(198, 175),
                    BorderStyle = BorderStyle.FixedSingle,
                    Enabled = false,
                    TabIndex = 1,

                };
           
                Label lblRange = createLable("المــــــجــال", new Point(40, 134));
                TextBox textBoxRange = new TextBox
                {
                    Text = "7.3 ~ 8.4",
                    TextAlign=HorizontalAlignment.Center,
                    RightToLeft = RightToLeft.No,
                    Name = $"TX_testRange_{i + 1}",
                    Size = new Size(158, 45),
                    Font = new Font("Cairo", 12F,FontStyle.Bold),
                    Location = new Point(20, 175),
                    ReadOnly = true,
                    ForeColor = Color.Red,
                };
                Label labelDiagnosis = createLable("التشـــخيـــص", new Point(123, 227));
                RichTextBox richTextBoxDiagnosis = new RichTextBox
                {
                   WordWrap=true,
                   Location= new Point(20, 272),
                   Size=new Size(336, 98),
                   Font = new Font("Cairo", 12F),
                   BorderStyle = BorderStyle.Fixed3D,
                   ReadOnly=true,
                   
                   
                };


                COMP_NameTest_.SelectedIndexChanged += (sender, e) =>
                {
                    var comboBox = sender as ComboBox;

                    HandleTestSelection(textBoxRange, comboBox);
                    configTextBoxValue(comboBox, textBoxValue);

                };
                COMP_NameTest_.TextChanged += (sender, e) =>
                {
                    var comboBox = sender as ComboBox;
                    if (comboBox.SelectedIndex==-1)
                    {
                        textBoxRange.Clear();
                        textBoxValue.Clear();
                    }
                    configTextBoxValue(comboBox, textBoxValue);
                    /*enabledCompo();*/
                };
                textBoxValue.TextChanged += (sender, e) =>
                {
                    var textVal = sender as TextBox;
                    HandleTextChanged(COMP_NameTest_,textVal, richTextBoxDiagnosis);
                };
                textBoxValue.KeyPress += (sender, e) =>
                {
                    var textVal = sender as TextBox;
                    checkInputTextBoxNumber(sender, e);
                };
                groupControl.Controls.Add(lblNameTest);
                groupControl.Controls.Add(COMP_NameTest_);
                groupControl.Controls.Add(lblValTest);
                groupControl.Controls.Add(textBoxValue);
                groupControl.Controls.Add(lblRange);
                groupControl.Controls.Add(textBoxRange);
                groupControl.Controls.Add(labelDiagnosis);
                groupControl.Controls.Add(richTextBoxDiagnosis);

                flowLayoutPanel1.Controls.Add(groupControl);


                StorageCacheVisit storage = new StorageCacheVisit
                {
                    NumberOfTest = i + 1,
                    NameCompoTest = COMP_NameTest_,
                    NameTextValue = textBoxValue,
                    NameRichDiagnosis = richTextBoxDiagnosis
                };
                StorageCacheVisit.StorageCacheVisitsTemp.Add(storage);

            }
        }
        public bool checkData(List <StorageCacheVisit> list)
        {
            foreach (var info in list)
            {
                if (info.NameCompoTest.SelectedIndex == -1 || info.NameTextValue.Text == "")
                    return false;
            }
            return true;
        }
        private void saveData()
        {
            try
            {
                if (checkData(StorageCacheVisit.StorageCacheVisitsTemp))
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        StorageCacheVisit.StorageCacheVisits.AddRange(StorageCacheVisit.StorageCacheVisitsTemp);
                        StorageCacheVisit.StorageCacheVisitsTemp.Clear();
                        this.Close();
                    }
                }
                else
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Event
        private void BTN_Add_Close_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            StorageCacheVisit.StorageCacheVisitsTemp.Clear();
            this.Close();
        }
        #endregion
    }
}