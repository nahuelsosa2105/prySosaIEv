﻿namespace prySosaIEv
{
    partial class frmMostrarProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarProveedores));
            this.scMostrarProveedores = new System.Windows.Forms.SplitContainer();
            this.tvwMostrarProveedores = new System.Windows.Forms.TreeView();
            this.lvwMostrarProveedores = new System.Windows.Forms.ListView();
            this.imlProveedores = new System.Windows.Forms.ImageList(this.components);
            this.clmhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhUlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvMostrarProveedores = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJuzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLiqRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMostrarProveedores)).BeginInit();
            this.scMostrarProveedores.Panel1.SuspendLayout();
            this.scMostrarProveedores.Panel2.SuspendLayout();
            this.scMostrarProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // scMostrarProveedores
            // 
            this.scMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMostrarProveedores.Location = new System.Drawing.Point(0, 0);
            this.scMostrarProveedores.Name = "scMostrarProveedores";
            // 
            // scMostrarProveedores.Panel1
            // 
            this.scMostrarProveedores.Panel1.Controls.Add(this.tvwMostrarProveedores);
            // 
            // scMostrarProveedores.Panel2
            // 
            this.scMostrarProveedores.Panel2.Controls.Add(this.dgvMostrarProveedores);
            this.scMostrarProveedores.Panel2.Controls.Add(this.lvwMostrarProveedores);
            this.scMostrarProveedores.Size = new System.Drawing.Size(1090, 613);
            this.scMostrarProveedores.SplitterDistance = 241;
            this.scMostrarProveedores.TabIndex = 0;
            // 
            // tvwMostrarProveedores
            // 
            this.tvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMostrarProveedores.ImageIndex = 0;
            this.tvwMostrarProveedores.ImageList = this.imlProveedores;
            this.tvwMostrarProveedores.Location = new System.Drawing.Point(0, 0);
            this.tvwMostrarProveedores.Name = "tvwMostrarProveedores";
            this.tvwMostrarProveedores.SelectedImageIndex = 0;
            this.tvwMostrarProveedores.Size = new System.Drawing.Size(241, 613);
            this.tvwMostrarProveedores.TabIndex = 0;
            this.tvwMostrarProveedores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMostrarProveedores_NodeMouseClick);
            // 
            // lvwMostrarProveedores
            // 
            this.lvwMostrarProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhName,
            this.clmhTipo,
            this.clmhUlt});
            this.lvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostrarProveedores.HideSelection = false;
            this.lvwMostrarProveedores.LargeImageList = this.imlProveedores;
            this.lvwMostrarProveedores.Location = new System.Drawing.Point(0, 0);
            this.lvwMostrarProveedores.Name = "lvwMostrarProveedores";
            this.lvwMostrarProveedores.Size = new System.Drawing.Size(845, 303);
            this.lvwMostrarProveedores.SmallImageList = this.imlProveedores;
            this.lvwMostrarProveedores.TabIndex = 0;
            this.lvwMostrarProveedores.UseCompatibleStateImageBehavior = false;
            this.lvwMostrarProveedores.View = System.Windows.Forms.View.Details;
            // 
            // imlProveedores
            // 
            this.imlProveedores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlProveedores.ImageStream")));
            this.imlProveedores.TransparentColor = System.Drawing.Color.Transparent;
            this.imlProveedores.Images.SetKeyName(0, "ImagenCarpeta.png");
            this.imlProveedores.Images.SetKeyName(1, "ImagenARchivo.png");
            // 
            // clmhName
            // 
            this.clmhName.Text = "Nombre";
            // 
            // clmhTipo
            // 
            this.clmhTipo.Text = "Tipo";
            // 
            // clmhUlt
            // 
            this.clmhUlt.Text = "Ult. Modificacion";
            this.clmhUlt.Width = 98;
            // 
            // dgvMostrarProveedores
            // 
            this.dgvMostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnEntidad,
            this.ColumnApertura,
            this.ColumnNumExp,
            this.ColumnJuzgado,
            this.ColumnJurisdiccion,
            this.ColumnDirección,
            this.ColumnLiqRes});
            this.dgvMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarProveedores.Location = new System.Drawing.Point(0, 309);
            this.dgvMostrarProveedores.Name = "dgvMostrarProveedores";
            this.dgvMostrarProveedores.Size = new System.Drawing.Size(845, 304);
            this.dgvMostrarProveedores.TabIndex = 1;
            // 
            // ColumnNum
            // 
            this.ColumnNum.HeaderText = "N°";
            this.ColumnNum.Name = "ColumnNum";
            // 
            // ColumnEntidad
            // 
            this.ColumnEntidad.HeaderText = "Entidad";
            this.ColumnEntidad.Name = "ColumnEntidad";
            // 
            // ColumnApertura
            // 
            this.ColumnApertura.HeaderText = "Apertura";
            this.ColumnApertura.Name = "ColumnApertura";
            // 
            // ColumnNumExp
            // 
            this.ColumnNumExp.HeaderText = "N° Expediente";
            this.ColumnNumExp.Name = "ColumnNumExp";
            // 
            // ColumnJuzgado
            // 
            this.ColumnJuzgado.HeaderText = "Juzgado";
            this.ColumnJuzgado.Name = "ColumnJuzgado";
            // 
            // ColumnJurisdiccion
            // 
            this.ColumnJurisdiccion.HeaderText = "Jurisdicción";
            this.ColumnJurisdiccion.Name = "ColumnJurisdiccion";
            // 
            // ColumnDirección
            // 
            this.ColumnDirección.HeaderText = "Dirección";
            this.ColumnDirección.Name = "ColumnDirección";
            // 
            // ColumnLiqRes
            // 
            this.ColumnLiqRes.HeaderText = "Liq Responsable";
            this.ColumnLiqRes.Name = "ColumnLiqRes";
            // 
            // frmMostrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1090, 613);
            this.Controls.Add(this.scMostrarProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarProveedores";
            this.Load += new System.EventHandler(this.frmMostrarProveedores_Load);
            this.scMostrarProveedores.Panel1.ResumeLayout(false);
            this.scMostrarProveedores.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMostrarProveedores)).EndInit();
            this.scMostrarProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMostrarProveedores;
        private System.Windows.Forms.ImageList imlProveedores;
        private System.Windows.Forms.ColumnHeader clmhName;
        private System.Windows.Forms.ColumnHeader clmhTipo;
        private System.Windows.Forms.ColumnHeader clmhUlt;
        public System.Windows.Forms.ListView lvwMostrarProveedores;
        public System.Windows.Forms.TreeView tvwMostrarProveedores;
        private System.Windows.Forms.DataGridView dgvMostrarProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJuzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJurisdiccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLiqRes;
    }
}