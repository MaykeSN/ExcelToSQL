using Newtonsoft.Json;
namespace ConsumerSQLtoExcel.Entities
{
    public class FoldersMap
    {
        [JsonProperty("folders")]
        public List<FoldersObj>? Folders {  get; set; }
    }

    public class FoldersObj
    {
        [JsonProperty("path")]
        public string? Path { get; set; }
        [JsonProperty("filename")]
        public string? Filename { get; set; }
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
