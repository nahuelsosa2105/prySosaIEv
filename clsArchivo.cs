using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prySosaIEv
{
    internal class clsArchivo
    {
        public void Grabar(string datosConcatenados)
        {
            StreamWriter AD = new StreamWriter("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv", true); //Abrir AdeD
            AD.WriteLine(datosConcatenados); //Leer AdeD
            AD.Close(); //Cerrar AdeD
        }

        
    }
}
