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
    public partial class ucPreguntasHC : UserControl
    {
        ControlPreguntas controlPreguntasHC = new ControlPreguntas();
        bool modificar = false;
        bool agregar = false;
        public ucPreguntasHC()
        {
            InitializeComponent();
            LlenarInformacion();
        }

        public void LlenarInformacion()
        {
            List<PreguntaHistoriaClinica> listaPreguntas = controlPreguntasHC.ConsultarPreguntas();

            foreach (PreguntaHistoriaClinica pregunta in listaPreguntas)
            {
                ucPregunta preguntaControl = new ucPregunta();
                preguntaControl.LlenarPregunta(pregunta);
                preguntaControl.Dock = DockStyle.Top;
                preguntaControl.Height = 50;
                this.Controls.Add(preguntaControl);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            
            
        }
    }
}
