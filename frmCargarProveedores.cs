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
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmCargarProveedores_KeyDown);
        }
        int numGuia = 158;
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
                                        //crea una nueva matriz de strings llamada datosProveedores. 
                                        string[] datosProveedores = new string[] {numGuia.ToString(),txtEntidad.Text,txtApertura.Text,txtExpediente.Text,txtJuzgado.Text,txtJurisdiccion.Text,txtDireccion.Text,txtLiquidador.Text };
                                        //El código luego crea una nueva cadena llamada datosConcatenados. Esta cadena contiene los valores de la matriz datosProveedores, separados por comas.
                                        string datosConcatenados = string.Join(";", datosProveedores);
                                        //El código luego llama al método Grabar() de la clase grabado. Este método escribe la cadena datosConcatenados en un archivo de texto
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
                                            frmMain.contProv = 0;
                                            frmMain.contCargar = 0;
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

        private void frmCargarProveedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
