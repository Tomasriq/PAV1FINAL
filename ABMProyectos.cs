using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewWareSoft.Negocio.ABM
{
    public partial class ABMProyecto : Form
    {
        public ABMProyecto()
        {
            InitializeComponent();
            CargarGrillaProyectos();
        }

        
        //---------------------------------------------FUNCIONALIDAD BOTON CANCELAR---------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }

        //---------------------------------------------FUNCIONALIDAD BOTON LIMPIAR CAMPOS---------------------------------------
        private void LimpiarCampos()
        {

            txtIdCliente.Text = "";
            txtDescripcion.Text = "";
            mskFechaInicio.Text = "";
            txtIdProyecto.Text = "";
            mskFechaFinProb.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //----------------------------------------------CONFIGURACION DE ALTA(BOTON Y BD)----------------------------------------
        private void bntAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Equals(" ") || mskFechaInicio.Text.Equals(" ") || txtDescripcion.Text.Equals(" ") || mskFechaFinProb.Text.Equals(""))
            {
                MessageBox.Show("Los datos estan incompletos");
                txtIdCliente.Focus();
            }
            else
            {
                string descripcion = txtDescripcion.Text.Trim();
                string idCliente = txtIdCliente.Text.Trim();
                string fechaInicio = mskFechaInicio.Text.Trim();
                string fechaFinProb = mskFechaFinProb.Text.Trim();

                bool resultado = false;

                try
                {
                    resultado = AgregarProyecto(descripcion, idCliente, fechaInicio, fechaFinProb);

                    if (resultado == true)
                    {
                        MessageBox.Show("Proyecto cargado correctamente");
                        CargarGrillaProyectos();
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar proyecto!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar proyecto!!");
                }
                finally
                {
                    LimpiarCampos();
                    txtDescripcion.Focus();
                }
            }
        }
        private bool AgregarProyecto(string descripcion, string idCliente, string fechaInicio, string fechaFinProb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO PROYECTOS (descripcion, id_cliente, fecha_inicio, fecha_fin_probable ) VALUES (@descrip, @codCliente, @fechaInicio, @fechaFinProb)";
                cmd.Parameters.Clear();


                cmd.Parameters.AddWithValue("@descrip", descripcion);
                cmd.Parameters.AddWithValue("@codCliente", idCliente);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFinProb", fechaFinProb);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        private void ABM_Proyecto_Load(object sender, EventArgs e)
        {
        }
        //----------------------------------------CONFIGURACION DE MODIFICACION----------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Equals("") || mskFechaInicio.Text.Equals("") || txtDescripcion.Text.Equals("") || txtIdProyecto.Text.Equals("") || mskFechaFinProb.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
                txtIdCliente.Focus();
            }
            else
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);

                try
                {

                    SqlCommand cmd = new SqlCommand();

                    string consulta = "UPDATE PROYECTOS SET descripcion = @descrip, id_cliente = @idCli, fecha_inicio = @fechaini, fecha_fin_probable = @fechaFinProb WHERE codigo = @codigo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idCli", txtIdCliente.Text);
                    cmd.Parameters.AddWithValue("@descrip", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@fechaini", mskFechaInicio.Text);
                    cmd.Parameters.AddWithValue("@fechaFinProb", mskFechaFinProb.Text);
                    cmd.Parameters.AddWithValue("@codigo", txtIdProyecto.Text);

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
                    CargarGrillaProyectos();
                    LimpiarCampos();
                    MessageBox.Show("Proyecto modificado con exito");
                    cn.Close();
                }



            }

        }
        //----------------------------------------CONFIGURACION DE BAJA(BOTON Y BD)---------------------------------------------
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtIdProyecto.Text.Equals(""))
            {
                MessageBox.Show("Introducir ID de proyecto a eliminar");
                txtIdProyecto.Focus();
            }
            else
            {
                
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {

                    SqlCommand cmd = new SqlCommand();

                    string consulta = "DELETE FROM PROYECTOS WHERE codigo = @codigo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codigo", txtIdProyecto.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    CargarGrillaProyectos();
                    LimpiarCampos();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    MessageBox.Show("El proyecto fue eliminado con exito");
                    cn.Close();
                }
                
            }

        }

        private void CargarGrillaProyectos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM PROYECTOS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaProyecto.DataSource = tabla;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarGrilla_Click(object sender, EventArgs e)
        {
            CargarGrillaProyectos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskdFechaInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ABMProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
