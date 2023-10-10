using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

using System.Windows.Forms;
using System.Data;

namespace prySosaIEv
{
    
    internal class clsLogin
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand objcmd = new OleDbCommand();
        OleDbDataReader objdr;
        public void AbridBD()
        {

            try
            {
                // definir la cadena de conexión
                string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source =../../Resources/BaseDeDatosUsuarios.accdb";
                // asignar la cadena al objeto conexión
                conexionBD.ConnectionString = cadenaDeConexion;
                // abrir la conexión con la base de datos
                conexionBD.Open();
                // establecer las propiedades al objeto comando
                objcmd.Connection = conexionBD;
                objcmd.CommandType = CommandType.TableDirect;
                objcmd.CommandText = "users";// nombre de la tabla a leer
                // ejecutar la lectura de la tabla con un objetoDataReader
                objdr = objcmd.ExecuteReader();
                // controlar si la lectura obtuvo registros
                if (objdr.HasRows)
                {
                    string datos = ""; // variable auxiliarpara almacenar los datos de la tabla

                    while (objdr.Read()) // leer mientras existan registros
                    {
                        // concatenar los campos de la tabla'users': 'Id' y 'Usuarios'
                        // para leer cada campo hay que especificar el tipo de dato y la posición del campo en la tabla 
                        // en este caso el primer campo (posisicón0) es de tipo entero y el segundo campo (posición 1) es string

                        datos += objdr.GetInt32(0).ToString() + ", " + objdr.GetString(1) + "\r\n";
                    }
                    // mostrar todos los datos obtenidos dela tabla
                    MessageBox.Show(datos, "Tabla de Usuarios– DataReader");
                }
                conexionBD.Close();


            }
            catch (Exception ex)
            {
                //iria un msg
                MessageBox.Show(ex.Message);
            }

            
            
        }

        
    }
}
