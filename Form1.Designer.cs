namespace TareaProgramacion_Jefferson_y_Issac
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            cboCategoriasCate = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnElicate = new Button();
            btnGuardarCate = new Button();
            txtDescripcion = new TextBox();
            txtColocarelemento = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnEliminarPro = new Button();
            cboCategoriaProducto = new ComboBox();
            label11 = new Label();
            txtStok = new TextBox();
            label10 = new Label();
            txtPrecioPro = new TextBox();
            label9 = new Label();
            txtNombreProducto = new TextBox();
            label8 = new Label();
            btnEditarPro = new Button();
            btnGuardarPro = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label12 = new Label();
            txtBuscar = new TextBox();
            dgvDatos = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, -2);
            label1.Name = "label1";
            label1.Size = new Size(381, 46);
            label1.TabIndex = 0;
            label1.Text = "SISTEMAS DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 1;
            label2.Text = "CATEGORÍAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 29);
            label3.TabIndex = 2;
            label3.Text = "PRODUCTOS";
            // 
            // panel1
            // 
            panel1.Controls.Add(cboCategoriasCate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnElicate);
            panel1.Controls.Add(btnGuardarCate);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtColocarelemento);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 403);
            panel1.TabIndex = 3;
            // 
            // cboCategoriasCate
            // 
            cboCategoriasCate.FormattingEnabled = true;
            cboCategoriasCate.Items.AddRange(new object[] { "Computación", "Accesorios", "Impresión", "Redes" });
            cboCategoriasCate.Location = new Point(183, 113);
            cboCategoriasCate.Name = "cboCategoriasCate";
            cboCategoriasCate.Size = new Size(214, 28);
            cboCategoriasCate.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 178);
            label7.Name = "label7";
            label7.Size = new Size(122, 16);
            label7.TabIndex = 12;
            label7.Text = "Colocar Elemento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 235);
            label6.Name = "label6";
            label6.Size = new Size(84, 16);
            label6.TabIndex = 11;
            label6.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 186);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 115);
            label4.Name = "label4";
            label4.Size = new Size(148, 16);
            label4.TabIndex = 5;
            label4.Text = "Seleccione Categoria";
            // 
            // btnElicate
            // 
            btnElicate.Location = new Point(289, 313);
            btnElicate.Name = "btnElicate";
            btnElicate.Size = new Size(94, 29);
            btnElicate.TabIndex = 9;
            btnElicate.Text = "ELIMINAR";
            btnElicate.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCate
            // 
            btnGuardarCate.Location = new Point(92, 313);
            btnGuardarCate.Name = "btnGuardarCate";
            btnGuardarCate.Size = new Size(94, 29);
            btnGuardarCate.TabIndex = 5;
            btnGuardarCate.Text = "GUARDAR";
            btnGuardarCate.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(184, 229);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(213, 34);
            txtDescripcion.TabIndex = 8;
            // 
            // txtColocarelemento
            // 
            txtColocarelemento.Location = new Point(184, 172);
            txtColocarelemento.Multiline = true;
            txtColocarelemento.Name = "txtColocarelemento";
            txtColocarelemento.Size = new Size(213, 34);
            txtColocarelemento.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SkyBlue;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(50, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 60);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminarPro);
            panel2.Controls.Add(cboCategoriaProducto);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtStok);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPrecioPro);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtNombreProducto);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnEditarPro);
            panel2.Controls.Add(btnGuardarPro);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Location = new Point(758, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 413);
            panel2.TabIndex = 4;
            // 
            // btnEliminarPro
            // 
            btnEliminarPro.Location = new Point(274, 349);
            btnEliminarPro.Name = "btnEliminarPro";
            btnEliminarPro.Size = new Size(94, 29);
            btnEliminarPro.TabIndex = 18;
            btnEliminarPro.Text = "ELIMINAR";
            btnEliminarPro.UseVisualStyleBackColor = true;
            // 
            // cboCategoriaProducto
            // 
            cboCategoriaProducto.FormattingEnabled = true;
            cboCategoriaProducto.Items.AddRange(new object[] { "Computación", "Accesorios", "Impresión", "Redes" });
            cboCategoriaProducto.Location = new Point(156, 267);
            cboCategoriaProducto.Name = "cboCategoriaProducto";
            cboCategoriaProducto.Size = new Size(184, 28);
            cboCategoriaProducto.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(46, 257);
            label11.Name = "label11";
            label11.Size = new Size(77, 16);
            label11.TabIndex = 16;
            label11.Text = "Categoria:";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(156, 213);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(181, 27);
            txtStok.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(59, 213);
            label10.Name = "label10";
            label10.Size = new Size(46, 16);
            label10.TabIndex = 14;
            label10.Text = "Stock:";
            // 
            // txtPrecioPro
            // 
            txtPrecioPro.Location = new Point(156, 173);
            txtPrecioPro.Name = "txtPrecioPro";
            txtPrecioPro.Size = new Size(181, 27);
            txtPrecioPro.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(59, 173);
            label9.Name = "label9";
            label9.Size = new Size(51, 16);
            label9.TabIndex = 12;
            label9.Text = "Precio:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(156, 124);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(181, 27);
            txtNombreProducto.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 125);
            label8.Name = "label8";
            label8.Size = new Size(147, 16);
            label8.TabIndex = 6;
            label8.Text = "Nombre del producto";
            // 
            // btnEditarPro
            // 
            btnEditarPro.Location = new Point(156, 349);
            btnEditarPro.Name = "btnEditarPro";
            btnEditarPro.Size = new Size(94, 29);
            btnEditarPro.TabIndex = 11;
            btnEditarPro.Text = "EDITAR PRODUCTO";
            btnEditarPro.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPro
            // 
            btnGuardarPro.Location = new Point(29, 349);
            btnGuardarPro.Name = "btnGuardarPro";
            btnGuardarPro.Size = new Size(94, 29);
            btnGuardarPro.TabIndex = 10;
            btnGuardarPro.Text = "GUARDAR";
            btnGuardarPro.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.SkyBlue;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Location = new Point(39, 34);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(298, 60);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 472);
            label12.Name = "label12";
            label12.Size = new Size(112, 16);
            label12.TabIndex = 7;
            label12.Text = "Buscar Producto";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(135, 466);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(244, 30);
            txtBuscar.TabIndex = 9;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 502);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(1184, 158);
            dgvDatos.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1284, 665);
            Controls.Add(dgvDatos);
            Controls.Add(txtBuscar);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnElicate;
        private Button btnGuardarCate;
        private TextBox txtDescripcion;
        private TextBox txtColocarelemento;
        private Button btnGuardarPro;
        private Label label7;
        private TextBox txtPrecioPro;
        private Label label9;
        private TextBox txtNombreProducto;
        private Label label8;
        private Button btnEditarPro;
        private ComboBox cboCategoriaProducto;
        private Label label11;
        private TextBox txtStok;
        private Label label10;
        private ComboBox cboCategoriasCate;
        private Button btnEliminarPro;
        private Label label12;
        private TextBox txtBuscar;
        private DataGridView dgvDatos;
    }
}
