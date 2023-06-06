namespace presentacion
{
    partial class frmPanel
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
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.Black;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnos.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.White;
            this.btnTurnos.Location = new System.Drawing.Point(254, 184);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(199, 80);
            this.btnTurnos.TabIndex = 0;
            this.btnTurnos.Text = "Turnos \r\n";
            this.btnTurnos.UseVisualStyleBackColor = false;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.Black;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicios.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Location = new System.Drawing.Point(562, 339);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(142, 51);
            this.btnServicios.TabIndex = 1;
            this.btnServicios.Text = "Servicios ";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.Color.Black;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutores.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.Location = new System.Drawing.Point(34, 339);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(142, 51);
            this.btnAutores.TabIndex = 2;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "SANTA ANA BARBER SHOP";
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Label label1;
    }
}