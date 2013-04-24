using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace EstateManagement.pub
{
    public class DataBase : IDisposable
    {
        public SqlConnection objConnection;
        public SqlCommand objCommand;
        public static string connStr = "Data Source=vmwinxp\\SQLEXPRESS;Initial Catalog=CJWYGL;User ID=cj;Password=cj";
        public DataBase()
            : this("Data Source=vmwinxp\\SQLEXPRESS;Initial Catalog=CJWYGL;User ID=cj;Password=cj")
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        public DataBase(string connectionString)
        {
            if (connectionString == null || connectionString == "")
            {
                //connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=CJWYGL;User ID=cj;Password=cj";
                connectionString = "Data Source=vmwinxp\\SQLEXPRESS;Initial Catalog=CJWYGL;User ID=cj;Password=cj";
            }
            objConnection = new SqlConnection(connectionString);
            objCommand = objConnection.CreateCommand();
            try
            {
                objConnection.Open();
            }
            catch (Exception ex)
            {
            }
        }
        public void AddParameter(string name, object value)
        {
            objCommand.Parameters.AddWithValue(name, value);
        }
        public void AddParameter(string name, object value, SqlDbType type)
        {
            objCommand.Parameters.Add(name, type);
            objCommand.Parameters[name].Value = value;
        }
        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, CommandType.Text);
        }
        public int ExecuteNonQuery(string query, CommandType commandtype)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandtype;
            int i = -1;
            try
            {
                if (ConnectionState.Closed == objConnection.State)
                {
                    objConnection.Open();
                }
                i = objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                objCommand.Parameters.Clear();
            }
            return i;
        }
        public DataTable ExecuteDataTable(string query, CommandType commandtype)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandtype;
            SqlDataAdapter adapter = new SqlDataAdapter(objCommand);

            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                ds.Tables.Add(new DataTable());
            }
            finally
            {
                objCommand.Parameters.Clear();
            }
            return ds.Tables[0];
        }
        public DataTable ExecuteDataTable(string query)
        {
            return ExecuteDataTable(query, CommandType.Text);
        }
        public void Dispose()
        {
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();
        }

    }
}
