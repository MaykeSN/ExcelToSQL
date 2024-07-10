using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSQLtoExcel.Controllers
{
    internal class ExcelController
    {
        public static async Task<List<string>> GetWorkSheets(string filePath)
        {
            var list = new List<string>();

            await Task.Run(() =>
            {
                using var workbook = new XLWorkbook(filePath);
                foreach (var planilha in workbook.Worksheets)
                {
                    list.Add(planilha.Name);
                }
            });

            return list;
        }

        public static async Task<List<string>> GetAllColumns(string filePath, string sheetName)
        {
            var columns = new List<string>();

            await Task.Run(() =>
            {
                using var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheet(sheetName); // Seleciona a planilha pelo nome


                foreach (var column in worksheet.ColumnsUsed())
                {
                    if (column.CellsUsed().Any(c => !string.IsNullOrEmpty(c.GetString())))
                    {
                        columns.Add(column.ColumnLetter());
                    }
                }

            });

            return columns;
        }
    }
}
