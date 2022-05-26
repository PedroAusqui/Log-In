namespace LogIn1
{
    partial class Form2
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
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.lblDatosCuenta = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Location = new System.Drawing.Point(12, 9);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCuenta.TabIndex = 0;
            this.lblNombreCuenta.Text = "Nombre";
            // 
            // lblDatosCuenta
            // 
            this.lblDatosCuenta.AutoSize = true;
            this.lblDatosCuenta.Location = new System.Drawing.Point(32, 80);
            this.lblDatosCuenta.Name = "lblDatosCuenta";
            this.lblDatosCuenta.Size = new System.Drawing.Size(35, 13);
            this.lblDatosCuenta.TabIndex = 1;
            this.lblDatosCuenta.Text = "Datos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(236, 256);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 339);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDatosCuenta);
            this.Controls.Add(this.lblNombreCuenta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.Label lblDatosCuenta;
        private System.Windows.Forms.Button btnCerrar;
    }
}