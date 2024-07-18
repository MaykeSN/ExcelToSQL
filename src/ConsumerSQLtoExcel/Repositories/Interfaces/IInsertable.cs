using ConsumerSQLtoExcel.Entities;
namespace ConsumerSQLtoExcel.Repositories.Interfaces
{
    internal interface IInsertable
    {
        int InsertDataFromExcelToDatabase(string query, string connection);
    }
}
