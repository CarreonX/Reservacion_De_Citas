using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmTratamiento : Form
    {
        List<Medicamento> tratamiento = new List<Medicamento>();
        List<Medicamento> medicamentos = new List<Medicamento>();
        ControlMedicamento controlMedicamento = new ControlMedicamento();
        ControlTratamiento controlTratamiento = new ControlTratamiento();
        bool cambio = false;
        int idMedicamentoActual = -1;
        bool matchServicio = false;
        bool matchCantidad = false;
        bool matchPrecio = false;
        public frmTratamiento()
        {
            InitializeComponent();
        }

        private void cbBusqueda_TextChanged(object sender, EventArgs e)
        {
            idMedicamentoActual = -1;
            medicamentos.Clear();
            cbBusqueda.Items.Clear();
            cbBusqueda.DroppedDown = false;

            if (Analizador.EsEntero(cbBusqueda.Text))
            {
                Medicamento medicamento = controlMedicamento.ConsultarMedicamento(int.Parse(cbBusqueda.Text));

                if (medicamento != null)
                {
                    cbBusqueda.Items[0] = $"{medicamento.IDMedicamento}-{medicamento.Nombre}";
                    cbBusqueda.DroppedDown = true;
                }
            }
            else if (Analizador.EsCadena(cbBusqueda.Text))
            {
                medicamentos = controlMedicamento.ConsultarMedicamentosPorNombre(cbBusqueda.Text);

                if (medicamentos != null)
                {
                    cbBusqueda.Items.Clear();
                    foreach (Medicamento medicamento in medicamentos)
                    {
                        cbBusqueda.Items.Add($"{medicamento.IDMedicamento}-{medicamento.Nombre}");
                    }
                    cbBusqueda.DroppedDown = true;
                }
            }
        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {
            if (txtServicio.Text != string.Empty && Analizador.EsCadena(txtServicio.Text))
            {
                matchServicio = true;
            }
            else
            {
                matchServicio = false;
            }
            if (matchServicio && matchCantidad && matchPrecio)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (Analizador.EsNumeroPositivo(txtCantidad.Text))
            {
                matchCantidad = true;
            }
            else
            {
                matchCantidad = false;
            }
            if (matchServicio && matchCantidad && matchPrecio)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (Analizador.EsDecimalPositivo(txtPrecio.Text) || Analizador.EsNumeroPositivo(txtPrecio.Text))
            {
                matchPrecio = true;
            }
            else
            {
                matchPrecio = false;
            }
            if (matchServicio && matchCantidad && matchPrecio)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMedicamentoActual = medicamentos[cbBusqueda.SelectedIndex].IDMedicamento;
            txtServicio.Text = medicamentos[cbBusqueda.SelectedIndex].Nombre;
            txtPrecio.Text = medicamentos[cbBusqueda.SelectedIndex].Precio.ToString();
            txtCantidad.Text = "1";
        }
    }
}
