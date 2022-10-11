using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewWareSoft.Negocio.ABM
{
    public partial class ABMProductos : Form
    {
        public ABMProductos()
        {
            InitializeComponent();
            CargarGrillaProductos();
        }

        //---------------------------------------INSERTAR PRODUCTOS--------------------------------------------------------------
        private bool InsertarProducto(string denominacion, string descripcion, string fechaFin)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO PRODUCTOS (denominacion, descripcion, fecha_fin_desarrollo ) VALUES (@denomin, @descrip, @fechaFinDes)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denomin", denominacion);
                cmd.Parameters.AddWithValue("@descrip", descripcion);
                cmd.Parameters.AddWithValue("@fechaFinDes", fechaFin);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        //---------------------------------------MODIFICAR PRODUCTOS--------------------------------------------------------------
        private void ModificarProducto()
        {
            if (txtDenominacion.Text.Equals("") || txtDescripcion.Text.Equals("") || mskFechaFin.Text.Equals(""))
            {
                MessageBox.Show("Faltan completar datos");
                txtDenominacion.Focus();
            }
            else
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);

                try
                {

                    SqlCommand cmd = new SqlCommand();

                    string consulta = "UPDATE PRODUCTOS SET denominacion = @denomin, descripcion = @descrip, fecha_fin_desarrollo = @FechaFinDes WHERE codigo = @CodProd";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CodProd", txtIdProducto.Text);
                    cmd.Parameters.AddWithValue("@denomin", txtDenominacion.Text);
                    cmd.Parameters.AddWithValue("@descrip", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@FechaFinDes", mskFechaFin.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    MessageBox.Show("Producto modificado con exito");
                    CargarGrillaProductos();
                    cn.Close();
                }
            }
        }
        //---------------------------------------BORRAR PRODUCTOS----------------------------------------------------------

        private void BorrarProductos()
        {
            if (txtIdProducto.Text.Equals(""))
            {
                MessageBox.Show("Seleccione ID de producto a dar de baja");
                txtIdProducto.Focus();
            }
            else
            {

                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);

                try
                {

                    SqlCommand cmd = new SqlCommand();

                    string consulta = "DELETE FROM PRODUCTOS WHERE codigo = @codProd";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codProd", txtIdProducto.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    CargarGrillaProductos();
                    MessageBox.Show("El producto fue dado de baja con exito");
                    cn.Close();
                }
            }
        }

        //---------------------------------------CARGAR GRILLA PRODUCTOS----------------------------------------------------------
        private void CargarGrillaProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM PRODUCTOS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaProductos.DataSource = tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        //---------------------------------------BOTON MODIFICAR PRODUCTOS----------------------------------------------

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto();            
        }

        //---------------------------------------BOTON LIMPIAR CAMPOS----------------------------------------------------------

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //---------------------------------------BOTON GUARDAR PRODUCTOS----------------------------------------------------------
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtDenominacion.Text.Equals("") || txtDescripcion.Text.Equals("") || mskFechaFin.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos");
                txtDenominacion.Focus();
            }
            else
            {
                string denominacion = txtDenominacion.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                string fechaFin = mskFechaFin.Text.Trim();

                try
                {
                    bool resultado = InsertarProducto(denominacion, descripcion, fechaFin);
                    if (resultado)
                    {
                        CargarGrillaProductos();
                        MessageBox.Show("Dado de alta con éxito!");
                        LimpiarCampos();

                    }
                    else
                    {
                        //MessageBox.Show("Error al insertar el producto");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar el producto" + ex.Message);
                }



            }
        }

        //---------------------------------------FUNCION LIMPIAR CAMPOS----------------------------------------------
        private void LimpiarCampos()
        {
            txtIdProducto.Text = "";
            txtDenominacion.Text = "";
            txtDescripcion.Text = "";
            mskFechaFin.Text = "";
        }

        //---------------------------------------------Cargar campo seleccionado--------------------------------------------
        private void grillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdProducto.Text = grillaProductos.CurrentRow.Cells[0].Value.ToString();
                txtDenominacion.Text = grillaProductos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = grillaProductos.CurrentRow.Cells[2].Value.ToString();
                mskFechaFin.Text = grillaProductos.CurrentRow.Cells[3].Value.ToString();
            }

            catch
            {
            }
        }

        private void ABMProductos_Load(object sender, EventArgs e)
        {

        }

        //---------------------------------------BOTON CANCELAR----------------------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }

        //---------------------------------------BOTON ELIMINAR PRODUCTO----------------------------------------------------------
        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            BorrarProductos();
        }
    }

}

