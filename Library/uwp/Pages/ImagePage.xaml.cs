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
using Windows.UI.Xaml.Media.Imaging;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ImagePage : Page
    {
        public ImagePage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\e.yumagulov\AppData\Local\Packages\266fb51b-675f-4dcc-8112-88593e6b6385_2wpxf91wdknyr\LocalState\jpg.jpg";

            byte[] file = await Library.Tools.open(path);

            BitmapImage bitmapImage = await Picture.BytesToBitmapImage(file);

            image1.Source = bitmapImage;

            Library.Tools.bytesToFile("новый файл.jpg", file);
        }
    }
}
