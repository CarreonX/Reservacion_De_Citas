using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Controles;

namespace Formularios
{
    public partial class frmCitas : Form
    {
        ControlCita controlCita = new ControlCita();
        List<Cita> listaCitas = new List<Cita>();
        string enteros = "^[0-9]*$";
        string nombres = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ ]*$";
        string Tipo;
        int idx;
        public frmCitas(int idx_Medico, string tipo)
        {
            InitializeComponent();
            idx = idx_Medico;
            Tipo = tipo;
            llenarListaCitas();
        }

        private void llenarListaCitas()
        {
            switch (Tipo)
            {
                case "dent":
                    listaCitas = controlCita.ConsultarCitasPorMedico(idx);
                    break;
                case "secre":
                    listaCitas = controlCita.ConsultarCitas();
                    break;
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            listaCitas.Clear(); // Limpiar la lista de citas antes de realizar la búsqueda
            string cadena = comboBox1.Text;

            Regex id = new Regex(enteros);
            Regex nombre = new Regex(nombres);

            if (id.IsMatch(cadena))
            {
                dataGridView1.DataSource = null;
                listaCitas.Add(controlCita.ConsultarCita(int.Parse(cadena)));
                List<Cita> nuevas = controlCita.ConsultarCitasPorMedico(int.Parse(cadena));
                foreach (Cita cita in nuevas)
                {
                    listaCitas.Add(cita);
                }
                nuevas.Clear();
                nuevas = controlCita.ConsultarCitasPorPaciente(int.Parse(cadena));
                foreach (Cita cita in nuevas)
                {
                    listaCitas.Add(cita);
                }
                comboBox1.DataSource = listaCitas;
                //comboBox1.Items = listaCitas;
                dataGridView1.DataSource = listaCitas;
            }
            else if (nombre.IsMatch(cadena))
            {
                lblMensajeBusqueda.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ucCita1.cita != null)
            {
                ucCita1.cita = null;
                ucCita1.Limpiar();
            }
            else
            {
                byte duracion = byte.Parse(ucCita1.txtIdCita.Text);
                string estado = ucCita1.txtEstadoCita.Text;
                DateOnly fecha = DateOnly.Parse(ucCita1.txtFechaCita.Text);
                DateOnly fechaDeGeneracion = DateOnly.Parse(ucCita1.txtFechaSolicitud.Text);
                TimeOnly hora = TimeOnly.Parse(ucCita1.txtHora.Text);
                int idMedico = int.Parse(ucCita1.txtodontologo.Text);
                int idPaciente = int.Parse(ucCita1.txtPaciente.Text);
                string motivo = ucCita1.txtMotivo.Text;
                string nota = ucCita1.txtNotas.Text;

                Cita nuevaCita = new Cita(duracion, estado, fecha, fechaDeGeneracion, hora, idMedico, idPaciente, motivo, nota);

                if (controlCita.AgregarCita(nuevaCita))
                {
                    MessageBox.Show("Cita agregada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar la cita");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCita = int.Parse(ucCita1.txtIdCita.Text);
            string respuesta = MessageBox.Show("¿Está seguro de que desea eliminar la cita?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch (respuesta)
            {
                case "Yes":
                    if (controlCita.EliminarCita(idCita))
                    {
                        MessageBox.Show("Cita eliminada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la cita");
                    }
                    break;
                case "No":
                    return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de que desea modificar la cita?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch (respuesta)
            {
                case "Yes":
                    int idCita = int.Parse(ucCita1.txtIdCita.Text);
                    byte duracion = byte.Parse(ucCita1.txtIdCita.Text);
                    string estado = ucCita1.txtEstadoCita.Text;
                    DateOnly fecha = DateOnly.Parse(ucCita1.txtFechaCita.Text);
                    DateOnly fechaDeGeneracion = DateOnly.Parse(ucCita1.txtFechaSolicitud.Text);
                    TimeOnly hora = TimeOnly.Parse(ucCita1.txtHora.Text);
                    int idMedico = int.Parse(ucCita1.txtodontologo.Text);
                    int idPaciente = int.Parse(ucCita1.txtPaciente.Text);
                    string motivo = ucCita1.txtMotivo.Text;
                    string nota = ucCita1.txtNotas.Text;
                    Cita nuevaCita = new Cita(idCita, duracion, estado, fecha, fechaDeGeneracion, hora, idMedico, idPaciente, motivo, nota);
                    if (controlCita.ModificarCita(nuevaCita))
                    {
                        MessageBox.Show("Cita modificada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la cita");
                    }
                    break;
                case "No":
                    return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
