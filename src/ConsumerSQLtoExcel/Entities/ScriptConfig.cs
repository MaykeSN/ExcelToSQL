using Newtonsoft.Json;
namespace ConsumerSQLtoExcel.Entities
{
    internal class ScriptConfig
    {
        [JsonProperty("script_name")]
        public string? ScriptName { get; set; }
        [JsonProperty("con_string")]
        public string? ConnectionString { get; set; }
        [JsonProperty("table_name")]
        public string? TableName { get; set; }
        [JsonProperty("columns")]
        public List<Columns> Columns { get; set; }

    }
    internal class Scripts 
    {
        [JsonProperty("all_scripts")]
        internal List<ScriptConfig>? AllScripts { get; set; }
    }

    internal class Columns
    {
        [JsonProperty("sql_column")]
        public string SqlColumn { get; set; }
        [JsonProperty("excel_column")]
        public string ExcelColumn { get; set; }
    }
}
