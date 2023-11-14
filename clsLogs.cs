using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prySosaIEv
{
    internal class clsLogs
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        public static string rutaArchivo;
        public string estadoConexion;

        public clsLogs()
        {
            try
            {
                rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BDUsuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }
      

        public void RegistroLogInicioSesion()
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(rutaArchivo))
                {
                    conexionBD.Open();

                    using (OleDbCommand comandoBD = new OleDbCommand())
                    {
                        comandoBD.Connection = conexionBD;
                        comandoBD.CommandType = CommandType.Text;
                        comandoBD.CommandText = "INSERT INTO logs (usuario, categoria, [fecha/hora], descripcion) VALUES (?, ?, ?, ?)";

                        comandoBD.Parameters.AddWithValue("usuario", frmInicioDeSesion.usuario);
                        comandoBD.Parameters.AddWithValue("categoria", clsLogin.rango);
                        comandoBD.Parameters.AddWithValue("fecha/hora", DateTime.Now);
                        comandoBD.Parameters.AddWithValue("descripcion", frmInicioDeSesion.accion);

                        comandoBD.ExecuteNonQuery();

                        estadoConexion = "Registro exitoso de log";
                    }
                }
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void ValidarUsuario(string nombreUser, string passUser)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuario";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == nombreUser && lectorBD[2].ToString() == passUser)
                        {
                            estadoConexion = "Usuario EXISTE";
                        }
                    }
                }

            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }
    }
}
