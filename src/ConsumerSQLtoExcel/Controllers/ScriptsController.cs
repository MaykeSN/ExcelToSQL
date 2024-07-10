using ConsumerSQLtoExcel.Entities;
using ConsumerSQLtoExcel.Exceptions;
using Newtonsoft.Json;
namespace ConsumerSQLtoExcel.Controllers
{
    public class ScriptsController
    {
        internal static Scripts GetAllScripts()
        {

            if (!File.Exists(@"Configs\scripts.json"))
            {
                throw new FilesControllersException("Erro não existem scripts criados");
            }

            string jsonStr = File.ReadAllText(@"Configs\scripts.json");

            if (string.IsNullOrEmpty(jsonStr)) 
            {
                throw new FilesControllersException("Erro, arquivo de scripts vazios");
            }

            return JsonConvert.DeserializeObject<Scripts>(jsonStr) ?? throw new NullReferenceException();
        }

        internal static int CreateScript(string scriptName, string conString, string tableName, List<Columns> columns)
        {
            string path = @"Configs\scripts";

            if (File.Exists(path))
            {
                string jsonStr = File.ReadAllText(path);

                if (!string.IsNullOrEmpty(jsonStr)) 
                {
                    var scripts = JsonConvert.DeserializeObject<Scripts>(jsonStr);

                    var strConfigs = new ScriptConfig() 
                    {
                        ScriptName = scriptName,
                        TableName = tableName,
                        ConnectionString = conString,
                        Columns = columns
                    };

                    scripts?.AllScripts?.Add(strConfigs);

                    jsonStr = JsonConvert.SerializeObject(scripts);

                    File.WriteAllText(path, jsonStr);

                    return scripts.AllScripts.Count;
                }
            }

            var strConfig = new ScriptConfig()
            {
                ScriptName = scriptName,
                TableName = tableName,
                ConnectionString = conString,
                Columns = columns
            };

            var scrips = new Scripts
            {
                AllScripts = [strConfig]
            };

            string str = JsonConvert.SerializeObject(scrips);

            File.WriteAllText(path, str);

            return scrips.AllScripts.Count;
        }
    }
}
