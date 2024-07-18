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
        public int InsertDataFromExcelToDatabase(string query, string connection)
        {
            int count = 0;
            using MySqlConnection con = RepositorieBase.GetConnection(connection);
            using MySqlCommand cmd = new(query, con);

            try
            {
                if(con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally 
            {
                con.Close();
            }

            return count;
        }

        public async Task<int> InsertDataFromExcelToDatabase(string query, List<MySqlParameter> parameters, string connection)
        {
            int count = 0;
            using MySqlConnection con = RepositorieBase.GetConnection(connection);
            using MySqlCommand cmd = new(query, con);

            await Task.Run(() => {
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }

                    cmd.Parameters.AddRange(parameters.ToArray());

                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            });

            return count;
        }
    }
}
