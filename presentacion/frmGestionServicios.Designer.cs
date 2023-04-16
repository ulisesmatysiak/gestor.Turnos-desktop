namespace presentacion
{
    partial class frmGestionServicios
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
            this.lblCorte = new System.Windows.Forms.Label();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCorte
            // 
            this.lblCorte.AutoSize = true;
            this.lblCorte.Location = new System.Drawing.Point(69, 69);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(35, 13);
            this.lblCorte.TabIndex = 0;
            this.lblCorte.Text = "Corte:";
            // 
            // txtServicios
            // 
            this.txtServicios.Location = new System.Drawing.Point(137, 65);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(100, 20);
            this.txtServicios.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(69, 119);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmGestionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 178);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtServicios);
            this.Controls.Add(this.lblCorte);
            this.MaximizeBox = false;
            this.Name = "frmGestionServicios";
            this.Text = "Gestión de servicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.TextBox txtServicios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}