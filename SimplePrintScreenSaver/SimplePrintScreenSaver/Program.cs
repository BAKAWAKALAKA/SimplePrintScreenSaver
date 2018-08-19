using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;


namespace SimplePrintScreenSaver
{

    class Program
    {
        public static void Main()
        {
            PrtScHook.Set(PrintScreen.Save);
            Application.Run();
            PrtScHook.Remove();
        }
    }
}
