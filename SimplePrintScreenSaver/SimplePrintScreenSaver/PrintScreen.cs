using System;
using System.Drawing;
using System.Windows.Forms;


namespace SimplePrintScreenSaver
{
    class PrintScreen
    {
        public static void Save()
        {
            Image img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            var graph = Graphics.FromImage(img);
            graph.CopyFromScreen(0, 0, 0, 0, img.Size);
            var vat = DateTime.Now.ToString().Replace(':', '-') + ".png";
            vat = Params.PATCH + vat;
            img.Save(vat);
        }
    }
}
