namespace Medical_Analysis_Laboratory.Forms.FormsVisits
{
    partial class Form_AddVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddVisit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RTB_Note = new System.Windows.Forms.RichTextBox();
            this.LBL_RangeValue = new System.Windows.Forms.Label();
            this.GC_rangeValue = new DevExpress.XtraEditors.GroupControl();
            this.LBL_totalTestsNumber = new System.Windows.Forms.Label();
            this.LBL_remainingNumber = new System.Windows.Forms.Label();
            this.TX_testsNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TX_remainingNumber = new System.Windows.Forms.TextBox();
            this.TX_totalTestsNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_Note = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_AddClose = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.COMP_NamePatient = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewTestsVisit = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_AddTestsToVisit = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GC_rangeValue)).BeginInit();
            this.GC_rangeValue.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestsVisit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB_Note
            // 
            this.RTB_Note.Font = new System.Drawing.Font("Cairo", 12F);
            this.RTB_Note.Location = new System.Drawing.Point(494, 416);
            this.RTB_Note.Name = "RTB_Note";
            this.RTB_Note.Size = new System.Drawing.Size(365, 138);
            this.RTB_Note.TabIndex = 63;
            this.RTB_Note.Text = "";
            // 
            // LBL_RangeValue
            // 
            this.LBL_RangeValue.AutoSize = true;
            this.LBL_RangeValue.Font = new System.Drawing.Font("Cairo", 12F);
            this.LBL_RangeValue.Location = new System.Drawing.Point(884, 149);
            this.LBL_RangeValue.Name = "LBL_RangeValue";
            this.LBL_RangeValue.Size = new System.Drawing.Size(125, 37);
            this.LBL_RangeValue.TabIndex = 4;
            this.LBL_RangeValue.Text = "عدد الـتحاليـل";
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
            this.GC_rangeValue.Controls.Add(this.LBL_totalTestsNumber);
            this.GC_rangeValue.Controls.Add(this.LBL_remainingNumber);
            this.GC_rangeValue.Controls.Add(this.TX_testsNumber);
            this.GC_rangeValue.Controls.Add(this.label1);
            this.GC_rangeValue.Controls.Add(this.label10);
            this.GC_rangeValue.Controls.Add(this.TX_remainingNumber);
            this.GC_rangeValue.Controls.Add(this.TX_totalTestsNumber);
            this.GC_rangeValue.Controls.Add(this.label2);
            this.GC_rangeValue.Location = new System.Drawing.Point(494, 123);
            this.GC_rangeValue.Name = "GC_rangeValue";
            this.GC_rangeValue.Size = new System.Drawing.Size(365, 262);
            this.GC_rangeValue.TabIndex = 57;
            this.GC_rangeValue.Text = "تفاصيل التحاليل";
            // 
            // LBL_totalTestsNumber
            // 
            this.LBL_totalTestsNumber.BackColor = System.Drawing.Color.Transparent;
            this.LBL_totalTestsNumber.Font = new System.Drawing.Font("Cascadia Code", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_totalTestsNumber.ForeColor = System.Drawing.Color.Red;
            this.LBL_totalTestsNumber.Location = new System.Drawing.Point(247, 87);
            this.LBL_totalTestsNumber.Name = "LBL_totalTestsNumber";
            this.LBL_totalTestsNumber.Size = new System.Drawing.Size(39, 37);
            this.LBL_totalTestsNumber.TabIndex = 64;
            this.LBL_totalTestsNumber.Text = "20";
            // 
            // LBL_remainingNumber
            // 
            this.LBL_remainingNumber.AutoSize = true;
            this.LBL_remainingNumber.BackColor = System.Drawing.Color.Transparent;
            this.LBL_remainingNumber.Font = new System.Drawing.Font("Cascadia Code", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_remainingNumber.ForeColor = System.Drawing.Color.Red;
            this.LBL_remainingNumber.Location = new System.Drawing.Point(79, 89);
            this.LBL_remainingNumber.Name = "LBL_remainingNumber";
            this.LBL_remainingNumber.Size = new System.Drawing.Size(39, 29);
            this.LBL_remainingNumber.TabIndex = 63;
            this.LBL_remainingNumber.Text = "20";
            // 
            // TX_testsNumber
            // 
            this.TX_testsNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_testsNumber.Location = new System.Drawing.Point(16, 187);
            this.TX_testsNumber.Name = "TX_testsNumber";
            this.TX_testsNumber.Size = new System.Drawing.Size(334, 45);
            this.TX_testsNumber.TabIndex = 61;
            this.TX_testsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_testsNumber.TextChanged += new System.EventHandler(this.TX_testsNumber_TextChanged);
            this.TX_testsNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_testsNumber_KeyDown);
            this.TX_testsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_testsNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(124, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 62;
            this.label1.Text = "عدد التحاليل";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(30, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 37);
            this.label10.TabIndex = 60;
            this.label10.Text = "العدد المتبقي";
            // 
            // TX_remainingNumber
            // 
            this.TX_remainingNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_remainingNumber.Location = new System.Drawing.Point(16, 82);
            this.TX_remainingNumber.MaxLength = 0;
            this.TX_remainingNumber.Name = "TX_remainingNumber";
            this.TX_remainingNumber.ReadOnly = true;
            this.TX_remainingNumber.Size = new System.Drawing.Size(162, 45);
            this.TX_remainingNumber.TabIndex = 59;
            this.TX_remainingNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TX_totalTestsNumber
            // 
            this.TX_totalTestsNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_totalTestsNumber.Location = new System.Drawing.Point(188, 82);
            this.TX_totalTestsNumber.MaxLength = 0;
            this.TX_totalTestsNumber.Name = "TX_totalTestsNumber";
            this.TX_totalTestsNumber.ReadOnly = true;
            this.TX_totalTestsNumber.Size = new System.Drawing.Size(162, 45);
            this.TX_totalTestsNumber.TabIndex = 58;
            this.TX_totalTestsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(207, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 58;
            this.label2.Text = "العدد المتاح";
            // 
            // LBL_Note
            // 
            this.LBL_Note.AutoSize = true;
            this.LBL_Note.Font = new System.Drawing.Font("Cairo", 12F);
            this.LBL_Note.Location = new System.Drawing.Point(884, 419);
            this.LBL_Note.Name = "LBL_Note";
            this.LBL_Note.Size = new System.Drawing.Size(131, 37);
            this.LBL_Note.TabIndex = 54;
            this.LBL_Note.Text = "ملاحـــــظـــات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F);
            this.label5.Location = new System.Drawing.Point(888, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "اســـم المريض";
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
            this.BTN_AddClose.Location = new System.Drawing.Point(615, 28);
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
            this.BTN_AddClose.Click += new System.EventHandler(this.BTN_AddClose_Click);
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
            this.BTN_Add.Location = new System.Drawing.Point(894, 28);
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
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
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
            this.BTN_Close.Location = new System.Drawing.Point(330, 28);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.BTN_AddClose);
            this.groupBox2.Controls.Add(this.BTN_Add);
            this.groupBox2.Controls.Add(this.BTN_Close);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1511, 92);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحكم";
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
            this.MessageShow.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.Screen;
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
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Medical_Analysis_Laboratory.Properties.Resources.Timeline;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(479, 538);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 34;
            this.guna2PictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.COMP_NamePatient);
            this.groupBox1.Controls.Add(this.groupControl1);
            this.groupBox1.Controls.Add(this.RTB_Note);
            this.groupBox1.Controls.Add(this.LBL_RangeValue);
            this.groupBox1.Controls.Add(this.GC_rangeValue);
            this.groupBox1.Controls.Add(this.LBL_Note);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox1.Location = new System.Drawing.Point(497, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 567);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الزيارة";
            // 
            // COMP_NamePatient
            // 
            this.COMP_NamePatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_NamePatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_NamePatient.BackColor = System.Drawing.Color.White;
            this.COMP_NamePatient.DropDownHeight = 170;
            this.COMP_NamePatient.Font = new System.Drawing.Font("Cairo", 13F);
            this.COMP_NamePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.COMP_NamePatient.FormattingEnabled = true;
            this.COMP_NamePatient.IntegralHeight = false;
            this.COMP_NamePatient.Location = new System.Drawing.Point(494, 47);
            this.COMP_NamePatient.MaxDropDownItems = 5;
            this.COMP_NamePatient.Name = "COMP_NamePatient";
            this.COMP_NamePatient.Size = new System.Drawing.Size(365, 50);
            this.COMP_NamePatient.TabIndex = 64;
            this.COMP_NamePatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.COMP_NamePatient_KeyDown);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.dataGridViewTestsVisit);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Location = new System.Drawing.Point(7, 47);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(463, 507);
            this.groupControl1.TabIndex = 63;
            this.groupControl1.Text = "تحاليل الزيارة الحالية";
            // 
            // dataGridViewTestsVisit
            // 
            this.dataGridViewTestsVisit.AllowUserToAddRows = false;
            this.dataGridViewTestsVisit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 10.2F);
            this.dataGridViewTestsVisit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTestsVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestsVisit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTestsVisit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTestsVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTestsVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTestsVisit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTestsVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTestsVisit.Location = new System.Drawing.Point(2, 102);
            this.dataGridViewTestsVisit.Name = "dataGridViewTestsVisit";
            this.dataGridViewTestsVisit.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTestsVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTestsVisit.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cairo", 10.2F);
            this.dataGridViewTestsVisit.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTestsVisit.RowTemplate.Height = 26;
            this.dataGridViewTestsVisit.RowTemplate.ReadOnly = true;
            this.dataGridViewTestsVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTestsVisit.Size = new System.Drawing.Size(459, 403);
            this.dataGridViewTestsVisit.StandardTab = true;
            this.dataGridViewTestsVisit.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(210)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.BTN_AddTestsToVisit);
            this.panel1.Controls.Add(this.BTN_Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 64);
            this.panel1.TabIndex = 11;
            // 
            // BTN_AddTestsToVisit
            // 
            this.BTN_AddTestsToVisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_AddTestsToVisit.BackColor = System.Drawing.Color.Transparent;
            this.BTN_AddTestsToVisit.BorderColor = System.Drawing.Color.White;
            this.BTN_AddTestsToVisit.BorderRadius = 8;
            this.BTN_AddTestsToVisit.BorderThickness = 2;
            this.BTN_AddTestsToVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddTestsToVisit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddTestsToVisit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddTestsToVisit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AddTestsToVisit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AddTestsToVisit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTN_AddTestsToVisit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddTestsToVisit.ForeColor = System.Drawing.Color.White;
            this.BTN_AddTestsToVisit.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_AddTestsToVisit.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_AddTestsToVisit.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_AddTestsToVisit.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_AddTestsToVisit.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_add_50px_1;
            this.BTN_AddTestsToVisit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddTestsToVisit.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_AddTestsToVisit.Location = new System.Drawing.Point(233, 6);
            this.BTN_AddTestsToVisit.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_AddTestsToVisit.Name = "BTN_AddTestsToVisit";
            this.BTN_AddTestsToVisit.ShadowDecoration.BorderRadius = 20;
            this.BTN_AddTestsToVisit.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_AddTestsToVisit.ShadowDecoration.Depth = 100;
            this.BTN_AddTestsToVisit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_AddTestsToVisit.Size = new System.Drawing.Size(208, 53);
            this.BTN_AddTestsToVisit.TabIndex = 10;
            this.BTN_AddTestsToVisit.Tag = "";
            this.BTN_AddTestsToVisit.Text = "اضافة";
            this.BTN_AddTestsToVisit.Click += new System.EventHandler(this.BTN_AddTestsToVisit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Delete.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Delete.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete.BorderRadius = 8;
            this.BTN_Delete.BorderThickness = 2;
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Delete.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Delete.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.FillColor = System.Drawing.Color.Brown;
            this.BTN_Delete.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTN_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Delete.Location = new System.Drawing.Point(16, 6);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete.ShadowDecoration.Depth = 100;
            this.BTN_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete.Size = new System.Drawing.Size(208, 53);
            this.BTN_Delete.TabIndex = 10;
            this.BTN_Delete.Tag = "";
            this.BTN_Delete.Text = "حذف";
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(865, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 37);
            this.label16.TabIndex = 65;
            this.label16.Text = "*";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(865, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 37);
            this.label3.TabIndex = 66;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_AddVisit
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_schedule_60px;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddVisit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة زيارة";
            ((System.ComponentModel.ISupportInitialize)(this.GC_rangeValue)).EndInit();
            this.GC_rangeValue.ResumeLayout(false);
            this.GC_rangeValue.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestsVisit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RTB_Note;
        private System.Windows.Forms.Label LBL_RangeValue;
        private DevExpress.XtraEditors.GroupControl GC_rangeValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TX_remainingNumber;
        private System.Windows.Forms.TextBox TX_totalTestsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_Note;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button BTN_AddClose;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private System.Windows.Forms.GroupBox groupBox2;
        public Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TX_testsNumber;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Guna.UI2.WinForms.Guna2Button BTN_AddTestsToVisit;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox COMP_NamePatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_totalTestsNumber;
        private System.Windows.Forms.Label LBL_remainingNumber;
        private System.Windows.Forms.DataGridView dataGridViewTestsVisit;
    }
}