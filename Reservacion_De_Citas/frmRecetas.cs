using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Controles;
using Mysqlx.Session;

namespace Formularios
{
    public partial class frmRecetas : Form
    {
        ControlReceta controlReceta = new ControlReceta();
        bool cambio = false;
        int idRecetaActual = -1;
        int idOdontologo = -1;
        public frmRecetas(int idOdontologo)
        {
            InitializeComponent();
            if (idOdontologo > -1)
            {
                this.idOdontologo = idOdontologo;
            }
            else
            {
                btnAgregar.Visible = false;
            }
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvConsultas.Visible = false;
            int idColumnIndex = dgvConsultas.Columns["id"].Index;
            if (dgvConsultas.CurrentRow != null && dgvConsultas.CurrentRow.Cells[idColumnIndex].Value != null)
            {
                idRecetaActual = int.Parse(dgvConsultas.CurrentRow.Cells[idColumnIndex].Value.ToString());
                Receta receta = controlReceta.ConsultarReceta(idRecetaActual);
                if (receta != null)
                {
                    ucReceta ucReceta = new ucReceta( idOdontologo );
                    ucReceta.Dock = DockStyle.Fill;
                    ucReceta.ModificarInformacion(false);
                    ucReceta.LlenarInformacion(receta);
                    flpConsulta.Controls.Clear();
                    flpConsulta.Controls.Add(ucReceta);
                }
            }
        }

        private void cbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvConsultas.Visible = true;
            List<Receta> recetas = new List<Receta>();
            List<Receta> recetasFiltradas = new List<Receta>();
            if (Analizador.EsNumeroPositivo(cbBusqueda.Text))
            {
                recetas = controlReceta.ConsultarRecetasPorMedico(int.Parse(cbBusqueda.Text));
                recetasFiltradas = controlReceta.ConsultarRecetasPorPaciente(int.Parse(cbBusqueda.Text));
                foreach (Receta receta in recetasFiltradas)
                {
                    recetas.Add(receta);
                }
                dgvConsultas.DataSource = recetas;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            else
            {
                lblMensajeBusqueda.Visible = true;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvConsultas.Visible = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;

            ucReceta ucReceta = new ucReceta( idOdontologo );
            ucReceta.Dock = DockStyle.Fill;
            ucReceta.LlenarInformacion(idOdontologo);
            ucReceta.ModificarInformacion(true);
            flpConsulta.Controls.Clear();
            flpConsulta.Controls.Add(ucReceta);
            flpConsulta.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Desea eliminar la receta?", "Eliminar Receta", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (respuesta == "Yes")
            {
                if (idRecetaActual > -1)
                {
                    if (controlReceta.EliminarReceta(idRecetaActual))
                    {
                        MessageBox.Show("Receta eliminada con éxito", "Eliminar Receta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvConsultas.Visible = false;
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna receta", "Eliminar Receta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(idRecetaActual > -1)
            {
                dgvConsultas.Visible = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                ucReceta ucReceta = new ucReceta(idOdontologo);
                ucReceta.Dock = DockStyle.Fill;
                ucReceta.LlenarInformacion(idRecetaActual);
                ucReceta.ModificarInformacion(true);
                flpConsulta.Controls.Clear();
                flpConsulta.Controls.Add(ucReceta);
                flpConsulta.Visible = true;
                flpConsulta.Enabled = true;
                cambio = true;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna receta", "Modificar Receta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Desea guardar los cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            if (respuesta == "Yes")
            {
                if (cambio)
                {
                    ucReceta ucReceta = (ucReceta)flpConsulta.Controls[0];
                    string indicaciones = ucReceta.txtIndicaciones.Text;
                    Receta nueva = controlReceta.ConsultarReceta(int.Parse(ucReceta.txtIdReceta.Text));
                    nueva.Indicaciones = indicaciones;
                    if(controlReceta.ModificarReceta(nueva))
                    {
                        MessageBox.Show("Receta modificada con éxito", "Modificar Receta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvConsultas.Visible = false;
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    ucReceta ucReceta = (ucReceta)flpConsulta.Controls[0];
                    string indicaciones = ucReceta.txtIndicaciones.Text;
                    DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);

                    Receta nueva = controlReceta.ConsultarReceta( controlReceta.ConsultarIDUltimaReceta());
                    nueva.Indicaciones = indicaciones;
                    if (controlReceta.ModificarReceta(nueva)) //Asegurarse de que la receta se cree en ucReceta
                    {
                        MessageBox.Show("Receta Guardada con éxito", "Guardar Receta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvConsultas.Visible = false;
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                }
            }
        }
    }
}
