using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
namespace QLHSC3.Common
{
    class DataProvider
    {
        #region ConnectionString
        public static String ConnectionString
        {
            get
            {
                return ReadConnectionString("ConnectionString.xml");
            }
        }
        public static String ReadConnectionString(String file)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement root = doc.DocumentElement;
                String connectionString = root.InnerText;
                return connectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region ExcuteQuery : Get
        public static DataTable executeQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    adapter.Fill(dt);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally 
                {
                    con.Close();
                } 
            }
            catch (Exception ex)
            {  
                throw ex;
            } 
            return dt;
        }
        #endregion 
        #region EcuteNonquery : Insert, Delete, Update 
        public static int executeNonQuery(string sql)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                try
                {
                    SqlCommand command = con.CreateCommand();
                    command.CommandText = sql;
                    n = command.ExecuteNonQuery(); 
                }
                catch (SqlException ex)
                { 
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            } 
            return n;
        }
        #endregion
        #region ExcuteQuery: Store Procedure
        public static DataTable executeStoreProcedureQuery(string nameProc, params SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand(nameProc, con);
                    command.CommandType = CommandType.StoredProcedure; 
                    if (para != null)
                    {
                        foreach (SqlParameter p in para)
                            command.Parameters.Add(p);
                    } 
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            return dt;
        }
        #endregion 
        #region ExcuteNonQuery : Store Procedure
        public static int executeStoreProcedureNonQuery(string nameProc, params SqlParameter[] para)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand(nameProc, con);
                    command.CommandType = CommandType.StoredProcedure;
                    if (para != null)
                    {
                        foreach (SqlParameter p in para)
                            command.Parameters.Add(p);
                    }
                    n = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                } 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return n;
        }
        #endregion

        #region ExecuteScalar : Store Procedure
        public static int ExecuteScalarProcedureNonQuery(string nameProc, params SqlParameter[] para)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand(nameProc, con);
                    command.CommandType = CommandType.StoredProcedure;
                    if (para != null)
                    {
                        foreach (SqlParameter p in para)
                            command.Parameters.Add(p);
                    }
                    n = Convert.ToInt16(command.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return n;
        }
        #endregion

        
    }
}
