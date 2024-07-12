using ConsumerSQLtoExcel.Entities;
namespace ConsumerSQLtoExcel.Repositories.Interfaces
{
    internal interface IInsertable
    {
        int InsertAllSheet(ScriptConfig config, string connectionString, string previewQuery);
    }
}
