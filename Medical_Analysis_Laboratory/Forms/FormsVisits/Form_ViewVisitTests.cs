using DevExpress.XtraEditors;
using Medical_Analysis_Laboratory.Classes.Connection.TestProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Analysis_Laboratory.Forms.FormsVisits
{
    public partial class Form_ViewVisitTests : DevExpress.XtraEditors.XtraForm
    {
        private int id = 0;
        private Form formMain;
        private Form formBackground;
        Cls_TestDB testDB =new Cls_TestDB();
        public Form_ViewVisitTests()
        {
            InitializeComponent();
        }
        public Form_ViewVisitTests(object []data)
        {
            InitializeComponent();
            loadInitConfig(data);


        }
        public void loadInitConfig(object []data)
        {
            this.formMain = (Form)data[0];
            this.formBackground = (Form)data[1];
            this.id = (int)data[2];
            LBL_NamePatient.Text = (string)data[3];
            LBL_TestCount.Text = $"“{(string)data[4]}”";
            getData();
        }

        private void getData()=>
            dataGridViewTest.DataSource = testDB.getDataPatientTestsByVisit(id);
       
    }
}