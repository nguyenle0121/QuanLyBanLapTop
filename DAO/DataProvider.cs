using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=dbQuanLyBanLapTop;Integrated Security=True");

        public DataProvider()
        {

        }

        private static SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public static DataTable ExecuteSelectQuery(string query, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dtbKetQua= new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(parameter);
                adapter.SelectCommand = cmd;
                adapter.Fill(dtbKetQua);
                conn.Close();
            }
            catch (SqlException e)
            {
                return null;
            }
            return dtbKetQua;
        }

        public static int ExecuteInsertQuery(string query, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(parameter);
                adapter.InsertCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }

        public static int ExecuteUpdateQuery(string query, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(parameter);
                adapter.UpdateCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }

        public static int ExecuteDeleteQuery(string query, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(parameter);
                adapter.DeleteCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }
    }
}