using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Controles
{
    public partial class ucTratamiento : UserControl
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
        int idReceta = -1;
        public ucTratamiento(int idReceta)
        {
            InitializeComponent();
            this.idReceta = idReceta;
        }

        public void LlenarInformacion(int idReceta)
        {
            List<Tratamiento> tratamiento = new List<Tratamiento>();
            tratamiento = controlTratamiento.ConsultarTratamiento(idReceta);
            dgvTratamientos.DataSource = null;
            dgvTratamientos.DataSource = tratamiento;
        }
        public void LimpiarCajas()
        {
            txtServicio.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
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

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMedicamentoActual = medicamentos[cbBusqueda.SelectedIndex].IDMedicamento;
            txtServicio.Text = medicamentos[cbBusqueda.SelectedIndex].Nombre;
            txtPrecio.Text = medicamentos[cbBusqueda.SelectedIndex].Precio.ToString();
            txtCantidad.Text = "1";
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnQuitar.Enabled = false;
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
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string nombre = string.Empty;
            Medicamento medicamento = new Medicamento(cantidad, "null", "null", nombre, -1, precio, "null", "null");
            tratamiento.Add(medicamento);
            LimpiarCajas();
            dgvTratamientos.DataSource = null;
            dgvTratamientos.DataSource = tratamiento;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (idMedicamentoActual > -1)
            {
                tratamiento.RemoveAt(idMedicamentoActual);
                dgvTratamientos.DataSource = null;
                dgvTratamientos.DataSource = tratamiento;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Desea guardar el tratamiento?", "Guardar Tratamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (respuesta == "Yes")
            {
                int contador = 0;
                foreach (Medicamento medicamento in tratamiento)
                {
                    Tratamiento nuevoTratamiento = new Tratamiento(idReceta, medicamento.Cantidad, medicamento.Nombre, medicamento.Precio);
                    if (controlTratamiento.AgregarTratamiento(nuevoTratamiento))
                    {
                        contador++;
                    }
                }
                MessageBox.Show(contador + " Tratamiento(s) guardado(s) con éxito", "Guardar Tratamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tratamiento no guardado", "Guardar Tratamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTratamientos_Click(object sender, EventArgs e)
        {
            if (tratamiento.Count <= 0 || tratamiento.Count == null)
            {

            }
        }

        private void dgvTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumnIndex = dgvTratamientos.Columns["id"].Index;
            if (dgvTratamientos.CurrentRow != null && dgvTratamientos.CurrentRow.Cells[idColumnIndex].Value != null)
            {
                idMedicamentoActual = int.Parse(dgvTratamientos.CurrentRow.Cells[idColumnIndex].Value.ToString());
                Medicamento medicamento = tratamiento[idMedicamentoActual];
                txtServicio.Text = medicamento.Nombre;
                txtCantidad.Text = medicamento.Cantidad.ToString();
                txtPrecio.Text = medicamento.Precio.ToString();
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnQuitar.Enabled = true;
            }
        }
    }
}
