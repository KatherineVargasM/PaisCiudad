namespace PaisCiudad.Views.Usuarios
{
    partial class frm_Usuarios
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_usuarios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cmb_roles = new System.Windows.Forms.ComboBox();
            this.txt_repita = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(188, 370);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(141, 35);
            this.btn_Eliminar.TabIndex = 46;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(41, 370);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(139, 35);
            this.btn_Modificar.TabIndex = 45;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Lista de Usuarios:";
            // 
            // lst_usuarios
            // 
            this.lst_usuarios.FormattingEnabled = true;
            this.lst_usuarios.ItemHeight = 20;
            this.lst_usuarios.Location = new System.Drawing.Point(348, 97);
            this.lst_usuarios.Name = "lst_usuarios";
            this.lst_usuarios.Size = new System.Drawing.Size(284, 204);
            this.lst_usuarios.TabIndex = 43;
            this.lst_usuarios.DoubleClick += new System.EventHandler(this.lst_usuarios_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Repita la Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(113, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(143, 31);
            this.lbl_titulo.TabIndex = 38;
            this.lbl_titulo.Text = "USUARIOS";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(188, 325);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 35);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(41, 325);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(139, 35);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cmb_roles
            // 
            this.cmb_roles.FormattingEnabled = true;
            this.cmb_roles.Items.AddRange(new object[] {
            "Seleccione una opción",
            "Admin",
            "Guardia",
            "Financiero",
            "Bodega"});
            this.cmb_roles.Location = new System.Drawing.Point(44, 276);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.Size = new System.Drawing.Size(285, 28);
            this.cmb_roles.TabIndex = 35;
            // 
            // txt_repita
            // 
            this.txt_repita.Location = new System.Drawing.Point(45, 221);
            this.txt_repita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_repita.Name = "txt_repita";
            this.txt_repita.Size = new System.Drawing.Size(284, 26);
            this.txt_repita.TabIndex = 34;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(45, 157);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(284, 26);
            this.txt_contrasenia.TabIndex = 33;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(45, 97);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(284, 26);
            this.txt_nombre.TabIndex = 32;
            // 
            // frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 431);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_usuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_roles);
            this.Controls.Add(this.txt_repita);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frm_Usuarios_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_usuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cmb_roles;
        private System.Windows.Forms.TextBox txt_repita;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}