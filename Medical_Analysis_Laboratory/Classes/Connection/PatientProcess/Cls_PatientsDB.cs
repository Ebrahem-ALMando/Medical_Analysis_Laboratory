using System;
using System.Data;
using System.Data.SqlClient;

namespace Medical_Analysis_Laboratory.Classes.Connection.PatientProcess
{
    internal class Cls_PatientsDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Patients Forms

        //    <=============== Method ======================>

        //==> 1 getData To Patients
        #region Function
        public DataTable getDataPatients()
        {
            DataTable dataPatients = new DataTable();
            try
            {
                connection.open();
                dataPatients = connection.Read_Data("getDataPatients", null);
                connection.cloes();
                return dataPatients;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataPatients;
            }

        }
        //==> 2 getData To Patients By User
        public DataTable getDataPatientsByUser(int idUser)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idUser", SqlDbType.Int);
                param[0].Value = idUser;

                dataTable = connection.Read_Data("getDataPatientsByUser", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        //==> 3 Insert To Patients 
        public void insertPatients(int idUser, string name, string age, string gender, string address, string phone, string note, DateTime dateAdd)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@idUser", SqlDbType.Int);
                param[0].Value = idUser;
                param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                param[1].Value = name;
                param[2] = new SqlParameter("@age", SqlDbType.NVarChar, 10);
                param[2].Value = age;
                param[3] = new SqlParameter("@gender", SqlDbType.NVarChar, 5);
                param[3].Value = gender;
                param[4] = new SqlParameter("@address", SqlDbType.NVarChar, 200);
                param[4].Value = address;
                param[5] = new SqlParameter("@phone", SqlDbType.NVarChar, 30);
                param[5].Value = phone;
                param[6] = new SqlParameter("@note", SqlDbType.NVarChar, 200);
                param[6].Value = note;
                param[7] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[7].Value = dateAdd;

                connection.process("insertPatients", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Update To Patient
        public void updatePatient(int id, string name, string age, string gender, string address, string phone, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                param[1].Value = name;
                param[2] = new SqlParameter("@age", SqlDbType.NVarChar, 10);
                param[2].Value = age;
                param[3] = new SqlParameter("@gender", SqlDbType.NVarChar, 5);
                param[3].Value = gender;
                param[4] = new SqlParameter("@address", SqlDbType.NVarChar, 200);
                param[4].Value = address;
                param[5] = new SqlParameter("@phone", SqlDbType.NVarChar, 30);
                param[5].Value = phone;
                param[6] = new SqlParameter("@note", SqlDbType.NVarChar, 200);
                param[6].Value = note;
                connection.process("updatePatients", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 Delete To Patient
        public void deletePatient(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deletePatient", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 6 getData To Patients To Visits
        public DataTable getDataPatientsToVisits()
        {
            DataTable dataPatients = new DataTable();
            try
            {
                connection.open();
                dataPatients = connection.Read_Data("getDataPatientsToVisits", null);
                connection.cloes();
                return dataPatients;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataPatients;
            }

        }
        //==> 7 Get Check Is Delete
        public DataTable getDataIsCanDeletePatient(int id)
        {
            DataTable dataPatient = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataPatient = connection.Read_Data("getDataIsCanDeletePatient", param);
                connection.cloes();
                return dataPatient;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataPatient;
            }
        }
        #endregion

    }


}

