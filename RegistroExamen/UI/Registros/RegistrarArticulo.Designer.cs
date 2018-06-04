namespace RegistroExamen.UI.Registros
{
    partial class RegistrarArticulo
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
            System.Windows.Forms.Label articuloIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label cantCotizadaLabel;
            System.Windows.Forms.Label fechaVencimientoLabel;
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.PrecioUpDown = new System.Windows.Forms.NumericUpDown();
            this.existenciaUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantCotizadaUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArticuloUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            articuloIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            cantCotizadaLabel = new System.Windows.Forms.Label();
            fechaVencimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantCotizadaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // articuloIdLabel
            // 
            articuloIdLabel.AutoSize = true;
            articuloIdLabel.Location = new System.Drawing.Point(66, 37);
            articuloIdLabel.Name = "articuloIdLabel";
            articuloIdLabel.Size = new System.Drawing.Size(57, 13);
            articuloIdLabel.TabIndex = 1;
            articuloIdLabel.Text = "Articulo Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(66, 75);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(92, 135);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 4;
            precioLabel.Text = "Precio:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(75, 169);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(57, 13);
            existenciaLabel.TabIndex = 6;
            existenciaLabel.Text = "existencia:";
            // 
            // cantCotizadaLabel
            // 
            cantCotizadaLabel.AutoSize = true;
            cantCotizadaLabel.Location = new System.Drawing.Point(56, 209);
            cantCotizadaLabel.Name = "cantCotizadaLabel";
            cantCotizadaLabel.Size = new System.Drawing.Size(76, 13);
            cantCotizadaLabel.TabIndex = 8;
            cantCotizadaLabel.Text = "Cant Cotizada:";
            // 
            // fechaVencimientoLabel
            // 
            fechaVencimientoLabel.AutoSize = true;
            fechaVencimientoLabel.Location = new System.Drawing.Point(31, 247);
            fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            fechaVencimientoLabel.Size = new System.Drawing.Size(101, 13);
            fechaVencimientoLabel.TabIndex = 10;
            fechaVencimientoLabel.Text = "Fecha Vencimiento:";
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(138, 72);
            this.Descripcion_textBox.Multiline = true;
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(240, 50);
            this.Descripcion_textBox.TabIndex = 4;
            // 
            // PrecioUpDown
            // 
            this.PrecioUpDown.Location = new System.Drawing.Point(138, 133);
            this.PrecioUpDown.Name = "PrecioUpDown";
            this.PrecioUpDown.Size = new System.Drawing.Size(141, 20);
            this.PrecioUpDown.TabIndex = 5;
            // 
            // existenciaUpDown
            // 
            this.existenciaUpDown.Location = new System.Drawing.Point(138, 169);
            this.existenciaUpDown.Name = "existenciaUpDown";
            this.existenciaUpDown.Size = new System.Drawing.Size(141, 20);
            this.existenciaUpDown.TabIndex = 7;
            // 
            // CantCotizadaUpDown
            // 
            this.CantCotizadaUpDown.Location = new System.Drawing.Point(138, 207);
            this.CantCotizadaUpDown.Name = "CantCotizadaUpDown";
            this.CantCotizadaUpDown.Size = new System.Drawing.Size(82, 20);
            this.CantCotizadaUpDown.TabIndex = 9;
            // 
            // fechaVencimientoDateTimePicker
            // 
            this.fechaVencimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.articulosBindingSource, "FechaVencimiento", true));
            this.fechaVencimientoDateTimePicker.Location = new System.Drawing.Point(138, 241);
            this.fechaVencimientoDateTimePicker.Name = "fechaVencimientoDateTimePicker";
            this.fechaVencimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaVencimientoDateTimePicker.TabIndex = 11;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataSource = typeof(RegistroExamen.Entidades.Articulos);
            // 
            // ArticuloUpDown
            // 
            this.ArticuloUpDown.Location = new System.Drawing.Point(138, 35);
            this.ArticuloUpDown.Name = "ArticuloUpDown";
            this.ArticuloUpDown.Size = new System.Drawing.Size(68, 20);
            this.ArticuloUpDown.TabIndex = 12;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::RegistroExamen.Properties.Resources.icons8_Search_16;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(229, 32);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = global::RegistroExamen.Properties.Resources.icons8_New_Copy_32;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Nuevo.Location = new System.Drawing.Point(34, 300);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(129, 50);
            this.btn_Nuevo.TabIndex = 14;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::RegistroExamen.Properties.Resources.icons8_Save_Close_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(194, 300);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(129, 50);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::RegistroExamen.Properties.Resources.icons8_Delete_Document_32;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Eliminar.Location = new System.Drawing.Point(358, 300);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(129, 50);
            this.btn_Eliminar.TabIndex = 16;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // RegistrarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 377);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.ArticuloUpDown);
            this.Controls.Add(fechaVencimientoLabel);
            this.Controls.Add(this.fechaVencimientoDateTimePicker);
            this.Controls.Add(this.CantCotizadaUpDown);
            this.Controls.Add(cantCotizadaLabel);
            this.Controls.Add(this.existenciaUpDown);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.PrecioUpDown);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(articuloIdLabel);
            this.Name = "RegistrarArticulo";
            this.Text = "RegistrarArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantCotizadaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource articulosBindingSource;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.NumericUpDown PrecioUpDown;
        private System.Windows.Forms.NumericUpDown existenciaUpDown;
        private System.Windows.Forms.NumericUpDown CantCotizadaUpDown;
        private System.Windows.Forms.DateTimePicker fechaVencimientoDateTimePicker;
        private System.Windows.Forms.NumericUpDown ArticuloUpDown;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}