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
        int numGuia = 6;
        clsArchivo grabado = new clsArchivo();
        

        public void btnCargar_Click(object sender, EventArgs e)
        {

            

                if (txtEntidad.Text == "")
                {
                    MessageBox.Show("Campo entidad vacio");
                    txtEntidad.Focus();
                }
                else
                {
                    if (txtApertura.Text == "")
                    {
                        MessageBox.Show("Campo apertura vacio");
                        txtApertura.Focus();
                    }
                    else
                    {
                        if (txtExpediente.Text == "")
                        {
                            MessageBox.Show("Campo número de expediente vacio");
                            txtExpediente.Focus();
                        }
                        else
                        {
                            if (txtJuzgado.Text == "")
                            {
                                MessageBox.Show("Campo juzgado vacio");
                                txtJuzgado.Focus();
                            }
                            else
                            {
                                if (txtJurisdiccion.Text == "")
                                {
                                    MessageBox.Show("Campo jurisdiccion vacio");
                                    txtJurisdiccion.Focus();
                                }
                                else
                                {
                                    if (txtDireccion.Text == "")
                                    {
                                        MessageBox.Show("Campo direccion vacio");
                                        txtDireccion.Focus();
                                    }
                                    else
                                    {
                                        if (txtLiquidador.Text == "")
                                        {
                                            MessageBox.Show("Campo liquidador responsable vacio");
                                            txtLiquidador.Focus();
                                        }
                                    else
                                    {
                                        string[] datosProveedores = new string[] {numGuia.ToString(),txtEntidad.Text,txtApertura.Text,txtExpediente.Text,txtJuzgado.Text,txtJurisdiccion.Text,txtDireccion.Text,txtLiquidador.Text };

                                        string datosConcatenados = string.Join(";", datosProveedores);

                                        grabado.Grabar(datosConcatenados);

                                        numGuia++;
                                        lblNumProveedor.Text = numGuia.ToString();
                                        txtEntidad.Clear();
                                        txtApertura.Clear();
                                        txtExpediente.Clear();
                                        txtJuzgado.Clear();
                                        txtJurisdiccion.Clear();
                                        txtDireccion.Clear();
                                        txtLiquidador.Clear();
                                        MessageBox.Show("Proveedor cargado correctamente");
                                    }

                                }
                            }
                            }
                        }
                    }
                }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtEntidad.Clear();
            txtApertura.Clear();
            txtExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
        }

        private void frmCargarProveedores_Load(object sender, EventArgs e)
        {
            lblNumProveedor.Text = numGuia.ToString();
        }
    }
}
