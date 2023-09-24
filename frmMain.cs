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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmMostrarProveedores frmMostrarProveedores = new frmMostrarProveedores();
            frmMostrarProveedores.Show();
            frmMostrarProveedores.TopMost = true;
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmInicioDeSesion frmInicioSesion = new frmInicioDeSesion();
            //frmInicioSesion.Show();
            Application.Exit();
        }

        public void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmCargarProveedores frmCargarProveedores = new frmCargarProveedores();
            frmCargarProveedores.Show();
            frmCargarProveedores.TopMost = true;
            
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            frmMostrarProveedores frmMostrarProveedores = new frmMostrarProveedores();
            frmMostrarProveedores.Close();

        }
    }
}
