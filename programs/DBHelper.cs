using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programs
{
   public class DBHelper
    {
        private readonly string connString = "Data Source=101.200.45.217;Initial Catalog=dustmonitor_sh;Persist Security Info=True;User ID=root;Password=c9ra@86hhd; characterset=utf8;sslmode=none";
        private MySqlConnection mySqlConnection = null;
        private MySqlCommand mySqlCommand = null;
        protected MySqlDataReader mySqlDataReader = null;

        private MySqlDataAdapter mySqlDataAdapter = null;
        private DataSet dataSet = null;

        private int i = 0;

        private MySqlConnection ExecuteMySqlConnection()
        {
            try
            {
                this.mySqlConnection = new MySqlConnection(this.connString);
                this.mySqlConnection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return this.mySqlConnection;
        }

        private MySqlCommand ExecuteMySqlCommand(string sql, CommandType commandType, MySqlParameter[] mySqlParameter)
        {
            try
            {
                this.mySqlConnection = this.ExecuteMySqlConnection();
                this.mySqlCommand = new MySqlCommand(sql, this.mySqlConnection);
                if (mySqlParameter != null && mySqlParameter.Length > 0)
                {
                    this.mySqlCommand.Parameters.AddRange(mySqlParameter);
                }
                this.mySqlCommand.CommandType = commandType;
            }
            catch (Exception)
            {

                throw;
            }
            return this.mySqlCommand;
        }

        protected MySqlDataReader ExecuteMySqlDataReader(string sql, CommandType commandType, MySqlParameter[] mySqlParameter)
        {
            try
            {
                this.mySqlCommand = this.ExecuteMySqlCommand(sql, commandType, mySqlParameter);
                this.mySqlDataReader = this.mySqlCommand.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            return this.mySqlDataReader;
        }

        protected DataSet ExecuteDataSet(string sql, CommandType commandType, MySqlParameter[] mySqlParameter)
        {
            this.dataSet = new DataSet();
            try
            {
                this.mySqlCommand = this.ExecuteMySqlCommand(sql, commandType, mySqlParameter);
                this.mySqlDataAdapter = new MySqlDataAdapter(this.mySqlCommand);
                this.mySqlDataAdapter.Fill(dataSet);
            }
            catch (Exception)
            {

                throw;
            }
            return this.dataSet;
        }

        protected int ExecuteScalar(string sql, CommandType commandType, MySqlParameter[] mySqlParameter)
        {
            try
            {
                this.mySqlCommand = this.ExecuteMySqlCommand(sql, commandType, mySqlParameter);
                this.i = int.Parse(this.mySqlCommand.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                throw;
            }
            return this.i;
        }

        protected int ExecuteNonQuery(string sql, CommandType commandType, MySqlParameter[] mySqlParameter)
        {
            try
            {
                this.mySqlCommand = this.ExecuteMySqlCommand(sql, commandType, mySqlParameter);
                this.i = this.mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return this.i;
        }

        protected void CloseConnection(MySqlConnection mySqlConnection)
        {
            try
            {
                if (mySqlConnection != null)
                {
                    mySqlConnection = null;
                    mySqlConnection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void CloseDataReader(MySqlDataReader mySqlDataReader)
        {
            try
            {
                if (mySqlDataReader != null)
                {
                    mySqlDataReader = null;
                    mySqlDataReader.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
