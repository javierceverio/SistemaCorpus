using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corpus
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autenticacion());
            //Application.Run(new Inicio("CREISYS"));
            //Application.Run(new Empleados("MARCELO EDUARDO BERRIDI"));
            //Application.Run(new Percibido("MARCELO EDUARDO BERRIDI"));
        }
    }
}
