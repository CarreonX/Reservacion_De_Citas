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
    public partial class ucPregunta : UserControl
    {
        ControlPreguntas controlPreguntas = new ControlPreguntas();
        public PreguntaHistoriaClinica Pregunta { get; set; }
        public bool Cambio { get; set; }
        public ucPregunta()
        {
            InitializeComponent();
            Cambio = false;
        }

        public void LlenarPregunta(PreguntaHistoriaClinica pregunta)
        {
            Pregunta.IdPregunta = pregunta.IdPregunta;
            Pregunta.Pregunta = pregunta.Pregunta;
            txtPregunta.Text = pregunta.Pregunta;
            rbSi.Checked = false;
            rbNo.Checked = false;
            txtArgumento.Text = String.Empty;
        }

        public void LlenarRespuesta(RespuestasClinicas respuesta)
        {
            txtPregunta.Text = controlPreguntas.ConsultarPregunta(respuesta.IdPregunta).Pregunta;

            string cadena = respuesta.Respuesta.Substring(1);
            switch (cadena)
            {
                case "si":
                case "Si":
                case "SI":

                    rbSi.Checked = true;
                    rbNo.Checked = false;
                    break;

                case "no":
                case "No":
                case "NO":
                    rbSi.Checked = false;
                    rbNo.Checked = true;
                    break;

                default:
                    MessageBox.Show("Error en la respuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            txtArgumento.Text = respuesta.Respuesta.Substring(1, respuesta.Respuesta.Length);
            lblIdPregunta.Text = respuesta.IdPregunta.ToString();
        }
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            rbNo.Checked = true;
            rbSi.Checked = false;
            Cambio = true;
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            rbNo.Checked = false;
            rbSi.Checked = true;
            Cambio = true;
        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {
            Cambio = true;
        }

        private void txtArgumento_TextChanged(object sender, EventArgs e)
        {
            Cambio = true;
        }
    }
}
