﻿using System.Data.SqlClient;
using LoginModel;

namespace LoginModel
{
    public class DataAccess
    {
        private string connectionString = "Data Source=DESKTOP-5NPFBF9,Database=Prueba,Integrated Security=True";

        #region Singleton
        private static DataAccess _instance;
        private static object LockClass = new object();

        private DataAccess() { }

        public static DataAccess Instance
        {
            get
            {
                lock (LockClass)
                {
                    if (_instance == null)
                    {
                        _instance = new DataAccess();
                    }
                    return _instance;
                }
            }
        }



        #endregion




        private SqlCommand SelectCommand(string ProcedureName, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(ProcedureName, connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }



        public int RegisterNewUser(Dictionary<string, object> Parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = SelectCommand(StoredProcedures.InsNewUser, connection);

                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = Parameters["@email"];
                cmd.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar).Value = Parameters["@Password"];



                int result = (int)cmd.ExecuteScalar();

                return result;

            }
        }



    }
}