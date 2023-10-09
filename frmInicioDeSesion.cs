using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace prySosaIEv
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void frmInicioDeSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contraseña =txtContraseña.Text;

            


            if (usuario == "admin" && contraseña == "admin")
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            
        }
        
        public void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
//            Data;
            MessageBox.Show("En proceso de desarrollo, disculpe las molestias");
        }

        private void pctMostrarConstraseña_Click(object sender, EventArgs e)
        {
            pctOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0'; 
        }

        private void pctOcultar_Click(object sender, EventArgs e)
        {
            pctMostrarConstraseña.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsLogin objLogin = new clsLogin();

            objLogin.AbridBD();
        }
    }
}
