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
        List<Cita> listaCitas = new List<Cita>();
        List<Cita>  todasLasCitas = new List<Cita>();
        List<ConsultaMedica> listaConsultas = new List<ConsultaMedica>();
        List<ConsultaMedica> todasLasConsultas = new List<ConsultaMedica>();
        public int IdDentista { get; set; }
        public string TipoUsuario { get; set; }

        public frmAgenda( int idx, string tipo )
        {
            InitializeComponent();
            llenarListas( false);
            IdDentista = idx;
            TipoUsuario = tipo;
        }

        public void llenarListas( bool bandera )
        {
            switch( TipoUsuario )
            {
                case "dent":
                    todasLasCitas = controlCita.ConsultarCitasPorMedico(IdDentista);
                    todasLasConsultas = controlConsulta.ConsultarConsultasMedicasPorMedico(IdDentista);
                    if (!bandera)
                    {
                        // formato para fechas: yyyy-MM-dd
                        // formato para fechaHora : yyyy-MM-dd HH:mm:ss

                        string fechaFormato = DateTime.Now.ToString("yyyy-MM-dd");
                        DateOnly fecha = DateOnly.ParseExact(fechaFormato, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        listaCitas = controlCita.ConsultarCitasPorFecha(fecha);
                        listaConsultas = controlConsulta.ConsultarConsultasMedicasPorFecha(fecha);
                    }
                    else
                    {
                        string fechaFormato = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                        DateOnly fecha = DateOnly.ParseExact(fechaFormato, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        listaCitas = controlCita.ConsultarCitasPorFecha(fecha);
                        listaConsultas = controlConsulta.ConsultarConsultasMedicasPorFecha(fecha);
                    }
                    break;
                default:
                    if (!bandera)
                    {
                        // formato para fechas: yyyy-MM-dd
                        // formato para fechaHora : yyyy-MM-dd HH:mm:ss

                        string fechaFormato = DateTime.Now.ToString("yyyy-MM-dd");
                        DateOnly fecha = DateOnly.ParseExact(fechaFormato, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        listaCitas = controlCita.ConsultarCitasPorFecha(fecha);
                        listaConsultas = controlConsulta.ConsultarConsultasMedicasPorFecha(fecha);
                    }
                    else
                    {
                        string fechaFormato = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                        DateOnly fecha = DateOnly.ParseExact(fechaFormato, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        listaCitas = controlCita.ConsultarCitasPorFecha(fecha);
                        listaConsultas = controlConsulta.ConsultarConsultasMedicasPorFecha(fecha);
                    }
                    todasLasCitas = controlCita.ConsultarCitas();
                    todasLasConsultas = controlConsulta.ConsultarConsultasMedicas();
                    break;
            }
        }

        private void llenarDGVs()
        {
            dgvCitas.Rows.Clear();
            dgvConsultas.Rows.Clear();

            if( listaCitas.Count > 0)
            {
                dgvCitas.DataSource = listaCitas;
            }
            else
            {
                lblNoCitas.Visible = true;
            }
            if( listaConsultas.Count > 0 )
            {
                dgvConsultas.DataSource = listaConsultas;
            }
            else
            {
                lblNoConsultas.Visible = true;
            }
            llenarCalendario(listaCitas, listaConsultas);
        }

        public void llenarCalendario( List<Cita> listaCitas, List<ConsultaMedica> consultasMedicas)
        {
            DateTime[] fechasCitas = new DateTime[listaCitas.Count + consultasMedicas.Count];
            foreach (Cita cita in listaCitas)
            {
                fechasCitas[listaCitas.IndexOf(cita)] = new DateTime(cita.Fecha.Year, cita.Fecha.Month, cita.Fecha.Day);
            }
            foreach (ConsultaMedica consulta in consultasMedicas)
            {
                fechasCitas[consultasMedicas.IndexOf(consulta) + listaCitas.Count] = new DateTime(consulta.Fecha.Year, consulta.Fecha.Month, consulta.Fecha.Day);
            }
            monthCalendar1.BoldedDates = fechasCitas;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            llenarListas(true);
            llenarDGVs();
        }
    }
}
