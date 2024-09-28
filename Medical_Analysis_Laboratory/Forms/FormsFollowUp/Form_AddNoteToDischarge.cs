using System;

namespace Medical_Analysis_Laboratory.Forms.FormsFollowUp
{
    public partial class Form_AddNoteToTest : DevExpress.XtraEditors.XtraForm
    {
        private string _note;
       
        public Form_AddNoteToTest()
        {
            InitializeComponent();
            RTX_Note.Select();
        }
        public string getNote()
        {
            return _note;
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            _note = "";
            this.Close();
        }

        private void BTN_Add_Close_Click(object sender, EventArgs e)
        {
            _note = RTX_Note.Text;
            this.Close();
        }
    }
}