using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Library
{

    // ПОКА НИЧТО НЕ ОТТЕСТИРОВАНО

    public static class Tools
    {
        
        
        public static void method()
        {

        }

        public static async Task<byte[]> open(string path)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await storageFolder.GetFileAsync("jpg.jpg");

            byte[] result;
            using (Stream stream = await sampleFile.OpenStreamForReadAsync())
            {
                using (var memoryStream = new MemoryStream())
                {

                    stream.CopyTo(memoryStream);
                    result = memoryStream.ToArray();
                }
            }

            return result;
        }

        public static string get_local_folder()
        {
            return ApplicationData.Current.LocalFolder.Path;
        }

        public static async void bytesToFile(string name, byte[] bytes)
        {
            // создаём файл и записываем в него массив байт

            if (!checkName(name))
                return;

            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile storageFile = await storageFolder.CreateFileAsync(name, Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteBytesAsync(storageFile, bytes);
        }

        private static bool checkName(string fileName)    // проверка имени файла на наличие букв до точки и букв после точки - имени и расширения
        {
            bool admitted = true;

            if (string.IsNullOrEmpty(fileName))
            {
                string[] parts = fileName.Split(".");

                if (parts.Length != 2)
                    return false;
                    
                if (parts[0].Length == 0 || parts[1].Length == 0)
                    return false;
            }
            else
                admitted = false;
                
            return admitted;
        }



    }
}
