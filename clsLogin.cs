using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

using System.Windows.Forms;

namespace prySosaIEv
{
    
    internal class clsLogin
    {
        OleDbConnection conexionBD;
        public void AbridBD()
        {

            try
            {
                conexionBD = new OleDbConnection
                    (@"Provider = Microsoft.ACE.OLEDB.12.0;" +
                    " Data Source =../../Resources/BaseDeDatosUsuarios.accdb");

                conexionBD.Open();
            }
            catch (Exception ex)
            {
                //iria un msg
                MessageBox.Show(ex.Message);
            }

            
            
        }

        
    }
}
