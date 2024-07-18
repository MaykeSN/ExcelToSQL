using ConsumerSQLtoExcel.Entities;
using ConsumerSQLtoExcel.Exceptions;
using Newtonsoft.Json;
namespace ConsumerSQLtoExcel.Controllers
{
    internal class DialogsController
    {
        public static DialogResult OpenFileCsvXlsx()
        {
            using OpenFileDialog dialog = new()
            {
                Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx",
                Title = "Selecione um arquivo CSV ou XLSX",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = Path.GetFileName(dialog.FileName);

                FoldersObj folders = new()
                {
                    Path = dialog.FileName,
                    Filename = Path.GetFileName(dialog.FileName),
                    Type = Path.GetExtension(file).TrimStart('.')
                };

                string json = File.ReadAllText(@"Configs\configs_folders.json");

                FoldersMap map;
                map = JsonConvert.DeserializeObject<FoldersMap>(json);

                map ??= new();

                if (map.Folders is not null)
                {
                    map.Folders[0] = folders;
                }
                else
                {
                    map.Folders = [folders];
                }

                string jsonResult = JsonConvert.SerializeObject(map);

                File.WriteAllText(@"Configs\configs_folders.json", jsonResult);

                return DialogResult.OK;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }

        public static FoldersMap GetAllFilesCsvXlsx()
        {
            string path = @"Configs\configs_folders.json";
            string json = "";
            if (File.Exists(path))
            {
                json = File.ReadAllText(path);
            }
            else
            {
                throw new FilesControllersException("Falha ao encontrar arquivo de configuração de pacote");
            }

            var map = JsonConvert.DeserializeObject<FoldersMap>(json) ?? throw new FilesControllersException("Falha ao encontrar obter arquivos de configs_folders");

            if (map.Folders is null) { throw new FilesControllersException("Não ha historico de arquivos, selecione um arquivo!"); }
            
            return map ?? new();
        }
    }
}
