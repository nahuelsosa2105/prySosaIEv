﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmMain_KeyDown);

        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        frmMostrarProveedores frmMostrarProveedoress = new frmMostrarProveedores();
        frmCargarProveedores frmCargarProveedoress = new frmCargarProveedores();
        public static int contProv = 0;
        public static int contCargar = 0;
        
        public void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLogs objUsuario = new clsLogs();
            frmInicioDeSesion.accion = "Mostrar Proveedores y clientes";
            objUsuario.RegistroLogInicioSesion();

            if (contProv == 0)
            {
                frmMostrarProveedoress.Activate();
                frmMostrarProveedoress.Show();
                frmMostrarProveedoress.TopMost = true;
                contProv = 1;
                frmCargarProveedoress.Hide();
                contCargar = 0;
                
    }
            else
            {
                
                contProv = 0;
            }
            
            
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLogs objUsuario = new clsLogs();
            frmInicioDeSesion.accion = "Cerrar Sesion";
            objUsuario.RegistroLogInicioSesion();

            this.Hide();
            frmMostrarProveedoress.Close();
            frmCargarProveedoress.Close();
            frmInicioDeSesion frminiciar = new frmInicioDeSesion();
            frminiciar.Show();
        }

        public void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLogs objUsuario = new clsLogs();
            frmInicioDeSesion.accion = "Cargar nuevos Proveedores o clientes";
            objUsuario.RegistroLogInicioSesion();
            if (contCargar == 0)
            {
                frmCargarProveedoress.Show();
                frmCargarProveedoress.TopMost = true;
                contCargar = 1;
                frmMostrarProveedoress.Hide() ;
                contProv = 0;

            }
            else
            {
                contCargar = 0;
            }



        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            frmMostrarProveedores frmMostrarProveedores = new frmMostrarProveedores();
            frmMostrarProveedores.Close();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
