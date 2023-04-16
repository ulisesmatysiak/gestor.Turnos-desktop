namespace presentacion
{
    partial class frmPanelServicios
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnElliminarServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(12, 12);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(253, 150);
            this.dgvServicios.TabIndex = 0;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(13, 226);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarServicio.TabIndex = 1;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnElliminarServicio
            // 
            this.btnElliminarServicio.Location = new System.Drawing.Point(190, 226);
            this.btnElliminarServicio.Name = "btnElliminarServicio";
            this.btnElliminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnElliminarServicio.TabIndex = 3;
            this.btnElliminarServicio.Text = "Eliminar";
            this.btnElliminarServicio.UseVisualStyleBackColor = true;
            // 
            // frmPanelServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.btnElliminarServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.dgvServicios);
            this.MaximizeBox = false;
            this.Name = "frmPanelServicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.frmPanelServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnElliminarServicio;
    }
}