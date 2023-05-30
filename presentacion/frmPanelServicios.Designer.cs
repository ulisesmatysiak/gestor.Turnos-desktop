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
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(41, 32);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(292, 150);
            this.dgvServicios.TabIndex = 0;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarServicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarServicio.Location = new System.Drawing.Point(41, 218);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarServicio.TabIndex = 1;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnElliminarServicio
            // 
            this.btnElliminarServicio.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnElliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElliminarServicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnElliminarServicio.Location = new System.Drawing.Point(258, 218);
            this.btnElliminarServicio.Name = "btnElliminarServicio";
            this.btnElliminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnElliminarServicio.TabIndex = 3;
            this.btnElliminarServicio.Text = "Eliminar";
            this.btnElliminarServicio.UseVisualStyleBackColor = false;
            this.btnElliminarServicio.Click += new System.EventHandler(this.btnElliminarServicio_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModificar.Location = new System.Drawing.Point(154, 218);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // frmPanelServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(360, 260);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnElliminarServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.dgvServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button btnModificar;
    }
}