using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Library;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class SQLitePage : Page
    {
        public SQLitePage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string db_name = "новая база данных.db";
            SQLite.initialize(db_name);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {            
            string message = "при проверке доступности базы данных";
            bool access = SQLite.check_access(message);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SQLite.create_db();
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\e.yumagulov\AppData\Local\Packages\266fb51b-675f-4dcc-8112-88593e6b6385_2wpxf91wdknyr\LocalState\jpg.jpg";
            byte[] file = await Tools.open(path);

            string table = "table_1";
            string field = "bytes";

            SQLite.insert_bytes(table, field, file);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string table = "table_1";
            string field = "bytes";

            string where = "Id";
            string condition = "2";

            List<byte[]> bytes = SQLite.download_bytes(table, field, where, condition);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("text", "некоторый текст");

            string table = "table_1";

            string row = SQLite.add(table, values);
        }
    }
}
