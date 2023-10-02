namespace prySosaIEv
{
    partial class frmLogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbrLogo = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.tmrLogo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbrLogo
            // 
            this.pbrLogo.Location = new System.Drawing.Point(91, 536);
            this.pbrLogo.Name = "pbrLogo";
            this.pbrLogo.Size = new System.Drawing.Size(351, 28);
            this.pbrLogo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrLogo.TabIndex = 1;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Location = new System.Drawing.Point(216, 604);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(100, 29);
            this.lblPorcentaje.TabIndex = 2;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.Black;
            this.lblCargando.Location = new System.Drawing.Point(181, 63);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(161, 25);
            this.lblCargando.TabIndex = 3;
            this.lblCargando.Text = "CARGANDO...";
            // 
            // tmrLogo
            // 
            this.tmrLogo.Enabled = true;
            this.tmrLogo.Interval = 300;
            this.tmrLogo.Tick += new System.EventHandler(this.tmrLogo_Tick);
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::prySosaIEv.Properties.Resources.foto_Broker_seguros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(532, 689);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbrLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrLogo;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Timer tmrLogo;
    }
}

