namespace Medical_Analysis_Laboratory.Forms.FormsTests
{
    partial class Form_AddTests
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddTests));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_ParentName = new System.Windows.Forms.TextBox();
            this.RTB_Note = new System.Windows.Forms.RichTextBox();
            this.LBL_RangeValue = new System.Windows.Forms.Label();
            this.GC_rangeValue = new DevExpress.XtraEditors.GroupControl();
            this.label10 = new System.Windows.Forms.Label();
            this.TX_RangeEnd = new System.Windows.Forms.TextBox();
            this.TX_RangeBegin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_Note = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RB_Yes = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RB_No = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.TX_NameTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GC_diagnosisValue = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RTB_diagnosisValueBiggerThanEnd = new System.Windows.Forms.RichTextBox();
            this.RTB_diagnosisValueBetweenRange = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RTB_diagnosisValueLessThanBegin = new System.Windows.Forms.RichTextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.COMP_isRoot = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_AddClose = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_rangeValue)).BeginInit();
            this.GC_rangeValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_diagnosisValue)).BeginInit();
            this.GC_diagnosisValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.TX_ParentName);
            this.groupBox1.Controls.Add(this.RTB_Note);
            this.groupBox1.Controls.Add(this.LBL_RangeValue);
            this.groupBox1.Controls.Add(this.GC_rangeValue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LBL_Note);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RB_Yes);
            this.groupBox1.Controls.Add(this.RB_No);
            this.groupBox1.Controls.Add(this.TX_NameTest);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GC_diagnosisValue);
            this.groupBox1.Controls.Add(this.groupControl3);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox1.Location = new System.Drawing.Point(515, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 557);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات التحليل الطـبي";
            // 
            // TX_ParentName
            // 
            this.TX_ParentName.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_ParentName.Location = new System.Drawing.Point(490, 39);
            this.TX_ParentName.Name = "TX_ParentName";
            this.TX_ParentName.ReadOnly = true;
            this.TX_ParentName.Size = new System.Drawing.Size(365, 45);
            this.TX_ParentName.TabIndex = 64;
            this.TX_ParentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RTB_Note
            // 
            this.RTB_Note.Font = new System.Drawing.Font("Cairo", 12F);
            this.RTB_Note.Location = new System.Drawing.Point(490, 440);
            this.RTB_Note.Name = "RTB_Note";
            this.RTB_Note.Size = new System.Drawing.Size(365, 111);
            this.RTB_Note.TabIndex = 63;
            this.RTB_Note.Text = "";
            // 
            // LBL_RangeValue
            // 
            this.LBL_RangeValue.AutoSize = true;
            this.LBL_RangeValue.Font = new System.Drawing.Font("Cairo", 12F);
            this.LBL_RangeValue.Location = new System.Drawing.Point(892, 307);
            this.LBL_RangeValue.Name = "LBL_RangeValue";
            this.LBL_RangeValue.Size = new System.Drawing.Size(133, 37);
            this.LBL_RangeValue.TabIndex = 4;
            this.LBL_RangeValue.Text = "القيم الطبيعية";
            // 
            // GC_rangeValue
            // 
            this.GC_rangeValue.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GC_rangeValue.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.GC_rangeValue.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GC_rangeValue.AppearanceCaption.Options.UseBackColor = true;
            this.GC_rangeValue.AppearanceCaption.Options.UseBorderColor = true;
            this.GC_rangeValue.AppearanceCaption.Options.UseFont = true;
            this.GC_rangeValue.AppearanceCaption.Options.UseTextOptions = true;
            this.GC_rangeValue.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GC_rangeValue.Controls.Add(this.label10);
            this.GC_rangeValue.Controls.Add(this.TX_RangeEnd);
            this.GC_rangeValue.Controls.Add(this.TX_RangeBegin);
            this.GC_rangeValue.Controls.Add(this.label2);
            this.GC_rangeValue.Location = new System.Drawing.Point(490, 296);
            this.GC_rangeValue.Name = "GC_rangeValue";
            this.GC_rangeValue.Size = new System.Drawing.Size(365, 134);
            this.GC_rangeValue.TabIndex = 57;
            this.GC_rangeValue.Text = "مجال القيم الطبيعية";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(196, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 37);
            this.label10.TabIndex = 60;
            this.label10.Text = "الــــبـــــدايــــــة";
            // 
            // TX_RangeEnd
            // 
            this.TX_RangeEnd.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_RangeEnd.Location = new System.Drawing.Point(16, 82);
            this.TX_RangeEnd.Name = "TX_RangeEnd";
            this.TX_RangeEnd.Size = new System.Drawing.Size(162, 45);
            this.TX_RangeEnd.TabIndex = 59;
            this.TX_RangeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.TX_RangeEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_RangeEnd_KeyDown);
            this.TX_RangeEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_RangeEnd_KeyPress);
            this.TX_RangeEnd.Leave += new System.EventHandler(this.TX_RangeEnd_Leave);
            // 
            // TX_RangeBegin
            // 
            this.TX_RangeBegin.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_RangeBegin.Location = new System.Drawing.Point(188, 82);
            this.TX_RangeBegin.Name = "TX_RangeBegin";
            this.TX_RangeBegin.Size = new System.Drawing.Size(162, 45);
            this.TX_RangeBegin.TabIndex = 58;
            this.TX_RangeBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.TX_RangeBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_RangeBegin_KeyDown);
            this.TX_RangeBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_RangeBegin_KeyPress);
            this.TX_RangeBegin.Leave += new System.EventHandler(this.TX_RangeBegin_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 58;
            this.label2.Text = "الــــنهــــايــــــة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 12F);
            this.label9.Location = new System.Drawing.Point(899, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 37);
            this.label9.TabIndex = 56;
            this.label9.Text = "نوع العـقـدة";
            // 
            // LBL_Note
            // 
            this.LBL_Note.AutoSize = true;
            this.LBL_Note.Font = new System.Drawing.Font("Cairo", 12F);
            this.LBL_Note.Location = new System.Drawing.Point(887, 443);
            this.LBL_Note.Name = "LBL_Note";
            this.LBL_Note.Size = new System.Drawing.Size(131, 37);
            this.LBL_Note.TabIndex = 54;
            this.LBL_Note.Text = "ملاحـــــظـــات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F);
            this.label6.Location = new System.Drawing.Point(636, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 37);
            this.label6.TabIndex = 53;
            this.label6.Text = "نعم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F);
            this.label4.Location = new System.Drawing.Point(542, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "لا";
            // 
            // RB_Yes
            // 
            this.RB_Yes.Animated = true;
            this.RB_Yes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.RB_Yes.CheckedState.BorderThickness = 0;
            this.RB_Yes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.RB_Yes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RB_Yes.Location = new System.Drawing.Point(610, 207);
            this.RB_Yes.Name = "RB_Yes";
            this.RB_Yes.Size = new System.Drawing.Size(20, 20);
            this.RB_Yes.TabIndex = 51;
            this.RB_Yes.Text = "guna2CustomRadioButton1";
            this.RB_Yes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.RB_Yes.UncheckedState.BorderThickness = 2;
            this.RB_Yes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RB_Yes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RB_Yes.CheckedChanged += new System.EventHandler(this.RB_Yes_CheckedChanged);
            // 
            // RB_No
            // 
            this.RB_No.Animated = true;
            this.RB_No.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.RB_No.CheckedState.BorderThickness = 0;
            this.RB_No.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.RB_No.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RB_No.Location = new System.Drawing.Point(513, 207);
            this.RB_No.Name = "RB_No";
            this.RB_No.Size = new System.Drawing.Size(20, 20);
            this.RB_No.TabIndex = 50;
            this.RB_No.Text = "guna2CustomRadioButton1";
            this.RB_No.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.RB_No.UncheckedState.BorderThickness = 2;
            this.RB_No.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RB_No.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RB_No.CheckedChanged += new System.EventHandler(this.RB_No_CheckedChanged);
            // 
            // TX_NameTest
            // 
            this.TX_NameTest.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_NameTest.Location = new System.Drawing.Point(490, 98);
            this.TX_NameTest.Name = "TX_NameTest";
            this.TX_NameTest.Size = new System.Drawing.Size(365, 45);
            this.TX_NameTest.TabIndex = 2;
            this.TX_NameTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_NameTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_NameTest_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F);
            this.label5.Location = new System.Drawing.Point(899, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "اســـــم الاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F);
            this.label1.Location = new System.Drawing.Point(897, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اســم التحليل";
            // 
            // GC_diagnosisValue
            // 
            this.GC_diagnosisValue.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GC_diagnosisValue.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.GC_diagnosisValue.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GC_diagnosisValue.AppearanceCaption.Options.UseBackColor = true;
            this.GC_diagnosisValue.AppearanceCaption.Options.UseBorderColor = true;
            this.GC_diagnosisValue.AppearanceCaption.Options.UseFont = true;
            this.GC_diagnosisValue.AppearanceCaption.Options.UseTextOptions = true;
            this.GC_diagnosisValue.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GC_diagnosisValue.Controls.Add(this.label13);
            this.GC_diagnosisValue.Controls.Add(this.label12);
            this.GC_diagnosisValue.Controls.Add(this.RTB_diagnosisValueBiggerThanEnd);
            this.GC_diagnosisValue.Controls.Add(this.RTB_diagnosisValueBetweenRange);
            this.GC_diagnosisValue.Controls.Add(this.label8);
            this.GC_diagnosisValue.Controls.Add(this.RTB_diagnosisValueLessThanBegin);
            this.GC_diagnosisValue.Location = new System.Drawing.Point(29, 42);
            this.GC_diagnosisValue.Name = "GC_diagnosisValue";
            this.GC_diagnosisValue.Size = new System.Drawing.Size(430, 509);
            this.GC_diagnosisValue.TabIndex = 61;
            this.GC_diagnosisValue.Text = "انواع التشخيص";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(21, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(385, 37);
            this.label13.TabIndex = 62;
            this.label13.Text = "التشــخــيــص للــقـــيــــم ”أكـبـر مـن النهاية“";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(11, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 37);
            this.label12.TabIndex = 61;
            this.label12.Text = "التشـخـيـص للــقـيـم ”ضمن المجال (الطبيعية)“";
            // 
            // RTB_diagnosisValueBiggerThanEnd
            // 
            this.RTB_diagnosisValueBiggerThanEnd.Font = new System.Drawing.Font("Cairo", 12F);
            this.RTB_diagnosisValueBiggerThanEnd.Location = new System.Drawing.Point(27, 398);
            this.RTB_diagnosisValueBiggerThanEnd.Name = "RTB_diagnosisValueBiggerThanEnd";
            this.RTB_diagnosisValueBiggerThanEnd.Size = new System.Drawing.Size(365, 98);
            this.RTB_diagnosisValueBiggerThanEnd.TabIndex = 59;
            this.RTB_diagnosisValueBiggerThanEnd.Text = "";
            this.RTB_diagnosisValueBiggerThanEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RTB_diagnosisValueBiggerThanEnd_KeyDown);
            // 
            // RTB_diagnosisValueBetweenRange
            // 
            this.RTB_diagnosisValueBetweenRange.Font = new System.Drawing.Font("Cairo", 12F);
            this.RTB_diagnosisValueBetweenRange.Location = new System.Drawing.Point(27, 239);
            this.RTB_diagnosisValueBetweenRange.Name = "RTB_diagnosisValueBetweenRange";
            this.RTB_diagnosisValueBetweenRange.Size = new System.Drawing.Size(365, 98);
            this.RTB_diagnosisValueBetweenRange.TabIndex = 58;
            this.RTB_diagnosisValueBetweenRange.Text = "";
            this.RTB_diagnosisValueBetweenRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RTB_diagnosisValueBetweenRange_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(391, 37);
            this.label8.TabIndex = 60;
            this.label8.Text = "التشــخــيــص للــقـــيــــم ”أصغر مـن البـدايـة“";
            // 
            // RTB_diagnosisValueLessThanBegin
            // 
            this.RTB_diagnosisValueLessThanBegin.Font = new System.Drawing.Font("Cairo", 12F);
            this.RTB_diagnosisValueLessThanBegin.Location = new System.Drawing.Point(27, 87);
            this.RTB_diagnosisValueLessThanBegin.Name = "RTB_diagnosisValueLessThanBegin";
            this.RTB_diagnosisValueLessThanBegin.Size = new System.Drawing.Size(365, 98);
            this.RTB_diagnosisValueLessThanBegin.TabIndex = 6;
            this.RTB_diagnosisValueLessThanBegin.Text = "";
            this.RTB_diagnosisValueLessThanBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RTB_diagnosisValueLessThanBegin_KeyDown);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.groupControl3.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.COMP_isRoot);
            this.groupControl3.Controls.Add(this.label16);
            this.groupControl3.Controls.Add(this.label11);
            this.groupControl3.Location = new System.Drawing.Point(490, 157);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(365, 126);
            this.groupControl3.TabIndex = 61;
            this.groupControl3.Text = "هل نوع العقدة";
            // 
            // COMP_isRoot
            // 
            this.COMP_isRoot.BackColor = System.Drawing.Color.White;
            this.COMP_isRoot.DropDownHeight = 170;
            this.COMP_isRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_isRoot.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_isRoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.COMP_isRoot.FormattingEnabled = true;
            this.COMP_isRoot.IntegralHeight = false;
            this.COMP_isRoot.Items.AddRange(new object[] {
            "نعم",
            "لا"});
            this.COMP_isRoot.Location = new System.Drawing.Point(16, 79);
            this.COMP_isRoot.MaxDropDownItems = 5;
            this.COMP_isRoot.Name = "COMP_isRoot";
            this.COMP_isRoot.Size = new System.Drawing.Size(171, 42);
            this.COMP_isRoot.TabIndex = 63;
            this.COMP_isRoot.SelectedIndexChanged += new System.EventHandler(this.COMP_isRoot_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(227, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 37);
            this.label16.TabIndex = 62;
            this.label16.Text = "جــــــــــــــذر";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(227, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 37);
            this.label11.TabIndex = 61;
            this.label11.Text = "صــــنـــــــف";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.BTN_AddClose);
            this.groupBox2.Controls.Add(this.BTN_Add);
            this.groupBox2.Controls.Add(this.BTN_Close);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 560);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1552, 92);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحكم";
            // 
            // BTN_AddClose
            // 
            this.BTN_AddClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_AddClose.BackColor = System.Drawing.Color.Transparent;
            this.BTN_AddClose.BorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.BorderRadius = 8;
            this.BTN_AddClose.BorderThickness = 2;
            this.BTN_AddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AddClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AddClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTN_AddClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddClose.ForeColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_AddClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_AddClose.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_save_close_50px;
            this.BTN_AddClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddClose.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_AddClose.Location = new System.Drawing.Point(636, 28);
            this.BTN_AddClose.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_AddClose.Name = "BTN_AddClose";
            this.BTN_AddClose.ShadowDecoration.BorderRadius = 20;
            this.BTN_AddClose.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_AddClose.ShadowDecoration.Depth = 100;
            this.BTN_AddClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_AddClose.Size = new System.Drawing.Size(245, 53);
            this.BTN_AddClose.TabIndex = 8;
            this.BTN_AddClose.Tag = "";
            this.BTN_AddClose.Text = "حفظ وخروج";
            this.BTN_AddClose.Click += new System.EventHandler(this.BTN_AddClose_Click_1);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Add.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Add.BorderColor = System.Drawing.Color.White;
            this.BTN_Add.BorderRadius = 8;
            this.BTN_Add.BorderThickness = 2;
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTN_Add.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Add.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_save_50px;
            this.BTN_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Add.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Add.Location = new System.Drawing.Point(915, 28);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.ShadowDecoration.BorderRadius = 20;
            this.BTN_Add.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Add.ShadowDecoration.Depth = 100;
            this.BTN_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Add.Size = new System.Drawing.Size(245, 53);
            this.BTN_Add.TabIndex = 7;
            this.BTN_Add.Tag = "";
            this.BTN_Add.Text = "حفظ";
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click_1);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Close.BorderColor = System.Drawing.Color.White;
            this.BTN_Close.BorderRadius = 8;
            this.BTN_Close.BorderThickness = 2;
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Close.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Close.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.Brown;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Close.Image")));
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Close.Location = new System.Drawing.Point(351, 28);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(245, 53);
            this.BTN_Close.TabIndex = 9;
            this.BTN_Close.Tag = "";
            this.BTN_Close.Text = "اغلاق";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Medical_Analysis_Laboratory.Properties.Resources.add_test;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-55, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(628, 515);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MessageShow
            // 
            this.MessageShow.AllowDragging = false;
            this.MessageShow.AllowMultipleViews = true;
            this.MessageShow.ClickToClose = true;
            this.MessageShow.DoubleClickToClose = true;
            this.MessageShow.DurationAfterIdle = 3000;
            this.MessageShow.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.ErrorOptions.ActionBorderRadius = 1;
            this.MessageShow.ErrorOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageShow.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.ErrorOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.MessageShow.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.MessageShow.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MessageShow.ErrorOptions.ForeColor = System.Drawing.Color.White;
            this.MessageShow.ErrorOptions.Icon = null;
            this.MessageShow.ErrorOptions.IconLeftMargin = 12;
            this.MessageShow.FadeCloseIcon = false;
            this.MessageShow.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.MessageShow.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.ActionBorderRadius = 0;
            this.MessageShow.InformationOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.InformationOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.InformationOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.InformationOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.Icon = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_ok_50px;
            this.MessageShow.InformationOptions.IconLeftMargin = 0;
            this.MessageShow.Margin = 1;
            this.MessageShow.MaximumSize = new System.Drawing.Size(0, 0);
            this.MessageShow.MaximumViews = 7;
            this.MessageShow.MessageRightMargin = 15;
            this.MessageShow.MessageTopMargin = 0;
            this.MessageShow.MinimumSize = new System.Drawing.Size(300, 0);
            this.MessageShow.ShowBorders = true;
            this.MessageShow.ShowCloseIcon = true;
            this.MessageShow.ShowIcon = true;
            this.MessageShow.ShowShadows = true;
            this.MessageShow.SuccessOptions.ActionBackColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.ActionBorderColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.ActionBorderRadius = 3;
            this.MessageShow.SuccessOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ActionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.Icon = null;
            this.MessageShow.SuccessOptions.IconLeftMargin = 12;
            this.MessageShow.ViewsMargin = 7;
            this.MessageShow.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.WarningOptions.ActionBorderRadius = 1;
            this.MessageShow.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MessageShow.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.WarningOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.MessageShow.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.MessageShow.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MessageShow.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.MessageShow.WarningOptions.Icon = null;
            this.MessageShow.WarningOptions.IconLeftMargin = 12;
            this.MessageShow.ZoomCloseIcon = true;
            // 
            // Form_AddTests
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_Add_Male_User_Group_40px;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddTests";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة تحليل";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_rangeValue)).EndInit();
            this.GC_rangeValue.ResumeLayout(false);
            this.GC_rangeValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_diagnosisValue)).EndInit();
            this.GC_diagnosisValue.ResumeLayout(false);
            this.GC_diagnosisValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTB_diagnosisValueLessThanBegin;
        private System.Windows.Forms.TextBox TX_NameTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_RangeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
        private Guna.UI2.WinForms.Guna2Button BTN_AddClose;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_Note;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RB_Yes;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RB_No;
        private DevExpress.XtraEditors.GroupControl GC_rangeValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TX_RangeEnd;
        private System.Windows.Forms.TextBox TX_RangeBegin;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl GC_diagnosisValue;
        private System.Windows.Forms.RichTextBox RTB_diagnosisValueBiggerThanEnd;
        private System.Windows.Forms.RichTextBox RTB_diagnosisValueBetweenRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox RTB_Note;
        private System.Windows.Forms.TextBox TX_ParentName;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox COMP_isRoot;
    }
}