using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using ConsumerSQLtoExcel.Entities;
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

        public static async Task<List<Dictionary<string, string>>> GetDataExcelAsync(string filePath, ScriptConfig script, bool skipFirstRow, ProgressBar progressBar)
        {
            var data = new List<Dictionary<string, string>>();

            await Task.Run(() =>
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(script.Sheet);
                    var rows = worksheet.RowsUsed();
                    int totalRows = rows.Count();
                    int rowIndex = 0;

                    progressBar.Invoke(new Action(() =>
                    {
                        progressBar.Minimum = 0;
                        progressBar.Maximum = totalRows;
                        progressBar.Value = 0;
                    }));

                    foreach (var row in rows)
                    {
                        if (skipFirstRow && rowIndex == 0)
                        {
                            rowIndex++;
                            continue;
                        }

                        var rowData = new Dictionary<string, string>();

                        foreach (var column in script.Columns)
                        {
                            var cellValue = row.Cell(column.ExcelColumn).GetValue<string>();
                            rowData.Add(column.SqlColumn, cellValue);
                        }

                        data.Add(rowData);
                        rowIndex++;

                        // Atualizar a barra de progresso na UI thread
                        progressBar.Invoke(new Action(() =>
                        {
                            progressBar.Value = rowIndex;
                            progressBar.Refresh();
                        }));
                    }
                }
            });

            return data;
        }
    }
}
