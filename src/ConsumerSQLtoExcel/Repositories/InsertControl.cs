using ConsumerSQLtoExcel.Entities;
using ConsumerSQLtoExcel.Repositories.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSQLtoExcel.Repositories
{
    internal class InsertControl : IInsertable
    {
        public int InsertAllSheet(ScriptConfig config, string connectionString, string previewQuery)
        {
            using MySqlConnection con = RepositorieBase.GetConnection(RepositorieBase.GetConnectionString(connectionString));
            using MySqlCommand cmd = new();
            cmd.Connection = con;





            return 0;
        }
    }
}
