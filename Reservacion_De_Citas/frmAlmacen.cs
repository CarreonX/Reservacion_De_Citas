using Clases;
using Controles;
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
    public partial class frmAlmacen : Form
    {
        ControlMedicamento controlMedicamento = new ControlMedicamento();
        bool guardar = false;
        public frmAlmacen()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flpConsulta.Controls.Clear();
            ucMedicamento ucMed = new ucMedicamento();
            flpConsulta.Controls.Add(ucMed);
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            guardar = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idx = -1;

            if (Analizador.EsEntero(cbBusqueda.Text))
            {
                idx = Convert.ToInt32(cbBusqueda.Text);
            }
            else if (flpConsulta.Controls[0] != null)
            {
                ucMedicamento ucMedicamento = flpConsulta.Controls[0] as ucMedicamento;
                if (ucMedicamento != null)
                {
                    idx = ucMedicamento.ObtenerMedicamento().IDMedicamento;
                }
            }

            if (idx > -1)
            {
                string respuesta = MessageBox.Show("¿Esta seguro de que desea eliminar el medicamento?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                switch (respuesta)
                {
                    case "Yes":
                        if (controlMedicamento.EliminarMedicamento(idx))
                        {
                            MessageBox.Show("Medicamento eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flpConsulta.Controls.Clear();
                            dgvConsultas.Visible = true;
                            btnAgregar.Enabled = true;
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Esta seguro de que desea guardar los cambios?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch (respuesta)
            {
                case "Yes":
                    if (guardar)
                    {
                        ucMedicamento ucMedic = flpConsulta.Controls[0] as ucMedicamento;
                        Medicamento medicamento = ucMedic.ObtenerMedicamento();

                        if (controlMedicamento.AgregarMedicamento(medicamento))
                        {
                            MessageBox.Show("Medicamento agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flpConsulta.Controls.Clear();
                            btnAgregar.Enabled = true;
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGuardar.Enabled = false;
                            guardar = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        ucMedicamento ucMedic = flpConsulta.Controls[0] as ucMedicamento;
                        Medicamento medicamento = ucMedic.ObtenerMedicamento();
                        if (controlMedicamento.ModificarMedicamento(medicamento))
                        {
                            MessageBox.Show("Medicamento modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flpConsulta.Controls.Clear();
                            btnAgregar.Enabled = true;
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGuardar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvConsultas.Visible = false;
            int idColumnIndex = dgvConsultas.Columns["id"].Index;
            if (dgvConsultas.CurrentRow != null && dgvConsultas.CurrentRow.Cells[idColumnIndex].Value != null)
            {
                int idCelda = int.Parse(dgvConsultas.CurrentRow.Cells[idColumnIndex].Value.ToString());
                flpConsulta.Controls.Clear();
                Medicamento medicamento = controlMedicamento.ConsultarMedicamento(idCelda);
                ucMedicamento ucMedicamento = new ucMedicamento();
                ucMedicamento.LlenarInformacion(medicamento);
                flpConsulta.Controls.Add(ucMedicamento);
            }
        }

        private void cbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if( Analizador.EsLetra( cbBusqueda.Text) || !Analizador.EsEntero(cbBusqueda.Text))
            {
                lblMensajeBusqueda.Visible = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            else
            {
                Medicamento medicamento = controlMedicamento.ConsultarMedicamento(Convert.ToInt32(cbBusqueda.Text));
                dgvConsultas.DataSource = medicamento;
                lblMensajeBusqueda.Visible = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
