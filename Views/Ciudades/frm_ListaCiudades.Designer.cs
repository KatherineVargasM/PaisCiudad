namespace PaisCiudad.Views.Ciudades
{
    partial class frm_ListaCiudades
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
            this.components = new System.ComponentModel.Container();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new PaisCiudad.pubsDataSet();
            this.btn_NuevaCiudad = new System.Windows.Forms.Button();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.btn_EliminarCiudad = new System.Windows.Forms.Button();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesTableAdapter = new PaisCiudad.pubsDataSetTableAdapters.CiudadesTableAdapter();
            this.paisesTableAdapter = new PaisCiudad.pubsDataSetTableAdapters.PaisesTableAdapter();
            this.dgv_Ciudades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ciudades)).BeginInit();
            this.SuspendLayout();
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.pubsDataSet;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_NuevaCiudad
            // 
            this.btn_NuevaCiudad.Location = new System.Drawing.Point(87, 295);
            this.btn_NuevaCiudad.Name = "btn_NuevaCiudad";
            this.btn_NuevaCiudad.Size = new System.Drawing.Size(127, 30);
            this.btn_NuevaCiudad.TabIndex = 1;
            this.btn_NuevaCiudad.Text = "Nueva Ciudad";
            this.btn_NuevaCiudad.UseVisualStyleBackColor = true;
            this.btn_NuevaCiudad.Click += new System.EventHandler(this.btn_NuevaCiudad_Click);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lista.Location = new System.Drawing.Point(165, 31);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(187, 20);
            this.lbl_Lista.TabIndex = 2;
            this.lbl_Lista.Text = "LISTA DE CIUDADES";
            // 
            // btn_EliminarCiudad
            // 
            this.btn_EliminarCiudad.Location = new System.Drawing.Point(311, 295);
            this.btn_EliminarCiudad.Name = "btn_EliminarCiudad";
            this.btn_EliminarCiudad.Size = new System.Drawing.Size(127, 30);
            this.btn_EliminarCiudad.TabIndex = 3;
            this.btn_EliminarCiudad.Text = "Eliminar Ciudad";
            this.btn_EliminarCiudad.UseVisualStyleBackColor = true;
            this.btn_EliminarCiudad.Click += new System.EventHandler(this.btn_EliminarCiudad_Click);
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.pubsDataSet;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_Ciudades
            // 
            this.dgv_Ciudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ciudades.Location = new System.Drawing.Point(87, 73);
            this.dgv_Ciudades.Name = "dgv_Ciudades";
            this.dgv_Ciudades.Size = new System.Drawing.Size(351, 205);
            this.dgv_Ciudades.TabIndex = 5;
            this.dgv_Ciudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ciudades_CellContentClick);
            // 
            // frm_ListaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 350);
            this.Controls.Add(this.dgv_Ciudades);
            this.Controls.Add(this.btn_EliminarCiudad);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.btn_NuevaCiudad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ListaCiudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Ciudades";
            this.Load += new System.EventHandler(this.frm_ListaCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ciudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_NuevaCiudad;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Button btn_EliminarCiudad;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private pubsDataSetTableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private pubsDataSetTableAdapters.PaisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.DataGridView dgv_Ciudades;
    }
}