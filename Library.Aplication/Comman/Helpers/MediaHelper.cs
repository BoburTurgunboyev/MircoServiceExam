using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.Comman.Helpers
{
    public class MediaHelper
    {
        public static string MakeImageName(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);

            string[] ImageExtension = GetImageExtensions();

            if (ImageExtension.Any(x => x == fileInfo.Extension))
            {
                string extension = fileInfo.Extension;
                string name = "IMG_" + Guid.NewGuid() + extension;
                return name;
            }
            return null;
        }

        public static string[] GetImageExtensions()
        {
            return new string[]
            {
            ".jpg", ".jpeg",
            ".png",
            ".bmp",
            ".svg"
            };
        }
    }
}
