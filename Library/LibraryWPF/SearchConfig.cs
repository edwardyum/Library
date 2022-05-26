using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWPF
{
    internal class SearchConfig
    {
        public DataTable existence = new DataTable();   // таблица наличия файлов
        // столбец 1: путь; столбец 2: наличие файла; последующие столбцы: если файлы присутствуют, то каждый последующий столбец содержит имя присутствующего файла

        string directoryAtronic = @"C:\atronik";
        string directoryProgram = @"";
        string directory = @"C:\test";

        string fileName1 = "configuration";             // имя искомого файла конфигурации
        string fileName2 = "config";
        string fileName3 = "conf";

        string extention0 = "";                         // файл без расширения
        string extention1 = ".txt";
        string extention2 = ".json";

        List<string> paths = new List<string>();        // возможные пути расположение файла конфигурации
        List<string> files = new List<string>();        // возможные имена файлов конфигурации
        List<string> exten = new List<string>();        // возможные расширения файлов конфигурации


        public SearchConfig()
        {
            directoryProgram = Environment.CurrentDirectory;
        }

        public void search()
        {
            clear();
            fill();
            execute();
        }

        void clear()
        {
            existence = Tools.createDataTble(0, 3);
            paths.Clear();
            files.Clear();
            exten.Clear();
        }

        void fill()
        {
            paths.Add(directoryAtronic);
            paths.Add(directoryProgram);
            paths.Add(directory);

            files.Add(fileName1);
            files.Add(fileName2);
            files.Add(fileName3);

            exten.Add(extention0);
            exten.Add(extention1);
            exten.Add(extention2);
        }

        void execute()
        {
            for (int i = 0; i < paths.Count; i++)           // пробегаемся по всем путям
            {
                existence.Rows.Add();
                existence.Rows[i][0] = paths[i];
                int k = 2;

                existence.Rows[i][1] = false;

                for (int j = 0; j < files.Count; j++)       // пробегаемся по всем файлам
                {
                    for (int l = 0; l < exten.Count; l++)   // пробегаемся по всем расширениям
                    {
                        string file = files[j] + exten[l];
                        string path = Path.Combine(paths[i], file);

                        if (File.Exists(path))
                        {
                            existence.Rows[i][1] = true;

                            if (existence.Columns.Count < k + 1)
                                existence.Columns.Add();

                            existence.Rows[i][k] = file;

                            k++;
                        }
                    }
                }
            }
        }
    }
}
