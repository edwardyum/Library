using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace uwp
{
    public static class Picture
    {
        public static async Task<BitmapImage> BytesToBitmapImage(byte[] bytes)
        {
            BitmapImage image = new BitmapImage();
            using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                await stream.WriteAsync(bytes.AsBuffer());
                stream.Seek(0);
                await image.SetSourceAsync(stream);
            }
            return image;
        }

        




    }
}
