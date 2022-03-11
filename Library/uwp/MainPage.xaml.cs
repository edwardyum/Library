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
using System.ComponentModel.DataAnnotations;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace uwp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SQLite.initialize();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test_1();
        }


        private void test_1()
        {
            string path = Library.Tools.get_local_folder();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string table = "tasks";

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("name", "новенькая задачка");
            data.Add("creation_date", Time.now());

            SQLite.add(table, data);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //string table = "tasks";

            //Dictionary<string, string> condotion = new Dictionary<string, string>();
            //condotion.Add("Id", "2");

            //List<string> res = SQLite.get(table, condotion);

            //DateTime dateTime = DateTime.Parse(res[0]);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string table = "tasks";
            Dictionary<string, string> values = new Dictionary<string, string>() { { "name", "новое название"} };
            Dictionary<string, string> where = new Dictionary<string, string>() { { "Id", "1" } };

            SQLite.update(table, values, where);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string table = "tasks";
            string field = "Id";
            string value = "4";

            SQLite.delete(table, field, value);
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var selectedItem = args.InvokedItemContainer as NavigationViewItem;

            if (selectedItem == null)
            {

            }
            else
            {
                string selectedItemTag = selectedItem.Tag?.ToString() ?? "Settings";
                Type pageType = PagesList.choose_page(selectedItemTag);
                contentFrame.Navigate(pageType);
            }
        }
    }
}
