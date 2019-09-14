using System.Data;

namespace Task_Manager.Dto
{
    public class GroupRoll
    {
        private int id;
        private string name;

        public GroupRoll(DataRow row)
        {
            Id = (int)row["Id"];
            Name = row["Name"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
