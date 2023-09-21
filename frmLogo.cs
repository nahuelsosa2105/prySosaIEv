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
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void tmrLogo_Tick(object sender, EventArgs e)
        {
            pbrLogo.Increment(10);
            lblPorcentaje.Text = pbrLogo.Value.ToString() + "%";
            if (pbrLogo.Value == pbrLogo.Maximum)
            {
                tmrLogo.Stop();
                this.Hide();
                frmInicioDeSesion frmInicioDeSesion = new frmInicioDeSesion();
                frmInicioDeSesion.Show();
            }
        }
    }
}
