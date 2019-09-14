using System.Data;

namespace Task_Manager.Dto
{
    public class Employee
    {
        private int id;
        private string name;
        private readonly Roll roll;
        private string phone;
        private string email;

        public Employee(int id, string name, int rolId, int rollLevel, string rollName, string phone, string email)
        {
            Id = id;
            Name = name;
            roll = new Roll(rolId, rollLevel, rollName);
            Phone = phone;
            Email = email;
        }

        public Employee(DataRow row)
        {
            Id = (int)row["Id"];
            Name = row["Name"].ToString();
            roll = new Roll((int)row["RollId"], (int)row["RollLevel"], row["RollName"].ToString());
            Phone = row["Phone"].ToString();
            Email = row["Email"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int RollId { get => roll.Id; set => roll.Id = value; }
        public int RollLevel { get => roll.Level; set => roll.Level = value; }
        public string RollName { get => roll.Name; set => roll.Name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }   
    }
}
