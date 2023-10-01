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
    public partial class frmCargarProveedores : Form
    {
        public frmCargarProveedores()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(TxtNumero.Text == "" && txtEntidad.Text == "" && txtApertura.Text == "" && txtJuzgado.Text =="" && txtExpediente.Text == "" && txtJurisdiccion.Text == "" && txtDireccion.Text == "" && txtLiquidador.Text == "")
            {

            }
        }
    }
}
