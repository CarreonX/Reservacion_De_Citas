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
    public partial class frmConsultas : Form
    {
        ControlConsulta controlConsultas = new ControlConsulta();
        bool guardar = false;
        int idMedico;
        public frmConsultas( int IDMedico )
        {
            InitializeComponent();
            idMedico = IDMedico;
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvConsultas.Visible = false;
            int idColumnIndex = dgvConsultas.Columns["id"].Index;
            if (dgvConsultas.CurrentRow != null && dgvConsultas.CurrentRow.Cells[idColumnIndex].Value != null)
            {
                int idCelda = int.Parse(dgvConsultas.CurrentRow.Cells[idColumnIndex].Value.ToString());

                flpConsulta.Controls.Clear();

                ConsultaMedica consulta = controlConsultas.ConsultarConsultaMedica(idCelda);

                ucConsultaMedica ucConsultaMedica = new ucConsultaMedica();
                ucConsultaMedica.LlenarInformacion(consulta);
                flpConsulta.Controls.Add(ucConsultaMedica);
            }
            btnGuardar.Enabled = false;
            flpConsulta.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flpConsulta.Visible = true;
            flpConsulta.Controls.Clear();
            ucConsultaMedica ucConsulta = new ucConsultaMedica();
            ucConsulta.ModificarInformacion(false);
            flpConsulta.Controls.Add( ucConsulta );
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            guardar = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idx = -1;

            if( cbBusqueda.Text != string.Empty)
            {
                idx = int.Parse( cbBusqueda.Text );
            }
            else
            {
                if(flpConsulta.Controls[0] != null)
                {
                    ucConsultaMedica consulta = flpConsulta.Controls[0] as ucConsultaMedica;
                    idx = consulta.ConsultaMed.IDConsulta;
                }
                else
                {
                    MessageBox.Show( "No se seleccionó una consulta","Consulta no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            string respuesta = string.Empty;
            if (idx > -1)
            {
                respuesta = MessageBox.Show("¿Está seguro de eliminar la consulta médica?", "Eliminar Consulta Medica", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            }

            switch (respuesta)
            {
                case "Yes":
                    if (controlConsultas.EliminarConsulta( idx ))
                    {
                        dgvConsultas.Visible = true;
                        MessageBox.Show("Consulta médica eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la consulta médica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "No":
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idx = -1;

            if (cbBusqueda.Text != string.Empty)
            {
                idx = int.Parse(cbBusqueda.Text);
            }
            else
            {
                if (flpConsulta.Controls[0] != null)
                {
                    ucConsultaMedica consulta = flpConsulta.Controls[0] as ucConsultaMedica;
                    idx = consulta.ConsultaMed.IDConsulta;
                    consulta.ModificarInformacion(false);
                    flpConsulta.Controls.Clear();
                    flpConsulta.Controls.Add( consulta );
                }
                else
                {
                    MessageBox.Show("No se seleccionó una consulta", "Consulta no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            if ( guardar )
            {
                ucConsultaMedica laConsulta = flpConsulta.Controls[0] as ucConsultaMedica;
                string diagnostico = laConsulta.txtDiagnostico.Text;
                string motivo = laConsulta.txtMotivoConsulta.Text;
                DateOnly fecha = DateOnly.FromDateTime( laConsulta.dtpFechaConsulta.Value );
                int idMed = idMedico;
                int idPaciente = int.Parse(laConsulta.txtPaciente.Text);
                int idReceta = int.Parse(laConsulta.txtIDReceta.Text);
                TimeOnly hora = TimeOnly.FromDateTime(laConsulta.dtpFechaConsulta.Value);
                byte duracion = byte.Parse( laConsulta.txtDuracion.Text);
                ConsultaMedica cons = new ConsultaMedica( diagnostico, fecha, idMed, idPaciente, idReceta, motivo, hora, duracion );
                if( controlConsultas.AgregarConsulta( cons))
                {
                    MessageBox.Show( "Consulta guardada correctamente", "Guardado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardar = false;
                    laConsulta.ModificarInformacion(true);
                    flpConsulta.Controls.Clear();
                    flpConsulta.Controls.Add( laConsulta );
                }
                else
                {
                    MessageBox.Show("Consulta no se pudo guardar", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                ucConsultaMedica ucConsulta = flpConsulta.Controls[0] as ucConsultaMedica;
                string diagn = ucConsulta.txtDiagnostico.Text;
                string motivo = ucConsulta.txtMotivoConsulta.Text;
                DateOnly fecha = DateOnly.FromDateTime( ucConsulta.dtpFechaConsulta.Value);
                int idMed = idMedico;
                int idPaciente = int.Parse( ucConsulta.txtPaciente.Text );
                int idReceta = int.Parse(ucConsulta.txtIDReceta.Text );
                int idx = int.Parse( ucConsulta.txtIDReceta.Text );
                TimeOnly hora = TimeOnly.FromDateTime(ucConsulta.dtpFechaConsulta.Value);
                byte duracion = byte.Parse( ucConsulta.txtDuracion.Text);
                ConsultaMedica nueva = new ConsultaMedica( idx, diagn, fecha, idMed, idPaciente, idReceta, motivo, hora, duracion);
                if( controlConsultas.ModificarConsulta( nueva))
                {
                    MessageBox.Show("Consulta guardada correctamente", "Guardado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardar = false;
                    ucConsulta.ModificarInformacion(true);
                    flpConsulta.Controls.Clear();
                    flpConsulta.Controls.Add(ucConsulta);
                }
                else
                {
                    MessageBox.Show("Consulta no se pudo guardar", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
