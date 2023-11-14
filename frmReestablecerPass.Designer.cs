namespace prySosaIEv
{
    partial class frmReestablecerPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReestablecerPass));
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.txtRepContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.ForeColor = System.Drawing.Color.White;
            this.btnReestablecer.Location = new System.Drawing.Point(43, 482);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(432, 40);
            this.btnReestablecer.TabIndex = 3;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = false;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // txtRepContraseña
            // 
            this.txtRepContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtRepContraseña.Location = new System.Drawing.Point(212, 404);
            this.txtRepContraseña.Name = "txtRepContraseña";
            this.txtRepContraseña.PasswordChar = '*';
            this.txtRepContraseña.Size = new System.Drawing.Size(263, 26);
            this.txtRepContraseña.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(32, 407);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(152, 20);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Repetir Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(212, 346);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(263, 26);
            this.txtContraseña.TabIndex = 1;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(39, 349);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(145, 20);
            this.lblNombreDeUsuario.TabIndex = 6;
            this.lblNombreDeUsuario.Text = "Nueva Contraseña:";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = global::prySosaIEv.Properties.Resources.foto_Broker_seguros;
            this.pctLogo.Image = global::prySosaIEv.Properties.Resources.foto_Broker_seguros;
            this.pctLogo.Location = new System.Drawing.Point(85, 35);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(355, 194);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 9;
            this.pctLogo.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(212, 288);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(263, 26);
            this.txtusuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(44, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(431, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmReestablecerPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(516, 650);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.txtRepContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReestablecerPass";
            this.Text = "Reestablecer Contraseña";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReestablecerPass_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReestablecer;
        public System.Windows.Forms.TextBox txtRepContraseña;
        private System.Windows.Forms.Label lblContraseña;
        public System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.PictureBox pctLogo;
        public System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}