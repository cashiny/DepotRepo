using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Dao
    {

        public IEnumerable<Tool> GetTools()
        {
            List<Tool> allTools = new List<Tool>();
            using (IDbConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.Open();

                var tools = sqlConnection.Query("select * from Tools", null, null, true, null, CommandType.Text);

                foreach(var t in tools)
                {
                    allTools.Add(t as Tool);
                }

                sqlConnection.Close();
            }
            return allTools;

        }
    

    }
}
