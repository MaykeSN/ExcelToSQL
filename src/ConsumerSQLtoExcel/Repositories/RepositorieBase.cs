using DocumentFormat.OpenXml.Drawing;
using MySql.Data.MySqlClient;

namespace ConsumerSQLtoExcel.Repositories
{
    internal class RepositorieBase
    {
        private const string ConnectionStringBase = "Server=[host];Database=[database];Uid=[username];Pwd=[password]";
        public static bool IsConnectionString(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) { return false; }

            char[] chars = connectionString.ToCharArray();

            int countChars = 0;
            foreach (char c in chars)
            {
                if (c == ';')
                {
                    countChars++;
                }
            }

            if (countChars < 2)
            {
                return false;
            }

            string[] strings = connectionString.Split(';');

            chars = [];

            chars = strings[0].ToCharArray();

            countChars = 0;

            foreach (char c in chars)
            {
                if (c == '.') { countChars++; }
            }

            if (countChars != 3)
            {
                if (!strings[0].Equals("localhost", StringComparison.CurrentCultureIgnoreCase))
                    return false;
            }

            if (string.IsNullOrWhiteSpace(strings[2]) || string.IsNullOrWhiteSpace(strings[1])) { return false; }

            return true;
        }
        public static string GetConnectionString(string con)
        {
            string connection = ConnectionStringBase;

            string[] strings = con.Split(";");

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Replace(";", "");
            }

            connection = connection.Replace("[host]", strings[0]);
            connection = connection.Replace("[database]", strings[1]);
            connection = connection.Replace("[username]", strings[2]);
            connection = connection.Replace("[password]", strings[3]);

            return connection;
        }
        public static MySqlConnection GetConnection(string conString)
        {
            return new MySqlConnection(conString);
        }
        public async static Task<bool> IsOkConnection(string conString)
        {
            bool result = false;

            await Task.Run(() =>
            {
                var con = new MySqlConnection(conString);
                try
                {
                    con.Open();
                }
                catch
                {
                    result = false;
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        result = true;
                        con.Close();
                    }
                }
            });

            return result;
        }
    }
}
