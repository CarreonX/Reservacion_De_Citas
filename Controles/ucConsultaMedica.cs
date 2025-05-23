using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class ucConsultaMedica: UserControl
    {
        ControlPaciente controlPacientes = new ControlPaciente();
        ControlMedico controlMedico = new ControlMedico();
        public ConsultaMedica ConsultaMed { get; set; }
        public ucConsultaMedica()
        {
            InitializeComponent();
        }

        public void LlenarInformacion( ConsultaMedica consulta)
        {
            ConsultaMed = consulta;
            Medico medico = controlMedico.ConsultarMedico( ConsultaMed.IDDentista );
            txtDentista.Text = $"{medico.Nombre} {medico.ApellidoM} {medico.ApellidoP}";
            Paciente paciente = controlPacientes.ConsultarPaciente( ConsultaMed.IDPaciente );
            txtPaciente.Text = $"{paciente.Nombre} {paciente.ApellidoM} {paciente.ApellidoP}";
            txtIDReceta.Text = consulta.IDReceta.ToString();
            txtProximaCita.Text = consulta.IDProximaCita.ToString();
            txtDiagnostico.Text = consulta.Diagnostico;
            txtMotivoConsulta.Text = consulta.MotivoDeConsulta;
            dtpFechaConsulta.Value = consulta.Fecha.ToDateTime(TimeOnly.MinValue);
            txtIdConsulta.Text = consulta.IDConsulta.ToString();
        }

        public void ModificarInformacion( bool bandera )
        {
            txtIdConsulta.ReadOnly = bandera;
            txtIDReceta.ReadOnly = bandera;
            txtDentista.ReadOnly = bandera;
            txtMotivoConsulta.ReadOnly = bandera;
            txtDiagnostico.ReadOnly = bandera;
            txtPaciente.ReadOnly = bandera;
            txtProximaCita.ReadOnly = bandera;
            dtpFechaConsulta.Enabled = !bandera;
        }
    }
}
