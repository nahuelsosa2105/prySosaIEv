namespace prySosaIEv
{
    partial class frmMostrarBase
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
            this.dgvBaseDeDatos = new System.Windows.Forms.DataGridView();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaseDeDatos
            // 
            this.dgvBaseDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDeDatos.Location = new System.Drawing.Point(41, 32);
            this.dgvBaseDeDatos.Name = "dgvBaseDeDatos";
            this.dgvBaseDeDatos.Size = new System.Drawing.Size(995, 367);
            this.dgvBaseDeDatos.TabIndex = 0;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(41, 431);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(120, 43);
            this.btnBuscarID.TabIndex = 1;
            this.btnBuscarID.Text = "BUSCAR POR ID";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(41, 480);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(120, 43);
            this.btnBuscarNombre.TabIndex = 2;
            this.btnBuscarNombre.Text = "BUSCAR POR NOMBRE";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.Location = new System.Drawing.Point(41, 529);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(120, 43);
            this.btnBuscarApellido.TabIndex = 3;
            this.btnBuscarApellido.Text = "BUSCAR POR APELLIDO";
            this.btnBuscarApellido.UseVisualStyleBackColor = true;
            // 
            // frmMostrarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 613);
            this.Controls.Add(this.btnBuscarApellido);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.dgvBaseDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseElClub";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDeDatos;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarApellido;
    }
}