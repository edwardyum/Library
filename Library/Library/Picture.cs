using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace uwp
{
    public static class Picture
    {
        public static async void ImageToByteArray(string path)
        {
            StorageFolder picLib = KnownFolders.PicturesLibrary;
            var picfiles = await picLib.GetFilesAsync();

            //// Ensure the stream is disposed once the image is loaded
            //using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
            //{
            //    // Set the image source to the selected bitmap
            //    BitmapImage bitmapImage = new BitmapImage();
            //    // Decode pixel sizes are optional
            //    // It's generally a good optimisation to decode to match the size you'll display
            //    //bitmapImage.DecodePixelHeight = decodePixelHeight;
            //    //bitmapImage.DecodePixelWidth = decodePixelWidth;

            //    await bitmapImage.SetSourceAsync(fileStream);
            //    mypic.Source = bitmapImage;
            //}
            //g.EndInit();

        }


        //public static byte[] ImageToByteArray(BitmapImage image)
        //{
        //    BitmapImage image = new BitmapImage();
        //    using (var ms = new MemoryStream())
        //    {
        //        image.Save(ms, imageIn.RawFormat);
        //        return ms.ToArray();
        //    }


        //    //"ссылки" -> "Добавить ссылку" -> System.Drawing.dll
        //    using (var ms = new MemoryStream())
        //    {
        //        imageIn.Save(ms, imageIn.RawFormat);
        //        return ms.ToArray();
        //    }
        //}
    }
}
