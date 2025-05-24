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
using Mysqlx.Session;

namespace Controles
{
    public partial class ucReceta : UserControl
    {
        ControlPaciente controlPaciente = new ControlPaciente();
        ControlMedico controlMedico = new ControlMedico();
        ControlTratamiento controlTratamiento = new ControlTratamiento();
        ControlReceta controlReceta = new ControlReceta();
        List<Paciente> pacientes = new List<Paciente>();
        bool matchPaciente = false;
        int idOdontologo = -1;
        int idRecetaActual = -1;
        int idPacienteActual = -1;
        public Receta laReceta { get; set; }
        public ucReceta( int idOdontologo )
        {
            InitializeComponent();
            flpTratamiento.Dock = DockStyle.Fill;
            if (idOdontologo > -1)
            {
                this.idOdontologo = idOdontologo;
                LlenarInformacion(idOdontologo);
            }
        }

        public void ModificarInformacion(bool modificar)
        {
            txtIndicaciones.Enabled = modificar;
            dgvMedicamentos.Enabled = modificar;
            cbPaciente.Enabled = modificar;
        }

        public void LlenarInformacion( int idMedico )// Para nuevas recetas
        {
            Medico odontologo = controlMedico.ConsultarMedico(idMedico);
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            txtFecha.Text = hoy.ToString("dd/MM/yyyy");
            txtIndicaciones.Text = string.Empty;
            txtOdontologo.Text = $"{odontologo.IdPersona}-{odontologo.Nombre} {odontologo.ApellidoM} {odontologo.ApellidoP}";
        }

        public void LlenarInformacion(Receta receta) //Para recetas existentes
        {
            laReceta = receta;
            Medico odontologo = controlMedico.ConsultarMedico(receta.IDMedico);
            Paciente paciente = controlPaciente.ConsultarPaciente(receta.IDPaciente);
            txtFecha.Text = receta.Fecha.ToString("dd/MM/yyyy");
            txtIndicaciones.Text = receta.Indicaciones;
            txtOdontologo.Text = $"{odontologo.IdPersona}-{odontologo.Nombre} {odontologo.ApellidoM} {odontologo.ApellidoP}";
            cbPaciente.Text = $"{paciente.IdPersona}-{paciente.Nombre} {paciente.ApellidoM} {paciente.ApellidoP}";
            List<Tratamiento> tratamientos = controlTratamiento.ConsultarTratamiento(receta.IdReceta);
            ModificarInformacion(false);
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string respuesta = MessageBox.Show("¿Desea realizar cambios al tratamiento?", "Realizar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (respuesta == "Yes")
            {
                flpTratamiento.Enabled = true;
                btnAtras.Visible = true;
                flpTratamiento.Controls.Clear();
                ucTratamiento tratamiento = new ucTratamiento(laReceta.IdReceta);
                tratamiento.Dock = DockStyle.Fill;
                tratamiento.LlenarInformacion(laReceta.IdReceta);
                flpTratamiento.Controls.Add(tratamiento);
                flpTratamiento.Visible = true;
            }
        }

        private void dgvMedicamentos_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.DataSource == null)
            {

                flpTratamiento.Enabled = true;
                flpTratamiento.Visible = true;
                btnAtras.Visible = true;
                DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
                if( controlReceta.AgregarReceta( new Receta(hoy, idOdontologo, idPacienteActual, txtIndicaciones.Text, -1)))
                {
                    int idUltimaReceta = controlReceta.ConsultarIDUltimaReceta();
                    flpTratamiento.Controls.Clear();
                    ucTratamiento tratamiento = new ucTratamiento( idUltimaReceta );
                    tratamiento.Dock = DockStyle.Fill;
                    flpTratamiento.Controls.Add(tratamiento);
                }
                
            }
            else
            {
                string respuesta = MessageBox.Show("¿Desea realizar cambios al tratamiento?", "Realizar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (respuesta == "Yes")
                {
                    flpTratamiento.Enabled = true;
                    btnAtras.Visible = true;
                    flpTratamiento.Controls.Clear();
                    ucTratamiento tratamiento = new ucTratamiento(laReceta.IdReceta);
                    tratamiento.Dock = DockStyle.Fill;
                    tratamiento.LlenarInformacion(laReceta.IdReceta);
                    flpTratamiento.Controls.Add(tratamiento);
                    flpTratamiento.Visible = true;
                }
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            flpTratamiento.Controls.Clear();
            flpTratamiento.Visible = false;
            btnAtras.Visible = false;
            btnAtras.Enabled = false;
            flpTratamiento.Enabled = false;
        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPaciente.SelectedItem != null)
            {
                matchPaciente = true;
                idPacienteActual = int.Parse(cbPaciente.SelectedItem.ToString().Split('-')[0]);
            }
        }

        private void cbPaciente_TextChanged(object sender, EventArgs e)
        {
            pacientes = controlPaciente.ConsultarPacientesPorNombre(cbPaciente.Text, idOdontologo );
            cbPaciente.Items.Clear();
            foreach (Paciente paciente in pacientes)
            {
                if (paciente != null)
                {
                    cbPaciente.Items.Add($"{paciente.IdPersona}-{paciente.Nombre} {paciente.ApellidoM} {paciente.ApellidoP}");
                }
            }
            cbPaciente.DroppedDown = true;
        }
    }
}
