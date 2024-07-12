using ConsumerSQLtoExcel.Entities;
namespace ConsumerSQLtoExcel.Repositories.Interfaces
{
    internal interface IInsertable
    {
        int InsertDataFromExcelToDatabase(List<Dictionary<string, string>> data, string query);
    }
}
