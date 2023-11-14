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
    public partial class frmReestablecerPass : Form
    {
        public frmReestablecerPass()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmReestablecerPass_KeyDown);
        }

        public static string usuario;
        public static string contraseña;
        public static string RepContraseña;

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            usuario = txtusuario.Text;
            contraseña = txtContraseña.Text;
            RepContraseña = txtRepContraseña.Text;

            if (contraseña == RepContraseña)
            {
                clsLogin objLogin = new clsLogin();

                // Llamar al método Reestablecer con el nombre de usuario y la nueva contraseña
                objLogin.Reestablecer(usuario, contraseña);

                MessageBox.Show("Contraseña cambiada con éxito");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicioDeSesion volver = new frmInicioDeSesion();
            volver.Show();
        }

        private void frmReestablecerPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
