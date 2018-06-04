namespace RegistroExamen.UI.Consultas
{
    partial class Consultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "ID Articulo",
            "Descripcion",
            "Precio",
            "Existencia",
            "Cantidad Cotizada"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(57, 18);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Filtro_comboBox.TabIndex = 2;
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Location = new System.Drawing.Point(274, 18);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(187, 20);
            this.Criterio_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criterio";
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(11, 61);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.Size = new System.Drawing.Size(776, 368);
            this.Consulta_dataGridView.TabIndex = 5;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Image = global::RegistroExamen.Properties.Resources.icons8_Search_Property_32;
            this.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Consultar.Location = new System.Drawing.Point(511, 12);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(94, 39);
            this.btn_Consultar.TabIndex = 6;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 441);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtro_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Button btn_Consultar;
    }
}