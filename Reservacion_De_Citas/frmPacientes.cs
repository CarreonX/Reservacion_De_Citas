using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formularios
{
    public partial class frmPacientes : Form
    {
        public int idMedico { get; set; }
        ControlPaciente controlPaciente = new ControlPaciente();
        string enteros = "^[0-9]*$";
        string nombres = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ ]*$";
        bool bandera = false;
        public frmPacientes(int idMedico)
        {
            InitializeComponent();
            this.idMedico = idMedico;
            LlenarListaPacientes();
        }

        public void LlenarListaPacientes()
        {
            List<Paciente> pacientes = controlPaciente.ConsultarPacientes(idMedico);
            dgvPacientes.DataSource = pacientes;
        }

        private void cbBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Paciente> listaCitas = new List<Paciente>();
            string cadena = cbBusqueda.Text;

            Regex id = new Regex(enteros);
            Regex nombre = new Regex(nombres);

            if (id.IsMatch(cadena))
            {
                dgvPacientes.DataSource = null;
                listaCitas.Add(controlPaciente.ConsultarPaciente(int.Parse(cadena)));
                dgvPacientes.DataSource = listaCitas;
            }
            else if (nombre.IsMatch(cadena))
            {
                lblMensajeBusqueda.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Instancias de un nuevo paciente 
            string apellidoP = ucPaciente1.txtApellidoP.Text;
            string apellidoM = ucPaciente1.txtApellidoM.Text;
            string nombre = ucPaciente1.txtNombre.Text;
            string direccion = ucPaciente1.txtDireccion.Text;
            string email = ucPaciente1.txtEmail.Text;
            string telF = ucPaciente1.txtTelefonoFijo.Text;
            string telM = ucPaciente1.txtTelefonoMovil.Text;
            DateOnly fechaNacimiento = DateOnly.Parse(ucPaciente1.dtpFechaNacimiento.Value.ToString());
            int idPreguntasHistoria = -1;
            string notas = ucPaciente1.txtNotasMedicas.Text;
            float peso = float.Parse(ucPaciente1.txtPeso.Text);
            float talla = float.Parse(ucPaciente1.txtTalla.Text);
            string alergias = ucPaciente1.txtAlergias.Text;
            Paciente nuevoPaciente = new Paciente(apellidoP, apellidoM, direccion, email, nombre, telF, telM, fechaNacimiento, idPreguntasHistoria, notas, peso, talla, alergias);

            if(controlPaciente.AgregarPaciente(nuevoPaciente))
            {
                MessageBox.Show("Paciente agregado correctamente");
                LlenarListaPacientes();
                ucPaciente1.Visible = false;

                int ultimo = controlPaciente.UltimoRegistro();

                if (ultimo >= 0)
                {
                    ucPaciente1.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Error al agregar el paciente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch(respuesta)
            {
                case "Yes":
                    int idPaciente = int.Parse(ucPaciente1.txtId.Text);
                    if (controlPaciente.EliminarPaciente(idPaciente))
                    {
                        MessageBox.Show("Paciente eliminado correctamente");
                        LlenarListaPacientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el paciente");
                    }
                    break;
                case "No":
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string respuesta = MessageBox.Show("¿Está seguro de que desea modificar el paciente?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            switch( respuesta)
            {
                case "Yes":
                    int idPaciente = int.Parse(ucPaciente1.txtId.Text);
                    string apellidoP = ucPaciente1.txtApellidoP.Text;
                    string apellidoM = ucPaciente1.txtApellidoM.Text;
                    string nombre = ucPaciente1.txtNombre.Text;
                    string direccion = ucPaciente1.txtDireccion.Text;
                    string email = ucPaciente1.txtEmail.Text;
                    string telF = ucPaciente1.txtTelefonoFijo.Text;
                    string telM = ucPaciente1.txtTelefonoMovil.Text;
                    DateOnly fechaNacimiento = DateOnly.Parse(ucPaciente1.dtpFechaNacimiento.Value.ToString());
                    int idPreguntasHistoria = 0;
                    string notas = ucPaciente1.txtNotasMedicas.Text;
                    float peso = float.Parse(ucPaciente1.txtPeso.Text);
                    float talla = float.Parse(ucPaciente1.txtTalla.Text);
                    string alergias = ucPaciente1.txtAlergias.Text;
                    Paciente pacienteModificado = new Paciente(idPaciente, apellidoP, apellidoM, direccion, email, nombre, telF, telM, fechaNacimiento, idPreguntasHistoria, notas, peso, talla, alergias);
                    if (controlPaciente.ModificarPaciente(pacienteModificado))
                    {
                        MessageBox.Show("Paciente modificado correctamente");
                        LlenarListaPacientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el paciente");
                    }
                    break;
                case "No":
                    break;
            }
        }
    }
}
