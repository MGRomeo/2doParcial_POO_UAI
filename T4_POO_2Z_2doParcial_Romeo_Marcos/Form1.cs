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
            Mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLegajo.Text != "" && txtApellido.Text != "" && txtNombre.Text != "")
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
                    Mostrar();
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

        private void btnCrearCuota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != "" && txtImporte.Text != "")
                {
                    if (rdbIndividual.Checked && dgvSocios.CurrentRow != null)
                    {
                        Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                        int cod = int.Parse(txtCodigo.Text);
                        int valor = int.Parse(txtImporte.Text);
                        DateTime fecha = DateTime.Parse(dtpVencimiento.Text);
                        Cuota cuota = new Cuota(cod, valor, aux, fecha);
                        club.CargarCuotaIndividual(cuota);
                    }
                    else
                    {
                        Socio aux = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                        int cod = int.Parse(txtCodigo.Text);
                        int valor = int.Parse(txtImporte.Text);
                        DateTime fecha = DateTime.Parse(dtpVencimiento.Text);
                        Cuota cuota = new Cuota(cod, valor, aux,fecha);
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
            catch (IngresoVacio) when (txtCodigo.Text == "") { MessageBox.Show("Debe ingresar un Codigo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtCodigo.Select(); }
            catch (IngresoVacio) when (txtImporte.Text == "") { MessageBox.Show("Debe ingresar un Importe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtImporte.Select(); }
            catch (IngresoVacio) when (dgvSocios.CurrentRow == null) { MessageBox.Show("Debe seleccionar un Socio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        public class IngresoVacio : Exception { }

        private void Mostrar()
        {
            if (club.MostrarSocios().Count > 0) { dgvSocios.DataSource = null; dgvSocios.DataSource = club.MostrarSocios(); }
            MostrarCuotasPendientes();
        }

        private void MostrarCuotasPendientes()
        {
            try
            {
                Socio s = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                var lc = from c in club.MostrarCuotas() where c.Socio.Legajo == s.Legajo select new { Codigo = c.Codigo, Importe = c.Importe, Fecha_Inicio = c.Fecha_inicio, Vencimiento = c.Fecha_vencimiento, Recargo = c.Socio.Recargo };
                dgvCuotaPendiente.DataSource = null;
                dgvCuotaPendiente.DataSource = lc.ToList();
            }
            catch (Exception)
            {

                throw;
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
            
        }
        private void Pagar() 
        {
            if (dgvCuotaPendiente.CurrentCell != null)
            {
                MessageBox.Show("Desea pagar");
            }
        }

        private void dgvSocios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSocios.CurrentCell != null) MostrarCuotasPendientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
