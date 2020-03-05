using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    static class ImageController
    {
        private static string imagesPath = Directory.GetCurrentDirectory();

        public static void Init()
        {
#if DEBUG || RELEASE
            imagesPath = imagesPath.Substring(0, imagesPath.LastIndexOf("\\"));
            imagesPath = imagesPath.Substring(0, imagesPath.LastIndexOf("\\"));
#endif

            imagesPath += "\\Images\\";
        }

        public static Bitmap Open(string fileName)
        {
            var svgDocument = Svg.SvgDocument.Open(imagesPath + fileName);
            svgDocument.ShapeRendering = SvgShapeRendering.Auto;

            return svgDocument.Draw();
        }
    }
}
