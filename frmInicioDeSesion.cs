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

        public static string usuario;
        public static string contraseña;
        int contador = 0;

        public void btnIngresar_Click(object sender, EventArgs e)
        {
           
            Timer timer = new Timer();
            timer.Interval = 1000;

            usuario = txtNombreUsuario.Text;
            contraseña = txtContraseña.Text;
           
            clsLogin login = new clsLogin();
            login.BuscarUsuario();

            if (clsLogin.respuesta == true)
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                contador = contador + 1;
                MessageBox.Show("Usuario o Contraeña incorrectos", "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (contador > 2)
                {
                    btnIngresar.Enabled = false;
                    contador = 0;
                }
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
            //clsLogin objLogin = new clsLogin();

            //objLogin.AbridBD(resp);
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            usuario = txtNombreUsuario.Text;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contraseña = txtContraseña.Text;
        }
    }
}
