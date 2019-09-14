using System.Collections.Generic;
using System.Data;
using Task_Manager.Dto;

namespace Task_Manager.Dao
{
    public class DaoEmployee
    {
        private static DaoEmployee instance;

        private DaoEmployee() { }

        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM viewEmployee ORDER BY RollId DESC").Rows)
            {
                employees.Add(new Employee(item));
            }
            return employees;
        }

        public List<Account> GetEmployeeWithAccount()
        {
            List<Account> accounts = new List<Account>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM viewEmployeeWithAccount ORDER BY RollId DESC").Rows)
            {
                accounts.Add(new Account(item));
            }
            return accounts;
        }

        public void InsertEmployee(string name, int roll, string phone, string email)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC procInsertEmployee @Name , @Roll , @Phone , @Email", new object[] { name, roll, phone, email });
        }

        public void UpdateEmployee(int id, string name, int roll, string phone, string email)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC procUpdateEmployee @Id , @Name , @Roll , @Phone , @Email", new object[] { id, name, roll, phone, email });
        }

        public int DeleteEmployee(int id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("DELETE Employee WHERE Id = @Id", new object[] { id });
        }        

        public static DaoEmployee Instance { get => instance ?? new DaoEmployee(); private set => instance = value; }
    }
}
