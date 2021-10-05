
namespace PresentacionesPermisos
{
    partial class FrmPrincipal
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
            this.btnRefacciones = new System.Windows.Forms.Button();
            this.btnTaller = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefacciones
            // 
            this.btnRefacciones.Location = new System.Drawing.Point(109, 42);
            this.btnRefacciones.Name = "btnRefacciones";
            this.btnRefacciones.Size = new System.Drawing.Size(75, 23);
            this.btnRefacciones.TabIndex = 0;
            this.btnRefacciones.Text = "Refacciones";
            this.btnRefacciones.UseVisualStyleBackColor = true;
            this.btnRefacciones.Click += new System.EventHandler(this.btnRefacciones_Click);
            // 
            // btnTaller
            // 
            this.btnTaller.Location = new System.Drawing.Point(109, 89);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(75, 23);
            this.btnTaller.TabIndex = 1;
            this.btnTaller.Text = "Taller";
            this.btnTaller.UseVisualStyleBackColor = true;
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(109, 136);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTaller);
            this.Controls.Add(this.btnRefacciones);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefacciones;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnSalir;
    }
}