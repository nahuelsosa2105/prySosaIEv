using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

using System.Windows.Forms;
using System.Data;
using System.Security.Policy;

namespace prySosaIEv
{
    
    internal class clsLogin
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDeDatosUsuarios.accdb";

      

        public string datosTabla = "";

        public static bool respuesta;

        public void conectarBD()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexion;
            conexionBD.Open();
        }

       


        public void BuscarUsuario()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexion;
            conexionBD.Open();
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "users";

            lectorBD = comandoBD.ExecuteReader();
            
            if (lectorBD.HasRows)
            {
               
                while(lectorBD.Read())
                {
                    string usuarioBD = lectorBD[1].ToString();
                    string contraseñaBD = lectorBD[2].ToString();

                    if (usuarioBD == frmInicioDeSesion.usuario & contraseñaBD == frmInicioDeSesion.contraseña)
                    {
                        respuesta = true;
                        break;
                    }
                    else
                    {
                        respuesta = false;
                    }

                }
                
            }
        }


        
    }
}
