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
    public partial class ucCita : UserControl
    {
        public Cita cita { get; set; }
        public ucCita( Cita cita )
        {
            InitializeComponent();
            this.cita = cita;
            llenarInformcion(cita);
        }

        public void llenarInformcion( Cita laCita )
        {
            txtDuracion.Text = laCita.Duracion.ToString();
            txtFechaCita.Text = laCita.Fecha.ToString();
            txtEstadoCita.Text = laCita.Estado;
            txtHora.Text = laCita.Hora.ToString();
            txtIdCita.Text = laCita.IDCita.ToString();
            txtPaciente.Text = laCita.IDPaciente.ToString();
            txtMotivo.Text = laCita.MotivoDeCita;
            txtNotas.Text = laCita.Nota;
            txtodontologo.Text = laCita.IDMedico.ToString();
            txtFechaSolicitud.Text = laCita.FechaDeGeneracion.ToString();
            modificarInformacion( true ); //No se podran modificar los datos
        }
        public ucCita()
        {
            InitializeComponent();
        }

        private void ucCita_Load(object sender, EventArgs e)
        {

        }

        public void modificarInformacion( bool bandera )
        {
            txtDuracion.ReadOnly = bandera;
            txtFechaCita.ReadOnly = bandera;
            txtEstadoCita.ReadOnly = bandera;
            txtHora.ReadOnly = bandera;
            txtPaciente.ReadOnly = bandera;
            txtMotivo.ReadOnly = bandera;
            txtNotas.ReadOnly = bandera;
            txtodontologo.ReadOnly = bandera;
            txtFechaSolicitud.ReadOnly = bandera;
        }

        public void Limpiar()
        {
            txtDuracion.Text = "";
            txtFechaCita.Text = "";
            txtEstadoCita.Text = "";
            txtHora.Text = "";
            txtIdCita.Text = "";
            txtPaciente.Text = "";
            txtMotivo.Text = "";
            txtNotas.Text = "";
            txtodontologo.Text = "";
            txtFechaSolicitud.Text = "";
        }
    }
}
