using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaIEv
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(AgregarUsuario_KeyDown);
        }

        string usuario;
        string contraseña;
        string ConfContraseña;

        private void AgregarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            usuario = txtNombreUsuario.Text;
            contraseña = txtContraseña.Text;
            ConfContraseña = txtContraseña.Text;

            clsLogin objLogin = new clsLogin();

            if (contraseña == ConfContraseña)
            {
                objLogin.CrearCuenta();
            }

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            usuario = txtNombreUsuario.Text;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contraseña = txtContraseña.Text;
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            ConfContraseña = txtContraseña.Text;
        }
    }
}
