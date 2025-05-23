using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Controles
{
    public partial class ucPaciente : UserControl
    {
        public Paciente paciente { get; set; }
        ControlRespuestasClinicas controlRespuestasClinicas = new ControlRespuestasClinicas();
        public ucPaciente()
        {
            InitializeComponent();
        }

        public ucPaciente(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            LlenarInformacion(paciente);
        }

        public void LlenarInformacion(Paciente paciente)
        {
            txtNotasMedicas.Text = paciente.Notas;
            txtAlergias.Text = paciente.Alergias;
            txtApellidoM.Text = paciente.ApellidoM;
            txtApellidoP.Text = paciente.ApellidoP;
            txtDireccion.Text = paciente.Direccion;
            txtEmail.Text = paciente.Email;
            txtNombre.Text = paciente.Nombre;
            txtTelefonoFijo.Text = paciente.TelefonoFijo;
            txtTelefonoMovil.Text = paciente.TelefonoMovil;
            txtId.Text = paciente.IdPersona.ToString();
            txtPeso.Text = paciente.Peso.ToString();
            txtTalla.Text = paciente.Talla.ToString();
            txtIMC.Text = paciente.IMC.ToString();
            txtEdad.Text = paciente.Edad.ToString();
            dtpFechaNacimiento.Value = paciente.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
            List<RespuestasClinicas> respuestas = controlRespuestasClinicas.ConsultarRespuestas(paciente.IdPersona);
            gdvPreguntasHC.DataSource = respuestas;
            ModificarInformacion(true);
        }

        public void ModificarInformacion(bool bandera)
        {
            txtAlergias.ReadOnly = bandera;
            txtApellidoM.ReadOnly = bandera;
            txtApellidoP.ReadOnly = bandera;
            txtDireccion.ReadOnly = bandera;
            txtEdad.ReadOnly = bandera;
            txtNombre.ReadOnly = bandera;
            txtTelefonoFijo.ReadOnly = bandera;
            txtTelefonoMovil.ReadOnly = bandera;
            txtEmail.ReadOnly = bandera;
            txtPeso.ReadOnly = bandera;
            txtTalla.ReadOnly = bandera;
            txtIMC.ReadOnly = bandera;
            txtNotasMedicas.ReadOnly = bandera;
            dtpFechaNacimiento.Enabled = !bandera;
        }

        public void LimpiarInformacion()
        {
            txtNotasMedicas.Text = String.Empty;
            txtAlergias.Text = String.Empty;
            txtApellidoM.Text = String.Empty;
            txtApellidoP.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtTelefonoFijo.Text = String.Empty;
            txtTelefonoMovil.Text = String.Empty;
            txtId.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtTalla.Text = String.Empty;
            txtIMC.Text = String.Empty;
            txtEdad.Text = String.Empty;
        }
    }   
}
