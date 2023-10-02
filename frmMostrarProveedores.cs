using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using prySosaIEv.Properties;
using System.Data;
using System.Windows.Forms;

namespace prySosaIEv
{
    public partial class frmMostrarProveedores : Form
    {
        private frmModificarProveedor modificarProveedor;
        public frmMostrarProveedores()
        {
            InitializeComponent();
            PopulateTreeView();
            modificarProveedor = new frmModificarProveedor();
        }
        
        public void frmMostrarProveedores_Load(object sender, EventArgs e)
        {
            
            frmModificarProveedor modificarProveedor = new frmModificarProveedor();
        }

        public void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Carpetas de Proveedores");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                tvwMostrarProveedores.Nodes.Add(rootNode);
            }
        }

        public void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        public void tvwMostrarProveedores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            {
                TreeNode newSelected = e.Node;
                lvwMostrarProveedores.Items.Clear();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                        {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    lvwMostrarProveedores.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    lvwMostrarProveedores.Items.Add(item);
                }

                lvwMostrarProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;
        
        public void lvwMostrarProveedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (!grillaCreada)
            {
                // Leemos el archivo de texto y creamos la grilla
                StreamReader sr = new StreamReader("../../Resources/Carpetas de Proveedores/Datos Proveedores/datosProveedorConPuntoComa.txt");

                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dgvMostrarProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgvMostrarProveedores.Rows.Add(separarDatos);
                }

                sr.Close();

                grillaCreada = true;
            }
            else
            {
              
            }


        }

        private void dgvMostrarProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        public void dgvMostrarProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public static int pos ;
        private void dgvMostrarProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos =1+ dgvMostrarProveedores.CurrentRow.Index;
            
            modificarProveedor.lblModificarNumProveedor.Text = dgvMostrarProveedores[0, pos-1].Value.ToString();
            modificarProveedor.txtModificarEntidad.Text = dgvMostrarProveedores[1, pos].Value.ToString();
            modificarProveedor.txtModificarApertura.Text = dgvMostrarProveedores[2, pos].Value.ToString();
            modificarProveedor.txtModificarExpediente.Text = dgvMostrarProveedores[3, pos].Value.ToString();
            modificarProveedor.txtModificarJuzgado.Text = dgvMostrarProveedores[4, pos].Value.ToString();
            modificarProveedor.txtModificarJurisdiccion.Text = dgvMostrarProveedores[5, pos].Value.ToString();
            modificarProveedor.txtModificarDireccion.Text = dgvMostrarProveedores[6, pos].Value.ToString();
            modificarProveedor.txtModificarLiquidador.Text = dgvMostrarProveedores[7, pos].Value.ToString();

            this.Hide();
            modificarProveedor.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizamos los datos de la grilla
            dgvMostrarProveedores.Rows.Clear();
            dgvMostrarProveedores.Columns.Clear();

            StreamReader sr = new StreamReader("../../Resources/Carpetas de Proveedores/Datos Proveedores/datosProveedorConPuntoComa.txt");

            string leerLinea;
            string[] separarDatos;

            leerLinea = sr.ReadLine();
            separarDatos = leerLinea.Split(';');

            for (int indice = 0; indice < separarDatos.Length; indice++)
            {
                dgvMostrarProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
            }

            while (sr.EndOfStream == false)
            {
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvMostrarProveedores.Rows.Add(separarDatos);

            }

            sr.Close();

            MessageBox.Show("Grilla Actualizada");
            
        }
    }
}
