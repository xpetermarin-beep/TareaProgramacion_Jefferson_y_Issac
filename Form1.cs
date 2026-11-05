using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;



namespace TareaProgramacion_Jefferson_y_Issac
{
    public partial class Form1 : Form
    {
        ConexionDb conexion = new ConexionDb();

        int idCatSeleccionado = 0;
        int idProdSeleccionado = 0;


        public Form1()
        {
            InitializeComponent();





            CargarCategorias();
            MostrarProductos();                       //Componentes
            ConectarEventos();


        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void ConectarEventos()
        {

            btnGuardarCate.Click += BtnGuardarCat_Click;
            btnElicate.Click += BtnEliminarCat_Click;


            btnGuardarPro.Click += BtnGuardarProd_Click;
            btnEditarPro.Click += btnEditarPro_Click;
            btnEliminarPro.Click += BtnEliminarCat_Click;


            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            dgvDatos.CellClick += DgvDatos_CellClick;
        }


        void CargarCategorias()
        {
            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    string sql = "SELECT IdCategoria, Nombre FROM Categorias ORDER BY Nombre";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);


                    DataRow filaNula = dt.NewRow();
                    filaNula["IdCategoria"] = 0;
                    filaNula["Nombre"] = "-- Seleccione --";
                    dt.Rows.InsertAt(filaNula, 0);


                    cboCategoriasCate.DisplayMember = "Nombre";
                    cboCategoriasCate.ValueMember = "IdCategoria";
                    cboCategoriasCate.DataSource = dt.Copy();


                    cboCategoriaProducto.DisplayMember = "Nombre";
                    cboCategoriaProducto.ValueMember = "IdCategoria";
                    cboCategoriaProducto.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void MostrarProductos(string buscar = "")
        {
            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    string sql = @"SELECT p.IdProducto, p.Nombre, p.Precio, p.Stock, 
                                          p.FechaRegistro, c.Nombre as Categoria,
                                          (p.Precio * p.Stock) as ValorInventario
                                   FROM Productos p
                                   INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria";

                    if (!string.IsNullOrEmpty(buscar))
                        sql += " WHERE p.Nombre LIKE @Buscar";

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    if (!string.IsNullOrEmpty(buscar))
                        cmd.Parameters.AddWithValue("@Buscar", "%" + buscar + "%");

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);                                  //Por que esta verde?
                    dgvDatos.DataSource = dt;


                    dgvDatos.Columns["IdProducto"].HeaderText = "ID";
                    dgvDatos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                    dgvDatos.Columns["Precio"].HeaderText = "Precio";
                    dgvDatos.Columns["Stock"].HeaderText = "Stock";
                    dgvDatos.Columns["FechaRegistro"].HeaderText = "Fecha de Registro";
                    dgvDatos.Columns["Categoria"].HeaderText = "Categoría";
                    dgvDatos.Columns["ValorInventario"].HeaderText = "Valor del Inventario";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarCamposCat()
        {

            txtDescripcion.Clear();
            cboCategoriasCate.SelectedIndex = 0;
            idCatSeleccionado = 0;
        }

        void LimpiarCamposProd()
        {
            txtNombreProducto.Clear();
            txtPrecioPro.Clear();
            txtStok.Clear();
            cboCategoriaProducto.SelectedIndex = 0;
            idProdSeleccionado = 0;
        }


        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];
                idProdSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                txtNombreProducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecioPro.Text = fila.Cells["Precio"].Value.ToString();
                txtStok.Text = fila.Cells["Stock"].Value.ToString();


                string nombreCat = fila.Cells["Categoria"].Value.ToString();
                foreach (DataRowView item in cboCategoriaProducto.Items)
                {
                    if (item["Nombre"].ToString() == nombreCat)
                    {
                        cboCategoriaProducto.SelectedValue = item["IdCategoria"];
                        break;
                    }
                }
            }
        }


        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarProductos(txtBuscar.Text);
        }


        private void BtnGuardarCat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCatNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    string sql;


                    if (idCatSeleccionado == 0)
                    {
                        sql = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
                    }
                    else
                    {
                        sql = "UPDATE Categorias SET Nombre=@Nombre, Descripcion=@Descripcion " +
                              "WHERE IdCategoria=@Id";
                    }

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@Nombre", txtCatNombre.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                    if (idCatSeleccionado != 0)
                        cmd.Parameters.AddWithValue("@Id", idCatSeleccionado);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(idCatSeleccionado == 0
                        ? " Categoría guardada correctamente"
                        : " Categoría actualizada correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCamposCat();
                    CargarCategorias();
                    MostrarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEliminarCat_Click(object sender, EventArgs e)
        {
            if (cboCategoriasCate.SelectedValue == null ||
                Convert.ToInt32(cboCategoriasCate.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione una categoría de la lista", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(cboCategoriasCate.SelectedValue);

            if (MessageBox.Show("¿Está seguro de eliminar esta categoría?\n" +
                                "Se eliminarán también todos sus productos.",
                                "Confirmar Eliminación",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection cn = conexion.ObtenerConexion())
                    {
                        string sql = "DELETE FROM Categorias WHERE IdCategoria=@Id";
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show(" Categoría eliminada correctamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCamposCat();
                        CargarCategorias();
                        MostrarProductos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnGuardarProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioPro.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a cero", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStok.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número mayor o igual a cero", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboCategoriaProducto.SelectedValue == null ||
                Convert.ToInt32(cboCategoriaProducto.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione una categoría", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategoria = Convert.ToInt32(cboCategoriaProducto.SelectedValue);

            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    string sql = @"INSERT INTO Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria)
                                   VALUES (@Nombre, @Precio, @Stock, @Fecha, @IdCat)";

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IdCat", idCategoria);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(" Producto guardado correctamente", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCamposProd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarPro_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
//CREATE DATABASE GestionProductosDB;





//USE GestionProductosDB;


//Tabla: Categorías
//CREATE TABLE Categorias(
    //IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    //Nombre VARCHAR(50) NOT NULL,
    //Descripcion VARCHAR(200) NOT NULL
//);


// Tabla: Productos
//CREATE TABLE Productos(
    //IdProducto INT PRIMARY KEY IDENTITY(1,1),
    //Nombre VARCHAR(100) NOT NULL,
    //Precio DECIMAL(10,2) NOT NULL,
    //Stock INT NOT NULL,
    //FechaRegistro DATETIME NOT NULL,
    //IdCategoria INT NOT NULL,
    //FOREIGN KEY (IdCategoria) REFERENCES Categorias(IdCategoria) ON DELETE CASCADE
//);


//Datos de prueba
//INSERT INTO Categorias (Nombre, Descripcion) VALUES
//('Computación', 'Equipos y accesorios de cómputo'),
//('Accesorios', 'Periféricos y accesorios diversos'),
//('Impresión', 'Impresoras y suministros'),
//('Redes', 'Cableado y equipos de red');
