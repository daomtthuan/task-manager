using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Task_Manager.Bul.Class;
using Task_Manager.Dto;

namespace Task_Manager.Dao
{
    public class DaoAccount
    {
        private static DaoAccount instance;

        private DaoAccount() { }

        private string HasPassword(string password)
        {
            string hasPass = "";
            foreach (byte item in new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(password))) hasPass += item;
            return hasPass;
        }

        public Account Login(string username, string password)
        {  
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC procLogin @Username , @Password", new object[] { username, HasPassword(password) });
            return (data.Rows.Count == 1) ? new Account(data.Rows[0]) : null;
        }

        public void Refresh()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC procRefresh @Id", new object[] { Global.account.Id });
            Global.account = new Account(data.Rows[0]);
        }

        public int InsertAccount(int id, string username)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC procInsertAccount @Id , @Username", new object[] { id, username });
        }

        public void ResetPassword(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE Account SET Password = DEFAULT WHERE Id = @Id", new object[] { id });
        }

        public void DeleteAccount(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE Account WHERE Id = @Id", new object[] { id });
        }

        public int ChangePassword(int id, string oldPassword, string newPassword)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC procChangePassword @Id , @oldPassword , @newPassword", new object[] { id, HasPassword(oldPassword), HasPassword(newPassword) });
        }    

        public static DaoAccount Instance { get => instance ?? new DaoAccount(); private set => instance = value; }
    }
}
