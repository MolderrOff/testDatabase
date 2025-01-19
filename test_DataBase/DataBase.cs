using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using for_video;
using System.Windows.Forms;
using System.Data;



namespace for_video
{
    //было "Data Source=MOLDERR-PC\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"
    internal class DataBase
    {
        
        SqlConnection sqlConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=testdb1;Trusted_Connection=True;");

        public bool CheckDB()
        {
            //SqlConnection myConnection = new SqlConnection(sqlConnection);
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void createMyDataBase()
        {
            //DataBase database = new DataBase();
            ////SqlConnection sqlConnection = new SqlConnection();
            ////sqlConnection.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=testdb1;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Trusted_Connection=True;");
            SqlConnection sqlConnection2 = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=testdb1;Trusted_Connection=True;");


            string str = "CREATE TABLE dbo.register(id_user integer null, login_user nvarchar(2048) null, password_user nvarchar(2048) null);";


            SqlCommand myCommand = new SqlCommand("CREATE DATABASE testdb1", sqlConnection); //IF NOT EXISTS
            SqlCommand myCommand2 = new SqlCommand(str, sqlConnection2);

            sqlConnection.Open();
            myCommand.ExecuteNonQuery();

            MessageBox.Show("База данных СОЗДАНА");
            sqlConnection.Close();
            sqlConnection2.Open();
            DataTable register = new DataTable();

            SqlDataAdapter adapter2 = new SqlDataAdapter(myCommand2);
            adapter2.Fill(register);


            //myCommand2.ExecuteNonQuery();
            sqlConnection2.Close();

        }
        public void openConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
