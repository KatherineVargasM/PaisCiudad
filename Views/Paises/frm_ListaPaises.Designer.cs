namespace PaisCiudad.Views.Paises
{
    partial class frm_ListaPaises
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
            this.btn_EliminarPais = new System.Windows.Forms.Button();
            this.btn_NuevoPais = new System.Windows.Forms.Button();
            this.dgv_Paises = new System.Windows.Forms.DataGridView();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new PaisCiudad.pubsDataSet();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.paisesTableAdapter = new PaisCiudad.pubsDataSetTableAdapters.PaisesTableAdapter();
            this.IdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarPais
            // 
            this.btn_EliminarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarPais.Location = new System.Drawing.Point(264, 325);
            this.btn_EliminarPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_EliminarPais.Name = "btn_EliminarPais";
            this.btn_EliminarPais.Size = new System.Drawing.Size(127, 31);
            this.btn_EliminarPais.TabIndex = 5;
            this.btn_EliminarPais.Text = "Eliminar Pais";
            this.btn_EliminarPais.UseVisualStyleBackColor = true;
            this.btn_EliminarPais.Click += new System.EventHandler(this.btn_EliminarPais_Click);
            // 
            // btn_NuevoPais
            // 
            this.btn_NuevoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoPais.Location = new System.Drawing.Point(116, 326);
            this.btn_NuevoPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_NuevoPais.Name = "btn_NuevoPais";
            this.btn_NuevoPais.Size = new System.Drawing.Size(127, 30);
            this.btn_NuevoPais.TabIndex = 4;
            this.btn_NuevoPais.Text = "Nuevo Pais";
            this.btn_NuevoPais.UseVisualStyleBackColor = true;
            this.btn_NuevoPais.Click += new System.EventHandler(this.btn_NuevoPais_Click);
            // 
            // dgv_Paises
            // 
            this.dgv_Paises.AutoGenerateColumns = false;
            this.dgv_Paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Paises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPais,
            this.Detalle,
            this.Editar});
            this.dgv_Paises.DataSource = this.paisesBindingSource;
            this.dgv_Paises.Location = new System.Drawing.Point(116, 67);
            this.dgv_Paises.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Paises.Name = "dgv_Paises";
            this.dgv_Paises.Size = new System.Drawing.Size(275, 249);
            this.dgv_Paises.TabIndex = 7;
            this.dgv_Paises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Paises_CellContentClick);
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
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lista.Location = new System.Drawing.Point(164, 33);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(159, 20);
            this.lbl_Lista.TabIndex = 8;
            this.lbl_Lista.Text = "LISTA DE PAISES";
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // IdPais
            // 
            this.IdPais.DataPropertyName = "IdPais";
            this.IdPais.HeaderText = "IdPais";
            this.IdPais.Name = "IdPais";
            this.IdPais.ReadOnly = true;
            this.IdPais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdPais.Visible = false;
            // 
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Pais";
            this.Detalle.Name = "Detalle";
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "IdPais";
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // frm_ListaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.dgv_Paises);
            this.Controls.Add(this.btn_EliminarPais);
            this.Controls.Add(this.btn_NuevoPais);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ListaPaises";
            this.Text = "Lista de Paises";
            this.Load += new System.EventHandler(this.frm_ListaPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EliminarPais;
        private System.Windows.Forms.Button btn_NuevoPais;
        private System.Windows.Forms.DataGridView dgv_Paises;
        private System.Windows.Forms.Label lbl_Lista;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private pubsDataSetTableAdapters.PaisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}