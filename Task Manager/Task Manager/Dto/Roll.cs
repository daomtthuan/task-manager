using System.Data;

namespace Task_Manager.Dto
{
    public class Roll
    {
        private int id;
        private int level;
        private string name;

        public Roll(int id, int level, string name)
        {
            Id = id;
            Level = level;
            Name = name;
        }

        public Roll(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Roll(DataRow row)
        {
            Id = (int)row["Id"];
            Level = (int)row["Level"];
            Name = row["Name"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public int Level { get => level; set => level = value; }
        public string Name { get => name; set => name = value; }
    }
}
