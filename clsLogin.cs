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

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\Resources\\BDUsuarios.accdb";

        public string conexion = "";

        public string datosTabla = "";

        public static bool respuesta;

        DataSet objDS = new DataSet();

        public void conectarBD()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexion;
            conexionBD.Open();
        }


        public static string rango;

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
                    rango = lectorBD[3].ToString();

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

        public void CrearCuenta()
        {
            try
            {
                conectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                comandoBD.CommandText = "users";

                OleDbDataAdapter adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "users");

                DataTable objtabla = objDS.Tables["users"];

                DataRow nuevoRegistro = objtabla.NewRow();

                nuevoRegistro["usuario"] = AgregarUsuario.usuario;
                nuevoRegistro["password"] = AgregarUsuario.contraseña;
                nuevoRegistro["categoria"] = "user";

                objtabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDS, "users");

                MessageBox.Show("¡Cuenta Creada Con Exito!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        /*
        public void CrearCuenta()
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaConexion))
                {
                    conexionBD.Open();

                    using (OleDbCommand comandoBD = new OleDbCommand())
                    {
                        comandoBD.Connection = conexionBD;
                        comandoBD.CommandType = CommandType.Text;
                        comandoBD.CommandText = "INSERT INTO users (usuario, password, categoria) VALUES (?, ?, ?)";

                        comandoBD.Parameters.AddWithValue("usuario", AgregarUsuario.usuario);
                        comandoBD.Parameters.AddWithValue("password", AgregarUsuario.contraseña);
                        comandoBD.Parameters.AddWithValue("categoria", "user");

                        comandoBD.ExecuteNonQuery();

                        MessageBox.Show("¡Usuario creado con éxito!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de alguna manera, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }
        */

    }
}
