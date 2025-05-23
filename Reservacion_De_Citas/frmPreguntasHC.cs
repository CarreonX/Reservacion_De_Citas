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
    public partial class frmPreguntasHC : Form
    {
        ControlPreguntas controlPreguntasHC = new ControlPreguntas();
        bool modificar = false;
        bool agregar = false;
        public frmPreguntasHC()
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
            agregar = true;
            flpTodasLasPreguntas.Controls.Clear();
            ucPregunta ucPregunta = new ucPregunta();
            ucPregunta.Dock = DockStyle.Top;
            ucPregunta.Height = 50;
            flpTodasLasPreguntas.Controls.Add(ucPregunta);
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de eliminar la pregunta?", "Eliminar Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch (respuesta)
            {
                case "Yes":
                    PreguntaHistoriaClinica pregunta = controlPreguntasHC.ConsultarPregunta(int.Parse(cbBusqueda.Text));
                    if (controlPreguntasHC.EliminarPregunta(int.Parse(cbBusqueda.Text)))
                    {
                        MessageBox.Show("Pregunta eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "No":
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            flpTodasLasPreguntas.Controls.Clear();
            ucPregunta ucPregunta = new ucPregunta();
            ucPregunta.Dock = DockStyle.Top;
            ucPregunta.Height = 50;
            PreguntaHistoriaClinica pregunta = controlPreguntasHC.ConsultarPregunta(int.Parse(cbBusqueda.Text));
            if (pregunta == null)
            {
                lblMensajeBusqueda.Text = "No se encontró la pregunta";
            }
            ucPregunta.LlenarPregunta(pregunta);
            flpTodasLasPreguntas.Controls.Add(ucPregunta);
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar || agregar)
            {
                string respuesta = MessageBox.Show("¿Está seguro de guardar los cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

                switch (respuesta)
                {
                    case "Yes":

                        if (agregar)
                        {
                            ucPregunta preg = flpTodasLasPreguntas.Controls[0] as ucPregunta;
                            string pregunta = preg.txtPregunta.Text;
                            PreguntaHistoriaClinica nuevaPregunta = new PreguntaHistoriaClinica(pregunta);
                            if (controlPreguntasHC.AgregarPregunta(nuevaPregunta))
                            {
                                MessageBox.Show("Pregunta agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar la pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            LlenarInformacion();
                            agregar = false;
                        }
                        if (modificar)
                        {
                            ucPregunta preg = flpTodasLasPreguntas.Controls[0] as ucPregunta;
                            PreguntaHistoriaClinica nuevaPregunta = preg.Pregunta;
                            if (controlPreguntasHC.ModificarPregunta(nuevaPregunta))
                            {
                                MessageBox.Show("Pregunta modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar la pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            LlenarInformacion();
                            modificar = false;
                        }
                        break;
                    case "No":
                        break;
                }
            }
        }
    }
}
