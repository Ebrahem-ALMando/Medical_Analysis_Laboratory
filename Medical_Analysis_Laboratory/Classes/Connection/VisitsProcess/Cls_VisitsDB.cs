﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Analysis_Laboratory.Classes.Connection.VisitsProcess
{
    internal class Cls_VisitsDB
    {

        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Visits Forms And Gui

        //    <=============== Method ======================>

        //==> 1 getData To Visits
        public DataTable getDataVisits()
        {
            DataTable dataVisits = new DataTable();
            try
            {
                connection.open();
                dataVisits = connection.Read_Data("getDataVisits", null);
                connection.cloes();
                return dataVisits;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataVisits;
            }

        }
        //==> 2 get Data Id To Current Visits
        public DataTable getDataIdCurrentVisit()
        {
            DataTable dataVisits = new DataTable();
            try
            {
                connection.open();
                dataVisits = connection.Read_Data("getDataIdCurrentVisit", null);
                connection.cloes();
                return dataVisits;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataVisits;
            }
        }
        //==> 3 Insert To Visit 
        public void insertVisit(int idUser, int idPatient,int testsNumber, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@user_id", SqlDbType.Int);
                param[0].Value = idUser;
                param[1] = new SqlParameter("@patient_id", SqlDbType.Int);
                param[1].Value = idPatient;
                param[2] = new SqlParameter("@tests_number", SqlDbType.Int);
                param[2].Value = testsNumber;
                param[3] = new SqlParameter("@note", SqlDbType.Text);
                param[3].Value = note;
                param[4] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[4].Value = DateTime.Now;
                connection.process("insertVisit", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Update To Patient
        /*  public void updatePatient(int id, string name, string age, string gender, string address, string phone, string note)
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
          }*/
        //==> 5 Delete To Visits
        public void deleteVisit(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idVisit", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteVisit", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 1 get Data Visit By User
        public DataTable getDataVisitByUser(int idUser)
        {
            DataTable dataVisits = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idUser", SqlDbType.Int);
                param[0].Value = idUser;
                connection.open();
                dataVisits = connection.Read_Data("getDataVisitByUser", param);
                connection.cloes();
                return dataVisits;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataVisits;
            }

        }
    }
}
