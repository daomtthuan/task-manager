using System;
using System.Data;

namespace Task_Manager.Dto
{
    public class Task
    {
        private int id;
        private int objectId;
        private string name;
        private string rollId;
        private string rollName;
        private DateTime time;
        private string location;
        private string content;
        private string note;


        public Task(DataRow row)
        {
            Id = (int)row["Id"];
            ObjectId = (int)row["ObjectId"];
            Name = row["Name"].ToString();
            RollId = row["RollId"].ToString();
            RollName = row["RollName"].ToString();
            Time = (DateTime)row["Time"];
            Location = row["Location"].ToString();
            Content = row["Content"].ToString();
            Note = row["Note"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public int ObjectId { get => objectId; set => objectId = value; }
        public string Name { get => name; set => name = value; }
        public string RollId { get => rollId; set => rollId = value; }
        public string RollName { get => rollName; set => rollName = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Location { get => location; set => location = value; }
        public string Content { get => content; set => content = value; }
        public string Note { get => note; set => note = value; }
    }
}
