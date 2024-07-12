using ConsumerSQLtoExcel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSQLtoExcel.Helpers
{
    internal class QueryBuilder
    {
        public static string GetQueryString(ScriptConfig scriptConfig)
        {
            string initialQuery = $"INSERT INTO {scriptConfig.TableName} (";

            StringBuilder sb = new StringBuilder(initialQuery);

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
    }
}
