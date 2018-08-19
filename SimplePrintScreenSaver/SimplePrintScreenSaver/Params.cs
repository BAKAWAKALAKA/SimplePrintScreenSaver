using System.Configuration;

namespace SimplePrintScreenSaver
{
    class Params
    {
        public static string PATCH
        {
            get
            {
                return ConfigurationSettings.AppSettings["PATCH"];
            }
        }
    }
}
