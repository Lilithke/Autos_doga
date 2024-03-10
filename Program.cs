using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos_doga
{
    internal static class Program
    {
        public static List<Auto> autok = new List<Auto>();
        public static Adatbazis database = null;
        public static NyitoForm nyitoform = null;

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            database = new Adatbazis();
            autok = database.getAllautok();
            nyitoform = new NyitoForm();
            Application.Run(nyitoform);
        }
    }
}
