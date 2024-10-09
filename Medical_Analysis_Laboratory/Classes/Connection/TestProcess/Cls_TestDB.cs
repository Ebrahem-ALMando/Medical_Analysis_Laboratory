using System;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors.Filtering.Templates;

namespace Medical_Analysis_Laboratory.Classes.Connection.TestProcess
{
    internal class Cls_TestDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Test Forms

        //    <=============== Method ======================>

        //==> 1 get Data To Test
        public DataTable getDataTest()
        {
            DataTable dataTest = new DataTable();
            try
            {
                connection.open();
                dataTest = connection.Read_Data("getDataTest", null);
                connection.cloes();
                return dataTest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataTest;
            }

        }
        //==> 2  Insert Test
        public void insertTest(int? idParent, int idUser, string name, bool isCategory, float? rangeBegin,
                              float? rangeEnd, string diagnosisValueLessThanBegin, string diagnosisValueBetweenRange,
                              string diagnosisValueBiggerThanEnd, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@idParent", SqlDbType.Int);
                param[0].Value = (object)idParent ?? DBNull.Value;

                param[1] = new SqlParameter("@idUser", SqlDbType.Int);
                param[1].Value = idUser;

                param[2] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[2].Value = name;

                param[3] = new SqlParameter("@isCategory", SqlDbType.Bit);
                param[3].Value = isCategory;

                param[4] = new SqlParameter("@rangeBegin", SqlDbType.Float);
                param[4].Value = (object)rangeBegin ?? DBNull.Value;

                param[5] = new SqlParameter("@rangeEnd", SqlDbType.Float);
                param[5].Value = (object)rangeEnd ?? DBNull.Value;

                param[6] = new SqlParameter("@diagnosisValueLessThanBegin", SqlDbType.Text);
                param[6].Value = (object)diagnosisValueLessThanBegin ?? DBNull.Value;

                param[7] = new SqlParameter("@diagnosisValueBetweenRange", SqlDbType.Text);
                param[7].Value = (object)diagnosisValueBetweenRange ?? DBNull.Value;

                param[8] = new SqlParameter("@diagnosisValueBiggerThanEnd", SqlDbType.Text);
                param[8].Value = (object)diagnosisValueBiggerThanEnd ?? DBNull.Value;

                param[9] = new SqlParameter("@note", SqlDbType.Text);
                param[9].Value = note ?? string.Empty;

                param[10] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[10].Value = DateTime.Now;

                connection.process("insertTest", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //==> 3 update To Test
        public void updateTest(int id, string name, string note)
        {
            try
            {
                connection.open();

                SqlParameter[] parameters = new SqlParameter[3];

                parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                parameters[0].Value = id;

                parameters[1] = new SqlParameter("@nameTest", SqlDbType.NVarChar, 50);
                parameters[1].Value = name;

                parameters[2] = new SqlParameter("@note", SqlDbType.Text);
                parameters[2].Value = note;
                
                connection.process("updateTest", parameters);
                connection.cloes();


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        //==> 4 Delete Test
        public void deleteTest(int id,string proc)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process(proc, param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 get Data Test To Visit
        public DataTable getDataTestToVisit()
        {
            DataTable dataTest = new DataTable();
            try
            {
                connection.open();
                dataTest = connection.Read_Data("getDataTestToVisit", null);
                connection.cloes();
                return dataTest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataTest;
            }

        }

        //==> 6 get Data Patient Test By Visit
        public DataTable getDataPatientTestsByVisit(int id)
        {
            DataTable dataTest = new DataTable();
            try
            {
                connection.open();
                SqlParameter []param=new SqlParameter[1];
                param[0]= new SqlParameter("@idVisit", SqlDbType.Int);
                param[0].Value = id;
                dataTest = connection.Read_Data("getDataPatientTestsByVisit", param);
                connection.cloes();
                return dataTest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataTest;
            }

        }

    }
}
