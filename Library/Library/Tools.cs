using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Library
{
    public static class Tools
    {
        public static void method()
        {

        }

        public static string get_local_folder()
        {
            return ApplicationData.Current.LocalFolder.Path;
        }
        
        

    }
}
