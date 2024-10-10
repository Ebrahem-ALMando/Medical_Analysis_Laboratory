namespace Medical_Analysis_Laboratory.Forms.FormsAction
{
    partial class FormDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Result = new System.Windows.Forms.Label();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete_DelNodes = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete = new Guna.UI2.WinForms.Guna2Button();
            this._animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(541, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "تنبيه هـــام";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_box_important_50px;
            this.pictureBox1.Location = new System.Drawing.Point(656, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "هذه العقدة";
            // 
            // LBL_Result
            // 
            this.LBL_Result.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Result.ForeColor = System.Drawing.Color.Red;
            this.LBL_Result.Location = new System.Drawing.Point(140, 65);
            this.LBL_Result.Name = "LBL_Result";
            this.LBL_Result.Size = new System.Drawing.Size(339, 37);
            this.LBL_Result.TabIndex = 6;
            this.LBL_Result.Text = "\" تحليل \"";
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
            this.BTN_Close.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_cancel_32px_2;
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Close.Location = new System.Drawing.Point(397, 235);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(203, 52);
            this.BTN_Close.TabIndex = 10;
            this.BTN_Close.Tag = "";
            this.BTN_Close.Text = "اغلاق";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Delete_DelNodes
            // 
            this.BTN_Delete_DelNodes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Delete_DelNodes.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Delete_DelNodes.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete_DelNodes.BorderRadius = 8;
            this.BTN_Delete_DelNodes.BorderThickness = 2;
            this.BTN_Delete_DelNodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete_DelNodes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete_DelNodes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete_DelNodes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Delete_DelNodes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Delete_DelNodes.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Delete_DelNodes.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete_DelNodes.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete_DelNodes.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete_DelNodes.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Delete_DelNodes.HoverState.FillColor = System.Drawing.Color.Brown;
            this.BTN_Delete_DelNodes.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete_DelNodes.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTN_Delete_DelNodes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete_DelNodes.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Delete_DelNodes.Location = new System.Drawing.Point(140, 161);
            this.BTN_Delete_DelNodes.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete_DelNodes.Name = "BTN_Delete_DelNodes";
            this.BTN_Delete_DelNodes.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete_DelNodes.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete_DelNodes.ShadowDecoration.Depth = 100;
            this.BTN_Delete_DelNodes.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete_DelNodes.Size = new System.Drawing.Size(460, 52);
            this.BTN_Delete_DelNodes.TabIndex = 12;
            this.BTN_Delete_DelNodes.Tag = "";
            this.BTN_Delete_DelNodes.Text = "حذف العقدة مع الابناء";
            this.BTN_Delete_DelNodes.Click += new System.EventHandler(this.BTN_Delete_DelNodes_Click);
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
            this.BTN_Delete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Delete.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Delete.ForeColor = System.Drawing.Color.Red;
            this.BTN_Delete.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BTN_Delete.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.BTN_Delete.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Delete.HoverState.ForeColor = System.Drawing.Color.Red;
            this.BTN_Delete.Image = global::Medical_Analysis_Laboratory.Properties.Resources.icons8_Delete_Trash_60px_1;
            this.BTN_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Delete.Location = new System.Drawing.Point(140, 235);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete.ShadowDecoration.Depth = 100;
            this.BTN_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete.Size = new System.Drawing.Size(203, 52);
            this.BTN_Delete.TabIndex = 13;
            this.BTN_Delete.Tag = "";
            this.BTN_Delete.Text = "حذف";
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // _animateWindow
            // 
            this._animateWindow.TargetForm = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "تمــــلــــك ابـــنـــاء هــــل تريـــد حذفـــها بالتـــأكـــــيد ؟";
            // 
            // FormDelete
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Delete_DelNodes);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.LBL_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "FormDelete";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeleteFollowUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Result;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete_DelNodes;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animateWindow;
        private System.Windows.Forms.Label label3;
    }
}