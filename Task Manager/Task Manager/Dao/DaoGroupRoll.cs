using System.Collections.Generic;
using System.Data;
using Task_Manager.Dto;

namespace Task_Manager.Dao
{
    public class DaoGroupRoll
    {
        private static DaoGroupRoll instance;

        private DaoGroupRoll() { }

        public List<GroupRoll> GetAllGroupRoll()
        {
            List<GroupRoll> groups = new List<GroupRoll>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM GroupRoll").Rows)
            {
                groups.Add(new GroupRoll(item));
            }
            return groups;
        }

        public List<GroupRoll> GetGroupRoll()
        {
            List<GroupRoll> groups = new List<GroupRoll>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM GroupRoll WHERE Id < 0 ORDER BY Id DESC").Rows)
            {
                groups.Add(new GroupRoll(item));
            }
            return groups;
        }

        public int InsertGroupRoll(string name)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC procInsertGroupRoll @Name", new object[] { name });
        }

        public int UpdateGroupRoll(int id, string name)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC procUpdateGroupRoll @Id , @Name", new object[] { id, name });
        }

        public int DeleteGroupRoll(int id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("DELETE GroupRoll WHERE Id = @Id", new object[] { id });
        }

        public static DaoGroupRoll Instance { get => instance ?? new DaoGroupRoll(); private set => instance = value; }
    }
}
