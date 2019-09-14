using System;
using System.Collections.Generic;
using System.Data;
using Task_Manager.Dto;

namespace Task_Manager.Dao
{
    public class DaoTask
    {
        private static DaoTask instance;

        private DaoTask() { }

        public List<Task> GetTask(DateTime from, DateTime to)
        {
            List<Task> tasks = new List<Task>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM viewTask WHERE Time BETWEEN @From AND @To ORDER BY Time", new object[] { from, to }).Rows)
            {
                tasks.Add(new Task(item));
            }
            return tasks;
        }

        public void InsertTask(int objectId, DateTime time, string location, string content, string note)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC procInsertTask @ObjectId , @Time , @Location , @Content , @Note", new object[] { objectId, time, location, content, note });
        }

        public void UpdateTask(int id, int objectId, DateTime time, string location, string content, string note)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC procUpdateTask @Id , @ObjectId , @Time , @Location , @Content , @Note", new object[] {id, objectId, time, location, content, note });
        }

        public void DeleteTask(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE Task WHERE Id = @Id", new object[] { id });
        }

        public static DaoTask Instance { get => instance ?? new DaoTask(); private set => instance = value; }
    }
}
