using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Task_Manager.Bul.Class;


namespace Task_Manager.Dao
{
    public class DataProvider
    {
        private static DataProvider instance;

        private readonly string ConnectString = @"Server=tcp:daomtthuan.database.windows.net,1433;Initial Catalog=daomtthuan_TaskManager;Persist Security Info=False;User ID=daomtthuan;Password=NegaTNP123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        private DataProvider() { }

        private void ConnectionIsError()
        {
            XtraMessageBoxArgs argsLoginMessageBox = new XtraMessageBoxArgs(null, null, "Lỗi kết nối cơ sở dữ liệu", "Thông báo", new DialogResult[] { DialogResult.OK });
            argsLoginMessageBox.Showing += Global.MessageBoxOK;
            XtraMessageBox.Show(argsLoginMessageBox);
            Environment.Exit(0);
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParameter)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch
                {
                    ConnectionIsError();
                }
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParameter)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                }
                catch
                {
                    ConnectionIsError();
                }
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParameter)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                }
                catch
                {
                    ConnectionIsError();
                }
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return data;
        }

        public static DataProvider Instance { get => instance ?? new DataProvider(); private set => instance = value; }
    }
}
