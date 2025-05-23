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
    public partial class ucPresupuesto : UserControl
    {
        ControlMedico controlMedico = new ControlMedico();
        ControlPaciente controlPaciente = new ControlPaciente();
        ControlTratamiento controlTratamiento = new ControlTratamiento();
        public Presupuesto ElPresupuesto { get; set; }
        public ucPresupuesto()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void ModificarInformacion( bool bandera)
        {
            txtTipoTrabajo.ReadOnly = bandera;
            txtUbicacionBoca.ReadOnly = bandera;
        }

        public Presupuesto ObtenerPresupuesto()
        { 
            int idx = int.Parse( txtId.Text);
            DateTime dateTime = DateTime.Parse(txtFechaHora.Text);
            int idmedico = ElPresupuesto.IDMedico;
            int idpaciente = ElPresupuesto.IDPaciente;
            int idtratamiento = ElPresupuesto.IDTratamaiento;
            string tipo = txtTipoTrabajo.Text;
            string ubicacion = txtUbicacionBoca.Text;
            Presupuesto presupuesto = new Presupuesto(idx, dateTime, idmedico, idpaciente, idtratamiento, tipo, ubicacion);
            return presupuesto;
        }
        public void LlenarInformaicon(Presupuesto presupuesto)
        {
            ElPresupuesto = presupuesto;
            Medico dentista = controlMedico.ConsultarMedico(presupuesto.IDMedico);
            Paciente paciente = controlPaciente.ConsultarPaciente(presupuesto.IDPaciente);

            txtFechaHora.Text = presupuesto.HoraFechaPresupuesto.ToString("dd/MM/yyyy HH:mm:ss");
            txtPaciente.Text = $"{paciente.Nombre} {paciente.ApellidoM} {paciente.ApellidoP}";
            txtOdontologo.Text = $"{dentista.Nombre} {dentista.ApellidoM} {dentista.ApellidoP}";
            txtFechaHora.Text = presupuesto.HoraFechaPresupuesto.ToString("dd/MM/yyyy HH:mm:ss");
            txtId.Text = presupuesto.IDPresupuesto.ToString();
            txtTipoTrabajo.Text = presupuesto.TipoTrabajo;
            txtUbicacionBoca.Text = presupuesto.UbicacionBoca;
            txtMontoTotal.Text = presupuesto.MontoTotal.ToString("C");

            List<Tratamiento> tratamientos = controlTratamiento.ConsultarTratamiento(presupuesto.IDTratamaiento);
            dgvTratamiento.Rows.Clear();
            dgvTratamiento.Columns.Clear();
            dgvTratamiento.DataSource = tratamientos;
        }
    }
}
