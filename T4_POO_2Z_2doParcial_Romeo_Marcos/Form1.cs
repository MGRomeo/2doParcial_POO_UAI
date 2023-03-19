using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Club club = new Club();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuraciones previas

            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocioTotal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuotaPendiente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuotaPagada.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuotaOrdenada.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.MultiSelect = false;
            dgvSocioTotal.MultiSelect = false;
            dgvCuotaPendiente.MultiSelect = false;
            dgvCuotaPagada.MultiSelect = false;
            dgvCuotaOrdenada.MultiSelect = false;
            lblModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // si los campos no estan vacios
                if (txtLegajo.Text != "" && txtApellido.Text != "" && txtNombre.Text != "")
                {
                    // difiero si es para la carga ("Agregar") o para modificar ("Aceptar")
                    if (btnAgregar.Text == "Agregar")
                    {
                        if (rdbSocioNormal.Checked)
                        {
                            Socio_Normal socio = new Socio_Normal(txtLegajo.Text, txtApellido.Text, txtNombre.Text);
                            club.CargarSocio(socio);
                        }
                        else
                        {
                            Socio_Especial socio = new Socio_Especial(txtLegajo.Text, txtApellido.Text, txtNombre.Text);
                            club.CargarSocio(socio);
                        }
                    }
                    else
                    {
                        // Codigo para modificar el socio en la lista y en en la cuota
                        Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                        Socio modifica = club.ModificarSocio(aux);
                        modifica.Nombre = txtNombre.Text;
                        modifica.Apellido = txtApellido.Text;
                        modifica.Legajo = txtLegajo.Text;
                        //paso el socio a modificar, y las propiedades a intercambiar
                        if (club.MostrarCuotasPendientes().Exists(x => x.Socio.Legajo == aux.Legajo)) { club.ModificarSocioEnCuota(aux, modifica); }

                    }
                    Mostrar();
                    // vuelvo el boton a la normalidad 
                    btnAgregar.Text = "Agregar";
                    lblModificar.Visible = false;
                    Limpiar();
                }
                else
                {
                    throw new IngresoVacio();
                }

            }
            catch (IngresoVacio) when (txtLegajo.Text == "") { MessageBox.Show("Debe ingresar un Legajo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtLegajo.Select(); }
            catch (IngresoVacio) when (txtApellido.Text == "") { MessageBox.Show("Debe ingresar un Apellido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtApellido.Select(); }
            catch (IngresoVacio) when (txtNombre.Text == "") { MessageBox.Show("Debe ingresar un Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNombre.Select(); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.Rows.Count != 0)
                {
                    Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                    // busco si existe el socio seleccionado
                    if (club.MostrarCuotasPendientes().Exists(x => x.Socio.Legajo == aux.Legajo))
                    {
                        //Si debe cuotas no se borra
                        MessageBox.Show("Este socio no se puede eliminar, ya que posee cuotas pendientes", "Atençión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        club.BorrarSocio(aux);
                    }
                    Mostrar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (club.MostrarSocios().Count > 0)
                {
                    //Cambio el texto del boton y muestro una leyenda
                    lblModificar.Visible = true;
                    btnAgregar.Text = "Aceptar";
                    // Coloco los parametros anteriores en los textbox, para modificar lo que se quiere
                    Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                    txtNombre.Text = aux.Nombre;
                    txtApellido.Text = aux.Apellido;
                    txtLegajo.Text = aux.Legajo;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCrearCuota_Click(object sender, EventArgs e)
        {
            try
            {
                // valido ingresos vacios
                if (txtCodigo.Text != "" && txtImporte.Text != "")
                {
                    // selecciono por radio button y socio seleccionado

                    // Carga de cuotas individual
                    if (rdbIndividual.Checked && dgvSocios.CurrentRow != null)
                    {
                        Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                        if (club.ValidaCuota(aux)== false)
                        {
                            Limpiar();
                            throw new ExcesoCuotasPermitidas();
                        }
                        var c = club.MostrarCuotasPendientes();
                        // validacion de codigo repetido
                        if (c.Exists(x => x.Codigo == int.Parse(txtCodigo.Text)))
                        {
                            throw new IngresoRepetido();
                        }
                        // cargo variables para el constructor de la cuota
                        if (!Information.IsNumeric(txtCodigo.Text))
                        {
                            throw new IngresoCodidoNoValido();
                        }
                        if (!Information.IsNumeric(txtImporte.Text))
                        {
                            throw new IngresoingresoImporteNoValido();
                        }
                        int cod = int.Parse(txtCodigo.Text);
                        int valor = int.Parse(txtImporte.Text);
                        DateTime fecha = DateTime.Parse(dtpVencimiento.Text);
                        Cuota cuota = new Cuota(cod, valor, aux, fecha);
                        // metodo de carga de cuota individual
                        club.CargarCuotaIndividual(cuota);
                    }
                    else
                    {
                        // Carga de cuotas General

                        Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                        var c = club.MostrarCuotasPendientes();
                        // validacion de codigo repetido
                        if (c.Exists(x => x.Codigo == int.Parse(txtCodigo.Text)))
                        {
                            throw new IngresoRepetido();
                        }
                        // cargo variables para el constructor de la cuota
                        int cod = int.Parse(txtCodigo.Text);
                        int valor = int.Parse(txtImporte.Text);
                        DateTime fecha = DateTime.Parse(dtpVencimiento.Text);
                        Cuota cuota = new Cuota(cod, valor, aux, fecha);
                        // metodo de carga de cuota general
                        club.CargarCuotaGeneral(cuota);

                    }
                    Mostrar();
                    Limpiar();
                }
                else
                {
                    throw new IngresoVacio();
                }

            }
            catch (IngresoRepetido) { MessageBox.Show("Codigo Repetido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtCodigo.Select(); }
            catch (IngresoCodidoNoValido) { MessageBox.Show("Debe ingresar un Codigo numérico", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtCodigo.Select(); }
            catch (IngresoingresoImporteNoValido) { MessageBox.Show("Debe ingresar un Importe numérico", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtImporte.Select(); }
            catch (IngresoVacio) when (txtCodigo.Text == "") { MessageBox.Show("Debe ingresar un Codigo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtCodigo.Select(); }
            catch (IngresoVacio) when (txtImporte.Text == "") { MessageBox.Show("Debe ingresar un Importe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtImporte.Select(); }
            catch (IngresoVacio) when (dgvSocios.CurrentRow == null) { MessageBox.Show("Debe seleccionar un Socio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (ExcesoCuotasPermitidas) { MessageBox.Show("Este socio posee 2 cuotas sin pagar, no se genera cuota", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        //Metodo general para mostrar en todos los Dgv
        private void Mostrar()
        {
            dgvSocios.DataSource = null; dgvSocios.DataSource = club.MostrarSocios();
            if (club.MostrarSocios().Count > 0) { dgvSocios.Columns[3].Visible = false; }
            MostrarCuotasPendientes();
            MostrarCuotasPagas();
            MostrarCuotasOrdenadas();
            MostrarTotal();
        }

        //Dgv n°2
        private void MostrarCuotasPendientes()
        {
            try
            {
                if (club.MostrarSocios().Count > 0)
                {

                    Socio s = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                    var lc = from c in club.MostrarCuotasPendientes() where c.Socio.Legajo == s.Legajo select new { Codigo = c.Codigo, Importe = c.Importe, Fecha_Inicio = c.Fecha_inicio, Vencimiento = c.Fecha_vencimiento, Recargo = c.Socio.Recargo.ToString("N2"), Legajo = c.Socio.Legajo };
                    dgvCuotaPendiente.DataSource = null;
                    dgvCuotaPendiente.DataSource = lc.ToList();
                    dgvCuotaPendiente.Columns[5].Visible = false;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Falla por algo");
            }

        }

        //Dgv n°3
        private void MostrarCuotasPagas()
        {
            try
            {
                // utilizo LinQ para mostrar lo que se solicita en el dgv N|3
                if (club.MostrarSocios().Count > 0)
                {

                    Socio s = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                    var lc = from c in club.MostrarCuotasPagas() where c.Socio.Legajo == s.Legajo select new { Codigo = c.Codigo, Importe = c.Importe, Fecha_Inicio = c.Fecha_inicio, Vencimiento = c.Fecha_vencimiento, Recargo = c.Socio.Recargo.ToString("N2"), Legajo = c.Socio.Legajo };
                    dgvCuotaPagada.DataSource = null;
                    dgvCuotaPagada.DataSource = lc.ToList();
                    dgvCuotaPagada.Columns[5].Visible = false;
                }
            }
            catch (ArgumentNullException)
            {

            }

        }

        //Dgv n°4
        private void MostrarCuotasOrdenadas()
        {
            try
            {
                //utilizo la clase Ascendente
                if (rdbMenorMayor.Checked == true)
                {
                    dgvCuotaOrdenada.DataSource = null;
                    var Lista = club.MostrarCuotasPagas();
                    Lista.Sort(new Cuota.ImporteASC());
                    dgvCuotaOrdenada.DataSource = Lista;
                }
                else 
                {
                    //utilizo la clase descendente
                    dgvCuotaOrdenada.DataSource = null;
                    var Lista = club.MostrarCuotasPagas();
                    Lista.Sort(new Cuota.ImporteDESC());
                    dgvCuotaOrdenada.DataSource = Lista;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Dgv n°5
        public void MostrarTotal()
        {
            try
            {
                // al igual que en otros metodos selecciono la fuente de datos y creo la clase anonima para mostrar en dgv
                if (club.MostrarSocios().Count > 0)
                {
                    Socio s = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                    var lc = from c in club.MostrarCuotasPagas() where c.Socio.Legajo == s.Legajo select new { Nombre = c.Codigo, Total = c.CalculoTotal(s) };
                    dgvSocioTotal.DataSource = null;
                    dgvSocioTotal.DataSource = lc.ToList();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Falla por algo");
            }
        }

        private void Limpiar()
        {
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtCodigo.Clear();
            txtImporte.Clear();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCuotaPendiente.CurrentRow != null)
                {
                    decimal Importe = decimal.Parse(dgvCuotaPendiente.CurrentRow.Cells[1].Value.ToString());
                    decimal Recargo = decimal.Parse(dgvCuotaPendiente.CurrentRow.Cells[4].Value.ToString());
                    decimal Total = Importe + Recargo;
                    DialogResult boton = MessageBox.Show($"El valor de la cuota es de: $ {Importe}{Environment.NewLine}" +
                                    $"Con un recargo de: $ {Recargo}{Environment.NewLine}" +
                                    $"Total a pagar: $ {Total}{Environment.NewLine}" +
                                    $"{Environment.NewLine}" +
                                    $"Desea abonar este Total?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (boton == DialogResult.OK) { Pagar(); }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Pagar()
        {
            int codigo = int.Parse((dgvCuotaPendiente.CurrentRow.Cells[0].Value.ToString()));
            string legajo = (dgvCuotaPendiente.CurrentRow.Cells[5].Value.ToString());
            club.BorrarCuota(legajo, codigo);
            MostrarCuotasPendientes();
            MostrarCuotasPagas(); 
            MostrarCuotasOrdenadas();
            MostrarTotal();
        }

        private void dgvSocios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSocios.CurrentCell != null)
                {
                    MostrarCuotasPendientes();
                    MostrarCuotasPagas();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarCuotasOrdenadas();
        }

        public class IngresoVacio : Exception { }
        public class IngresoRepetido : Exception { }
        public class IngresoCodidoNoValido : Exception { }
        public class IngresoingresoImporteNoValido : Exception { }
        public class ExcesoCuotasPermitidas : Exception { }

    }
}
