﻿using ConsumerSQLtoExcel.Entities;
using MySql.Data.MySqlClient;
using System.Text;

namespace ConsumerSQLtoExcel.Helpers
{
    internal class QueryBuilder
    {
        public static string GetQueryString(ScriptConfig scriptConfig)
        {
            string initialQuery = $"INSERT INTO {scriptConfig.TableName} (";

            StringBuilder sb = new(initialQuery);

            int index = 0;
            foreach (var cols in scriptConfig.Columns) 
            {
                index++;
                if(index == scriptConfig.Columns.Count)
                {
                    sb.Append($"{cols.SqlColumn}");
                }
                else
                {
                    sb.Append($"{cols.SqlColumn}, ");
                }
                
            }
            sb.Append(") VALUES (");

            index = 0;
            foreach (var col in scriptConfig.Columns) 
            {
                index++;
                if (index == scriptConfig.Columns.Count)
                {
                    sb.Append($"{col.ExcelColumn}");
                }
                else
                {
                    sb.Append($"{col.ExcelColumn}, ");
                }
            }

            sb.Append(");");

            return sb.ToString();
        }
        public static (string, List<MySqlParameter>) BuildInsertQuery2(ScriptConfig config, List<Dictionary<string, string>> data)
        {
            var sb = new StringBuilder();
            var parameters = new List<MySqlParameter>();

            sb.AppendFormat("INSERT INTO {0} (", config.TableName);
            foreach (var column in config.Columns)
            {
                sb.AppendFormat("{0}, ", column.SqlColumn);
            }
            sb.Length -= 2; 
            sb.Append(") VALUES ");

           
            int rowIndex = 0;
            foreach (var row in data)
            {
                sb.Append('(');
                foreach (var column in config.Columns)
                {
                    var parameterName = $"@{column.SqlColumn}_{rowIndex}";
                    var value = row[column.SqlColumn];

                    if (DateTime.TryParse(value, out DateTime dateValue))
                    {
                        
                        value = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
                    }

                    sb.AppendFormat("{0}, ", parameterName);
                    parameters.Add(new MySqlParameter(parameterName, value));
                }
                sb.Length -= 2; 
                sb.Append("), ");
                rowIndex++;
            }
            sb.Length -= 2; 

            sb.Append(';');

            return (sb.ToString(), parameters);
        }
    }
}
