using System.Data;

namespace Task_Manager.Dto
{
    public class Account
    {
        private string username;
        private readonly Employee employee;

        public Account(DataRow row)
        {
            Username = row["Username"].ToString();
            employee = new Employee((int)row["Id"], row["Name"].ToString(), (int)row["RollId"], (int)row["RollLevel"], row["RollName"].ToString(), row["Phone"].ToString(), row["Email"].ToString());            
        }

        public int Id { get => employee.Id; set => employee.Id = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => employee.Name; set => employee.Name = value; }
        public int RollId { get => employee.RollId; set => employee.RollId = value; }
        public int RollLevel { get => employee.RollLevel; set => employee.RollLevel = value; }
        public string RollName { get => employee.RollName; set => employee.RollName = value; }
        public string Phone { get => employee.Phone; set => employee.Phone = value; }
        public string Email { get => employee.Email; set => employee.Email = value; }
    }
}
