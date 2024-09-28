﻿
namespace Medical_Analysis_Laboratory.Gui.GuiHome
{
    partial class Patients_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients_UserControl));
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TX_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.COMP_FilterData = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Export = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Update = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.dataGridViewPatients.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPatients.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPatients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPatients.RowTemplate.Height = 26;
            this.dataGridViewPatients.RowTemplate.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1474, 478);
            this.dataGridViewPatients.StandardTab = true;
            this.dataGridViewPatients.TabIndex = 18;
            this.dataGridViewPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellClick);
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellDoubleClick);
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_SelectionChanged);
            this.dataGridViewPatients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPatients_KeyDown);
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
            this.MessageShow.ErrorOptions.ActionBorderRadius = 5;
            this.MessageShow.ErrorOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.ErrorOptions.BorderColor = System.Drawing.Color.Red;
            this.MessageShow.ErrorOptions.CloseIconColor = System.Drawing.Color.Red;
            this.MessageShow.ErrorOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.ErrorOptions.ForeColor = System.Drawing.Color.Red;
            this.MessageShow.ErrorOptions.IconLeftMargin = 12;
            this.MessageShow.FadeCloseIcon = false;
            this.MessageShow.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.Screen;
            this.MessageShow.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.InformationOptions.ActionBorderRadius = 1;
            this.MessageShow.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MessageShow.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.InformationOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.MessageShow.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.MessageShow.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MessageShow.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.MessageShow.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.MessageShow.InformationOptions.IconLeftMargin = 12;
            this.MessageShow.Margin = 10;
            this.MessageShow.MaximumSize = new System.Drawing.Size(0, 0);
            this.MessageShow.MaximumViews = 7;
            this.MessageShow.MessageRightMargin = 15;
            this.MessageShow.MessageTopMargin = 0;
            this.MessageShow.MinimumSize = new System.Drawing.Size(300, 0);
            this.MessageShow.ShowBorders = true;
            this.MessageShow.ShowCloseIcon = true;
            this.MessageShow.ShowIcon = true;
            this.MessageShow.ShowShadows = true;
            this.MessageShow.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.SuccessOptions.ActionBorderRadius = 1;
            this.MessageShow.SuccessOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.MessageShow.SuccessOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
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
            this.MessageShow.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.MessageShow.WarningOptions.IconLeftMargin = 12;
            this.MessageShow.ZoomCloseIcon = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TX_Search);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.COMP_FilterData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 73);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_filter_and_sort_40px;
            this.label1.Location = new System.Drawing.Point(431, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "        ";
            // 
            // TX_Search
            // 
            this.TX_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.TX_Search.BorderRadius = 8;
            this.TX_Search.BorderThickness = 3;
            this.TX_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TX_Search.DefaultText = "";
            this.TX_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TX_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TX_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TX_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TX_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TX_Search.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Search.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TX_Search.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TX_Search.IconLeft = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_search_60px;
            this.TX_Search.IconLeftSize = new System.Drawing.Size(40, 40);
            this.TX_Search.Location = new System.Drawing.Point(52, 9);
            this.TX_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TX_Search.Name = "TX_Search";
            this.TX_Search.Padding = new System.Windows.Forms.Padding(10, 2, 20, 2);
            this.TX_Search.PasswordChar = '\0';
            this.TX_Search.PlaceholderText = "";
            this.TX_Search.SelectedText = "";
            this.TX_Search.Size = new System.Drawing.Size(331, 54);
            this.TX_Search.TabIndex = 4;
            this.TX_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Search.TextChanged += new System.EventHandler(this.TX_Search_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_nurse_call_60px_1;
            this.label9.Location = new System.Drawing.Point(1389, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 62);
            this.label9.TabIndex = 3;
            this.label9.Text = "        ";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cairo", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Snow;
            this.label15.Location = new System.Drawing.Point(1129, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(269, 62);
            this.label15.TabIndex = 2;
            this.label15.Text = "الــــــمـــــرضـــــى";
            // 
            // COMP_FilterData
            // 
            this.COMP_FilterData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_FilterData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_FilterData.BackColor = System.Drawing.Color.White;
            this.COMP_FilterData.DropDownHeight = 170;
            this.COMP_FilterData.Font = new System.Drawing.Font("Cairo", 13F);
            this.COMP_FilterData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.COMP_FilterData.FormattingEnabled = true;
            this.COMP_FilterData.IntegralHeight = false;
            this.COMP_FilterData.Location = new System.Drawing.Point(412, 14);
            this.COMP_FilterData.MaxDropDownItems = 5;
            this.COMP_FilterData.Name = "COMP_FilterData";
            this.COMP_FilterData.Size = new System.Drawing.Size(322, 50);
            this.COMP_FilterData.TabIndex = 27;
            this.COMP_FilterData.SelectedIndexChanged += new System.EventHandler(this.COMP_FilterData_SelectedIndexChanged);
            this.COMP_FilterData.TextChanged += new System.EventHandler(this.COMP_FilterData_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.BTN_Export);
            this.panel1.Controls.Add(this.BTN_Update);
            this.panel1.Controls.Add(this.BTN_Delete);
            this.panel1.Controls.Add(this.BTN_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 73);
            this.panel1.TabIndex = 20;
            // 
            // BTN_Export
            // 
            this.BTN_Export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Export.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Export.BorderColor = System.Drawing.Color.White;
            this.BTN_Export.BorderRadius = 8;
            this.BTN_Export.BorderThickness = 2;
            this.BTN_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Export.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Export.ForeColor = System.Drawing.Color.White;
            this.BTN_Export.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Export.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Export.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Export.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Export.HoverState.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_upload_60px;
            this.BTN_Export.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_upload_50px_1;
            this.BTN_Export.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Export.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Export.Location = new System.Drawing.Point(291, 11);
            this.BTN_Export.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Export.Name = "BTN_Export";
            this.BTN_Export.ShadowDecoration.BorderRadius = 20;
            this.BTN_Export.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Export.ShadowDecoration.Depth = 100;
            this.BTN_Export.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Export.Size = new System.Drawing.Size(191, 53);
            this.BTN_Export.TabIndex = 22;
            this.BTN_Export.Tag = "";
            this.BTN_Export.Text = "تصد ير ";
            this.BTN_Export.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Export.Click += new System.EventHandler(this.BTN_Export_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Update.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Update.BorderColor = System.Drawing.Color.White;
            this.BTN_Update.BorderRadius = 8;
            this.BTN_Update.BorderThickness = 2;
            this.BTN_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Update.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Update.ForeColor = System.Drawing.Color.White;
            this.BTN_Update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Update.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Update.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Update.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Update.HoverState.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_edit_60px_1;
            this.BTN_Update.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_edit_50px;
            this.BTN_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Update.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Update.Location = new System.Drawing.Point(765, 11);
            this.BTN_Update.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.ShadowDecoration.BorderRadius = 20;
            this.BTN_Update.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Update.ShadowDecoration.Depth = 100;
            this.BTN_Update.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Update.Size = new System.Drawing.Size(193, 53);
            this.BTN_Update.TabIndex = 21;
            this.BTN_Update.Tag = "";
            this.BTN_Update.Text = "تعد يل";
            this.BTN_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
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
            this.BTN_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Delete.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Delete.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Delete.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Delete.HoverState.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_Delete_Trash_60px_1;
            this.BTN_Delete.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTN_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Delete.Location = new System.Drawing.Point(528, 11);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete.ShadowDecoration.Depth = 100;
            this.BTN_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete.Size = new System.Drawing.Size(191, 53);
            this.BTN_Delete.TabIndex = 20;
            this.BTN_Delete.Tag = "";
            this.BTN_Delete.Text = "حذف";
            this.BTN_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
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
            this.BTN_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Add.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Add.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.BTN_Add.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Add.HoverState.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_add_60px;
            this.BTN_Add.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_add_50px_1;
            this.BTN_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Add.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Add.Location = new System.Drawing.Point(1000, 11);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.ShadowDecoration.BorderRadius = 20;
            this.BTN_Add.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Add.ShadowDecoration.Depth = 100;
            this.BTN_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Add.Size = new System.Drawing.Size(193, 53);
            this.BTN_Add.TabIndex = 16;
            this.BTN_Add.Tag = "";
            this.BTN_Add.Text = "اضافة";
            this.BTN_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // Patients_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Patients_UserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1474, 624);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TX_Search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BTN_Export;
        private Guna.UI2.WinForms.Guna2Button BTN_Update;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        private System.Windows.Forms.ComboBox COMP_FilterData;
    }
}
