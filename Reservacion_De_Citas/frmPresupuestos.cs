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
    public partial class frmPresupuestos : Form
    {
        ControlPresupuesto controlPresupuesto = new ControlPresupuesto();
        bool cambio = false;
        int idPresupuestoActual = -1;
        public frmPresupuestos()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flpConsulta.Visible = true;
            flpConsulta.Controls.Clear();
            ucPresupuesto ucPresup = new ucPresupuesto();
            ucPresup.ModificarInformacion(false);
            flpConsulta.Controls.Add(ucPresup);
            cambio = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de eliminar el presupuesto?", "Eliminar Presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch( respuesta)
            {
                case "Yes":
                    if (idPresupuestoActual > -1)
                    {
                        if (controlPresupuesto.EliminarPresupuesto(idPresupuestoActual)){
                            MessageBox.Show("El presupuesto se eliminó correctamente", "Eliminar Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el presupuesto", "Eliminar Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                    }
                    break;
                case "No":
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                if (flpConsulta.Controls[0] != null )
                {
                    ucPresupuesto ucPresup = flpConsulta.Controls[0] as ucPresupuesto;
                    ucPresup.ModificarInformacion(false);
                    flpConsulta.Controls.Clear();
                    flpConsulta.Controls.Add(ucPresup);
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = false;
                    cambio = true;
                }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de guardar los cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch( respuesta)
            {
                case "Yes":
                    if (flpConsulta.Controls[0] != null)
                    {
                        ucPresupuesto ucPresup = flpConsulta.Controls[0] as ucPresupuesto;
                        Presupuesto presupuesto = ucPresup.ObtenerPresupuesto();
                        if (cambio)
                        {
                            if (controlPresupuesto.ModificarPresupuesto(presupuesto))
                            {
                                MessageBox.Show("El presupuesto se modificó correctamente", "Modificar Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el presupuesto", "Modificar Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (controlPresupuesto.AgregarPresupuesto(presupuesto))
                            {
                                MessageBox.Show("El presupuesto se agregó correctamente", "Agregar Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar el presupuesto", "Agregar Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                case "No":
                    break;
            }
        }

        private void cbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvConsultas.Visible = true;
            if (Analizador.EsEntero(cbBusqueda.Text))
            {
                int id = Convert.ToInt32(cbBusqueda.Text);
                Presupuesto presupuesto = controlPresupuesto.ConsultarPresupuesto(id);
                if (presupuesto != null)
                {
                    dgvConsultas.DataSource = presupuesto;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    dgvConsultas.DataSource = null;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
            }
            else
            {
                lblMensajeBusqueda.Visible = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvConsultas.Visible = false;
            int idColumnIndex = dgvConsultas.Columns["id"].Index;
            if (dgvConsultas.CurrentRow != null && dgvConsultas.CurrentRow.Cells[idColumnIndex].Value != null)
            {
                int idCelda = int.Parse(dgvConsultas.CurrentRow.Cells[idColumnIndex].Value.ToString());
                idPresupuestoActual = idCelda;
                flpConsulta.Controls.Clear();
                Presupuesto presupuesto = controlPresupuesto.ConsultarPresupuesto(idCelda);
                ucPresupuesto ucPresup = new ucPresupuesto();
                ucPresup.LlenarInformaicon(presupuesto);
                ucPresup.ModificarInformacion(true);
                flpConsulta.Controls.Add(ucPresup);
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                idPresupuestoActual = idCelda;
            }
        }
    }
}
