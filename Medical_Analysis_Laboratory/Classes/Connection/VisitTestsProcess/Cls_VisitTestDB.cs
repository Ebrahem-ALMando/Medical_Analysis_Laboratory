using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Analysis_Laboratory.Classes.Connection.VisitTestsProcess
{
    internal class Cls_VisitTestDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Visit Test Forms And Gui

        //    <=============== Method ======================>

        //==> 1 getData To Visit Test


        //==> 2 Insert To Visit Test 
        public void insertTestToVisit(int idPatientVisit,int idTest,int idUser, float testValue, string testDiagnosi)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@patient_visit_id", SqlDbType.Int);
                param[0].Value = idPatientVisit;
                param[1] = new SqlParameter("@test_id", SqlDbType.Int);
                param[1].Value = idTest;
                param[2] = new SqlParameter("@user_id", SqlDbType.Int);
                param[2].Value = idUser;
                param[3] = new SqlParameter("@test_val", SqlDbType.Float);
                param[3].Value = testValue;
                param[4] = new SqlParameter("@test_diagnosis", SqlDbType.Text);
                param[4].Value = testDiagnosi;
                param[5] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[5].Value = DateTime.Now;
                connection.process("insertTestToVisit", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
