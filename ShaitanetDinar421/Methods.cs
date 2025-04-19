using System.IO;
using System.Windows.Media.Imaging;

namespace ShaitanetDinar421
{
    public static class Methods
    {
        public static BitmapImage GetImageFromBytes(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = memoryStream;
            bitmapImage.EndInit();
            return bitmapImage;
        }
    }
}
