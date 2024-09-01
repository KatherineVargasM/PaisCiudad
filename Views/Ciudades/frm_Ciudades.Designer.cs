namespace PaisCiudad.Views.Ciudades
{
    partial class frm_Ciudades
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cmb_Pais = new System.Windows.Forms.ComboBox();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(170, 226);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(116, 32);
            this.btn_Cancelar.TabIndex = 20;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pais.Location = new System.Drawing.Point(37, 152);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(43, 20);
            this.lbl_Pais.TabIndex = 19;
            this.lbl_Pais.Text = "Pais:";
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciudad.Location = new System.Drawing.Point(37, 86);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(161, 20);
            this.lbl_Ciudad.TabIndex = 18;
            this.lbl_Ciudad.Text = "Nombre de la Ciudad:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(41, 226);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(116, 32);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cmb_Pais
            // 
            this.cmb_Pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pais.FormattingEnabled = true;
            this.cmb_Pais.Location = new System.Drawing.Point(41, 175);
            this.cmb_Pais.Name = "cmb_Pais";
            this.cmb_Pais.Size = new System.Drawing.Size(245, 28);
            this.cmb_Pais.TabIndex = 16;
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Detalle.Location = new System.Drawing.Point(41, 109);
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(245, 26);
            this.txt_Detalle.TabIndex = 15;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(114, 35);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(102, 20);
            this.lbl_Titulo.TabIndex = 14;
            this.lbl_Titulo.Text = "CIUDADES";
            // 
            // frm_Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Pais);
            this.Controls.Add(this.lbl_Ciudad);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cmb_Pais);
            this.Controls.Add(this.txt_Detalle);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Ciudades";
            this.Text = "Editar Ciudades";
            this.Load += new System.EventHandler(this.frm_Ciudades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Pais;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cmb_Pais;
        private System.Windows.Forms.TextBox txt_Detalle;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}