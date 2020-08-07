namespace bancoPrestamos
{
    partial class Form1
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
            this.txt_error = new System.Windows.Forms.Button();
            this.txt_Correcto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numerocuenta = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.mov = new System.Windows.Forms.Button();
            this.movimientos = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.reporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_error
            // 
            this.txt_error.Location = new System.Drawing.Point(121, 96);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(75, 23);
            this.txt_error.TabIndex = 2;
            this.txt_error.Text = "Error";
            this.txt_error.UseVisualStyleBackColor = true;
            this.txt_error.Click += new System.EventHandler(this.txt_error_Click);
            // 
            // txt_Correcto
            // 
            this.txt_Correcto.Location = new System.Drawing.Point(12, 96);
            this.txt_Correcto.Name = "txt_Correcto";
            this.txt_Correcto.Size = new System.Drawing.Size(75, 23);
            this.txt_Correcto.TabIndex = 3;
            this.txt_Correcto.Text = "Correcto";
            this.txt_Correcto.UseVisualStyleBackColor = true;
            this.txt_Correcto.Click += new System.EventHandler(this.txt_Correcto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(388, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "monto a debitar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "numero de cuenta 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "numero de cuenta 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "numero de cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(948, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "monto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numerocuenta
            // 
            this.numerocuenta.Location = new System.Drawing.Point(1038, 17);
            this.numerocuenta.Name = "numerocuenta";
            this.numerocuenta.Size = new System.Drawing.Size(100, 22);
            this.numerocuenta.TabIndex = 14;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(1038, 97);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(100, 22);
            this.monto.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(868, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 189);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(1224, 55);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 18;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1224, 11);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 19;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(1224, 96);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 20;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(1038, 61);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 21;
            this.nombre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "usuario";
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(1224, 135);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 23;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // mov
            // 
            this.mov.Location = new System.Drawing.Point(1195, 429);
            this.mov.Name = "mov";
            this.mov.Size = new System.Drawing.Size(104, 23);
            this.mov.TabIndex = 24;
            this.mov.Text = "Movimientos";
            this.mov.UseVisualStyleBackColor = true;
            this.mov.Click += new System.EventHandler(this.button1_Click);
            // 
            // movimientos
            // 
            this.movimientos.Location = new System.Drawing.Point(1053, 430);
            this.movimientos.Name = "movimientos";
            this.movimientos.Size = new System.Drawing.Size(100, 22);
            this.movimientos.TabIndex = 25;
            this.movimientos.TextChanged += new System.EventHandler(this.moviminetos_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(868, 487);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(431, 150);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(388, 58);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 22);
            this.descripcion.TabIndex = 28;
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // reporte
            // 
            this.reporte.Location = new System.Drawing.Point(1327, 428);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(75, 23);
            this.reporte.TabIndex = 29;
            this.reporte.Text = "Reporte";
            this.reporte.UseVisualStyleBackColor = true;
            this.reporte.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bancoPrestamos.Properties.Resources.banco;
            this.pictureBox1.Location = new System.Drawing.Point(1364, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1703, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reporte);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.movimientos);
            this.Controls.Add(this.mov);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.numerocuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_Correcto);
            this.Controls.Add(this.txt_error);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txt_error;
        private System.Windows.Forms.Button txt_Correcto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numerocuenta;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button mov;
        private System.Windows.Forms.TextBox movimientos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Button reporte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

