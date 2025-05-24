using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmAgenda : Form
    {
        public ControlCita controlCita = new ControlCita();
        public ControlConsulta controlConsulta = new ControlConsulta();
        public ControlPaciente controlPaciente = new ControlPaciente();
        List<Cita> listaCitas = new List<Cita>();
        List<Cita> todasLasCitas = new List<Cita>();
        List<ConsultaMedica> listaConsultas = new List<ConsultaMedica>();
        List<ConsultaMedica> todasLasConsultas = new List<ConsultaMedica>();
        public int IdDentista { get; set; }
        public string TipoUsuario { get; set; }
        public DateOnly FechaSeleccionada { get; set; }

        public frmAgenda(int idx, string tipo)
        {
            InitializeComponent();
            if( idx > -1)
            {
                IdDentista = idx;
                TipoUsuario = tipo;
                llenarCalendario( IdDentista );
            }
            else
            {
                llenarCalendario(-1);
            }
        }

        public void llenarCalendario(int idx)
        {
            if (idx > -1)
            {
                todasLasConsultas = controlConsulta.ConsultarConsultasMedicasPorMedico( idx );
                todasLasCitas = controlCita.ConsultarCitasPorMedico( idx );

                List<DateTime> fechasCitas = new List<DateTime>();
                DateTime[] fechas = new DateTime[todasLasCitas.Count + todasLasConsultas.Count];
                foreach (Cita cita in todasLasCitas)
                {
                    fechasCitas.Add(new DateTime(cita.Fecha.Year, cita.Fecha.Month, cita.Fecha.Day));
                }
                foreach (ConsultaMedica consulta in todasLasConsultas)
                {
                    fechasCitas.Add(new DateTime(consulta.Fecha.Year, consulta.Fecha.Month, consulta.Fecha.Day));
                }
                int contador = 0;
                foreach (DateTime fecha in fechasCitas)
                {
                    fechas[contador] = fecha;
                }
                monthCalendar1.BoldedDates = fechas;
            }
            else
            {
                todasLasConsultas = controlConsulta.ConsultarConsultasMedicas();
                todasLasCitas = controlCita.ConsultarCitas();

                List<DateTime> fechasCitas = new List<DateTime>();
                DateTime[] fechas = new DateTime[todasLasCitas.Count + todasLasConsultas.Count];
                foreach (Cita cita in todasLasCitas)
                {
                    fechasCitas.Add(new DateTime(cita.Fecha.Year, cita.Fecha.Month, cita.Fecha.Day));
                }
                foreach (ConsultaMedica consulta in todasLasConsultas)
                {
                    fechasCitas.Add(new DateTime(consulta.Fecha.Year, consulta.Fecha.Month, consulta.Fecha.Day));
                }
                int contador = 0;
                foreach (DateTime fecha in fechasCitas)
                {
                    fechas[contador] = fecha;
                }
                monthCalendar1.BoldedDates = fechas;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            FechaSeleccionada = DateOnly.FromDateTime(monthCalendar1.SelectionStart);
            listaCitas = controlCita.ConsultarCitasPorFecha(FechaSeleccionada);
            listaConsultas = controlConsulta.ConsultarConsultasMedicasPorFecha(FechaSeleccionada);

            string salida = "";
            if (listaCitas.Count > 0)
            {
                foreach (Cita cita in listaCitas)
                {
                    Paciente paciente = controlPaciente.ConsultarPaciente(cita.IDPaciente);
                    salida = string.Format("{5}{0:D}-({1} {2})({3:HH:mm}-{4:HH:mm})\n", cita.IDCita, paciente.Nombre, paciente.ApellidoM, cita.Hora, cita.Hora.AddMinutes(cita.Duracion), salida);
                }
                txtCitas.Text = salida;
            }
            salida = "";
            if (listaConsultas.Count > 0)
            {
                foreach (ConsultaMedica consulta in listaConsultas)
                {
                    Paciente paciente = controlPaciente.ConsultarPaciente(consulta.IDPaciente);
                    salida = string.Format("{5}{0:D}-({1} {2})({3:HH:mm}-{4:HH:mm})\n", consulta.IDConsulta, paciente.Nombre, paciente.ApellidoM, consulta.Fecha, consulta.Hora, consulta.Hora.AddMinutes(consulta.Duracion));
                }
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }
    }
}
