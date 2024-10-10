using System;

namespace Medical_Analysis_Laboratory.Forms.FormsAction
{
    public partial class FormDelete : DevExpress.XtraEditors.XtraForm
    {
        private int resultDelete = -1;

        public FormDelete()
        {
            InitializeComponent();
        }
        public void configFormTest(string nameNode)
        {
            LBL_Result.Text = nameNode;
        }
        public int getResult()
        {
            return resultDelete;
        }
        public void setResult(int result)
        {
            this.resultDelete = result;
            this.Close();
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            setResult(1);
        }

        private void BTN_Delete_DelNodes_Click(object sender, EventArgs e)
        {
            setResult(2);
        }
    }
}