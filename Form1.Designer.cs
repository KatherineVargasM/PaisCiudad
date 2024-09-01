namespace PaisCiudad
{
    partial class Ingreso
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
            this.lab_Bienvenida = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Bienvenida
            // 
            this.lab_Bienvenida.AutoSize = true;
            this.lab_Bienvenida.Font = new System.Drawing.Font("DejaVu Sans Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Bienvenida.Location = new System.Drawing.Point(81, 44);
            this.lab_Bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Bienvenida.Name = "lab_Bienvenida";
            this.lab_Bienvenida.Size = new System.Drawing.Size(251, 19);
            this.lab_Bienvenida.TabIndex = 0;
            this.lab_Bienvenida.Text = "Bienvenido al Sistema:";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(141, 92);
            this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(124, 40);
            this.btn_Ingresar.TabIndex = 1;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 168);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lab_Bienvenida);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingreso";
            this.Text = "Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Bienvenida;
        private System.Windows.Forms.Button btn_Ingresar;
    }
}

