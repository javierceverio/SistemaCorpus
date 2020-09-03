using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Corpus
{
    public partial class Trabajos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Trabajos(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public void DeshabilitarEntradas()
        {
            nombreTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            tipoComboBox.Enabled = false;
            cantMesesTextBox.Enabled = false;
            fechaInicioDateTimePicker.Enabled = false;
            fechaFinDateTimePicker.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            nombreTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            tipoComboBox.Enabled = true;
            cantMesesTextBox.Enabled = true;
            fechaInicioDateTimePicker.Enabled = true;
            fechaFinDateTimePicker.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        private void Trabajos_Load(object sender, EventArgs e)
        {
            this.trabajosTableAdapter1.Fill(this.corpusDataSet.Trabajos);
            if (id_ClienteTextBox.Text != "")
            {
                int aux = Convert.ToInt16(id_ClienteTextBox.Text);
                this.clientesTableAdapter.FillByID((this.corpusDataSet.Clientes), aux);
            }
            if (id_TrabajoTextBox.Text == "")
            {
                DeshabilitarBotones();
                DeshabilitarEntradas();
            }
        }

        public void DeshabilitarBotones()
        {
            bPresupuesto.Enabled = false;
            bCobro.Enabled = false;
            bCambiarCliente.Enabled = false;
            pagarBeneficio.Enabled = false;
        }

        public void HabilitarBotones()
        {
            bPresupuesto.Enabled = true;
            bCobro.Enabled = true;
            bCambiarCliente.Enabled = true;
            pagarBeneficio.Enabled = true;
        }

        public void EliminarTrabajo()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Trabajo Nº " + numTrabajoTextBox.Text + "?", "ELIMINAR TRABAJO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Trabajos WHERE (Id_Trabajo = " + id_TrabajoTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Eliminado el Trabajo");
            }
        }

        public bool VerSiEstaEnCobros()
        {
            bool verificar = false;

            DataTable dt = cobrosTableAdapter1.GetData();
            int aux = 0; // Para saber si el trabajo tiene Cobros
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                object[] array = dt.Rows[i].ItemArray;
                if (numTrabajoTextBox.Text == array[1].ToString())
                {
                    verificar = true;
                    aux = 1;
                }
            }
            if (aux == 0)
            {
                verificar = false;
            }

            return verificar;
        }

        public bool VerSiEstaEnPresupuesto()
        {
            bool verificar = false;

            DataTable dt = presupuestosTableAdapter1.GetData();
            int aux = 0; // Para saber si el trabajo tiene Presupuesto
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                object[] array = dt.Rows[i].ItemArray;
                if (numTrabajoTextBox.Text == array[1].ToString())
                {
                    verificar = true;
                    aux = 1;
                }
            }
            if (aux == 0)
            {
                verificar = false;
            }

            return verificar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_TrabajoTextBox.Text == "")
            {
                MessageBox.Show("No hay Trabajo seleccionado");
            }
            else
            {
                if (VerSiEstaEnPresupuesto() || VerSiEstaEnCobros())
                {
                    MessageBox.Show("El Trabajo no se puede Eliminar porque ya tiene un Presupuesto Asignado o Cobros realizados. Si bien NO SE RECOMIENDA EN ABSOLUTO, puede primero eliminar todos sus Cobros e Items del Presupuesto y luego podra hacerlo.");
                }
                else
                {
                    EliminarTrabajo();
                    CargarDatos();
                    if (id_TrabajoTextBox.Text == "" && textBox1.Text == "")
                    {
                        DeshabilitarBotones();
                        DeshabilitarEntradas();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();   // Conocer la cantidad de Trabajos en la BD para saber que numero ponerle al siguiente
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Trabajos";
            cmd.Connection = conexion;
            conexion.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int CantTrabajos = dt.Rows.Count;
            conexion.Close();

            using (NuevoTrabajo frm1 = new NuevoTrabajo(user.Text, CantTrabajos))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_ClienteTextBox.Text != "")
            {
                int aux = Convert.ToInt16(id_ClienteTextBox.Text);
                this.clientesTableAdapter.FillByID((this.corpusDataSet.Clientes), aux);
            }
            if (id_TrabajoTextBox.Text != "")
            {
                HabilitarBotones();
                HabilitarEntradas();
                trabajosDataGridView.CurrentCell = trabajosDataGridView.Rows[trabajosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (CambiarCliente frm1 = new CambiarCliente(id_TrabajoTextBox.Text, user.Text))
            {
                frm1.ShowDialog();
            }
            this.trabajosTableAdapter1.Fill(this.corpusDataSet.Trabajos);
        }

        public void CargarDatosDespuesDeActualizar()
        {
            string fila = trabajosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
            trabajosDataGridView.Rows[0].Selected = true;
            int filaNumero = Convert.ToInt16(fila);
            CargarDatos();
            trabajosDataGridView.CurrentCell = trabajosDataGridView.Rows[filaNumero].Cells[3]; // me posiciono nuevamente en la fila donde estaba
        }

        public void ActualizarTrabajo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Trabajos SET Nombre = '" + nombreTextBox.Text.Replace("'", "") + "', Estado = '" + estadoComboBox.Text + "', Tipo = '" + tipoComboBox.Text + "', CantMeses = '" + cantMesesTextBox.Text + "', FechaInicio = '" + fechaInicioDateTimePicker.Text + "', FechaFin = '" + fechaFinDateTimePicker.Text + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Trabajo = " + id_TrabajoTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos del Trabajo se han actualizado de manera satisfactoria");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_TrabajoTextBox.Text == "")
            {
                MessageBox.Show("No hay Trabajo seleccionado");
            }
            else
            {
                if (nombreTextBox.Text != "")
                {
                    if (estadoComboBox.Text == "INICIADO" || estadoComboBox.Text == "FINALIZADO")
                    {
                        ActualizarFechas();
                    }
                    if (cantMesesTextBox.Text != "")
                    {
                        try
                        {
                            int auxiliar = Convert.ToInt16(cantMesesTextBox.Text);
                            ActualizarTrabajo();
                            CargarDatosDespuesDeActualizar();
                        }
                        catch
                        {
                            MessageBox.Show("La cantidad de meses solo admite numeros (sin decimales)");
                            cantMesesTextBox.Focus();
                        }
                    }
                    else
                    {
                        ActualizarTrabajo();
                        CargarDatosDespuesDeActualizar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios");
                }
            }
        }

        private void id_ClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (id_ClienteTextBox.Text != "")
            {
                int aux = Convert.ToInt16(id_ClienteTextBox.Text);
                this.clientesTableAdapter.FillByID((this.corpusDataSet.Clientes), aux);
            }
        }

        public void MostrarMontos()
        {
            if (tipoComboBox.Text == "BLANCO")
            {
                montoTextBox.BackColor = Color.Gray;
                montoSinIvaTextBox.BackColor = Color.White;
                montoConIvaTextBox.BackColor = Color.White;
            }
            else
            {
                montoTextBox.BackColor = Color.White;
                montoSinIvaTextBox.BackColor = Color.Gray;
                montoConIvaTextBox.BackColor = Color.Gray;
            }
        }

        private void tipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMontos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = balanceTableAdapter1.GetData(); // Obtengo la Informacion de Balance para saber si hay al menos un cobro de este Trabajo
            int aux = 0; // Para saber si hay algun Cobro o Pago de este Trabajo
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                object[] array = dt.Rows[i].ItemArray;
                if (numTrabajoTextBox.Text == array[5].ToString() && (array[4].ToString() == "Cobro por Trabajo" || array[4].ToString() == "Pago de un Cobro"))
                {
                    aux = 1;
                }
            }

            if (aux == 0) // Si no hay Cobro o Pagos del Trabajo, abro el Presupuesto Editable, sino solo lo muestro
            {
                using (Presupuestos frm1 = new Presupuestos(user.Text, numTrabajoTextBox.Text, montoTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                using (PresupuestosComenzaronCobros frm1 = new PresupuestosComenzaronCobros(user.Text, numTrabajoTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            
            string fila = trabajosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
            trabajosDataGridView.Rows[0].Selected = true;
            int filaNumero = Convert.ToInt16(fila);
            CargarDatos();
            trabajosDataGridView.CurrentCell = trabajosDataGridView.Rows[filaNumero].Cells[3]; // me posiciono nuevamente en la fila donde estaba
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (estadoComboBox.Text == "INICIADO" || estadoComboBox.Text == "FINALIZADO")
            {
                if (montoTextBox.Text != "" || montoConIvaTextBox.Text != "")
                {
                    string monto;
                    if (tipoComboBox.Text == "BLANCO")
                    {
                        monto = montoConIvaTextBox.Text;
                    }
                    else
                    {
                        monto = montoTextBox.Text;
                    }

                    using (Cobros frm1 = new Cobros(user.Text, numTrabajoTextBox.Text, monto))
                    {
                        frm1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debe asignar un Monto al Trabajo desde Presupuestos");
                }
            }
            else
            {
                MessageBox.Show("Solo se puede cargar Cobros si el Estado del Trabajo es INICIADO o FINALIZADO");
            }
        }

        public void ActualizarFechas()
        {
            if (estadoComboBox.Text == "INICIADO")
            {
                DialogResult dr = MessageBox.Show("Ha cambiado el Estado del Trabajo a INICIADO ¿Desea Actualizar la fecha de INICIO del trabajo?", "ACTUALIZAR FECHA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    fechaInicioDateTimePicker.Text = DateTime.Now.ToString();
                }
            }
            if (estadoComboBox.Text == "FINALIZADO")
            {
                DialogResult dr = MessageBox.Show("Ha cambiado el Estado del Trabajo a FINALIZADO ¿Desea Actualizar la fecha de FINALIZACION del trabajo?", "ACTUALIZAR FECHA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    fechaFinDateTimePicker.Text = DateTime.Now.ToString();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void filtroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void InsertarEnPagos()
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text
            };
            string benef = Convert.ToString(beneficioTextBox.Text.Replace(',', '.'));
            cmd.CommandText = "INSERT into Pagos (NumTrabajo, Referencia, Monto, Fecha, UsuCre) VALUES ('" + numTrabajoTextBox.Text + "', '" + "Pago de Beneficio" + "', " + benef + ", '" + DateTime.Now + "', '" + user.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void InsertarEnBalance()
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text
            };
            string benef = Convert.ToString(beneficioTextBox.Text.Replace(',', '.'));
            cmd.CommandText = "INSERT into Balance (Nombre, Concepto, Referencia, Monto, Fecha, UsuCre) VALUES ('" + "TRABAJO" + "', '" + "Pago del Beneficio" + "', '" + numTrabajoTextBox.Text + "', " + "-" + benef + ", '" + DateTime.Now + "', '" + user.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void PagarBeneficio() // Insertar el Beneficio en Pagos Realizados
        {
            if (estadoComboBox.Text == "CERRADO")
            {
                if (beneficioTextBox.Text != "")
                {
                    DataTable dt = pagosTableAdapter1.GetData();
                    int aux = 0; // Para saber si ya se realizo el Pago del Beneficio con anterioridad
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (numTrabajoTextBox.Text == array[2].ToString() && "Pago de Beneficio" == array[3].ToString())
                        {
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Beneficio del del Trabajo Nº " + numTrabajoTextBox.Text + " por un monto de $ " + beneficioTextBox.Text + "?", "PAGAR BENEFICIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            InsertarEnPagos();
                            MessageBox.Show("El Beneficio del Trabajo Nº " + numTrabajoTextBox.Text + " se ha Pagado de manera satisfactoria");
                            InsertarEnBalance();
                        }                    }
                    else
                    {
                        MessageBox.Show("El Beneficio del Trabajo Nº " + numTrabajoTextBox.Text + " ya se ha realizado con anterioridad, por favor verifiquelo en Pagos o en el Balance");
                    }
                }
                else
                {
                    MessageBox.Show("Todavia no ha generado el Beneficio");
                }
            }
            else
            {
                MessageBox.Show("Solo puede pagar el Beneficio una vez que el Estado del Trabajo sea CERRADO");
            }
        }

        private void pagarBeneficio_Click(object sender, EventArgs e)
        {
            PagarBeneficio();
        }

        public void CargarDatos()
        {
            if (checkBox1.Checked && textBox1.Text != "" && filtroEstado.Text != "")
            {
                this.trabajosTableAdapter1.FillByCompleto((this.corpusDataSet.Trabajos), textBox1.Text, filtroEstado.Text);
            }
            else if (checkBox1.Checked && textBox1.Text != "" && filtroEstado.Text == "")
            {
                this.trabajosTableAdapter1.FillBy((this.corpusDataSet.Trabajos), textBox1.Text);
            }
            else if (checkBox1.Checked && filtroEstado.Text != "" && textBox1.Text == "")
            {
                this.trabajosTableAdapter1.FillByEstado((this.corpusDataSet.Trabajos), filtroEstado.Text);
            }
            else if (checkBox1.Checked && filtroEstado.Text == "" && textBox1.Text == "")
            {
                this.trabajosTableAdapter1.Fill(this.corpusDataSet.Trabajos);
            }
            else if (!checkBox1.Checked && textBox1.Text != "")
            {
                this.trabajosTableAdapter1.FillBy((this.corpusDataSet.Trabajos), textBox1.Text);
            }
            else
            {
                this.trabajosTableAdapter1.Fill(this.corpusDataSet.Trabajos);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
