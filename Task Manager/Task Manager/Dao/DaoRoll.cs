using System.Collections.Generic;
using System.Data;
using Task_Manager.Dto;

namespace Task_Manager.Dao
{
    public class DaoRoll
    {
        private static DaoRoll instance;

        private DaoRoll() { }

        public List<Roll> GetRoll()
        {
            List<Roll> rolls = new List<Roll>();
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM Roll ORDER BY Id DESC").Rows)
            {
                rolls.Add(new Roll(item));
            }
            return rolls;
        }

        public int InsertRoll(string name, int level)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC procInsertRoll @Name , @Level", new object[] { name, level });
        }

        public int UpdateRoll(int id, string name, int level)
        {                                                                  
            return (int)DataProvider.Instance.ExecuteScalar("EXEC procUpdateRoll @Id , @Name , @Level", new object[] { id, name, level });
        }

        public int DeleteRoll(int id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("DELETE Roll WHERE Id = @Id", new object[] { id });
        }

        public static DaoRoll Instance { get => instance ?? new DaoRoll(); private set => instance = value; }
    }
}
