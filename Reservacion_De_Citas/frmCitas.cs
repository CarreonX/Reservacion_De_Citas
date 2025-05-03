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

namespace Formularios
{
    public partial class frmCitas : Form
    {
        ControlCita controlCita = new ControlCita();
        List<Cita> listaCitas = new List<Cita>();
        string enteros = "^[0-9]*$";
        string nombres = "^[a-zA-ZñÑáéíóúÁÉÍÓÚ ]*$";
        public frmCitas()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            listaCitas.Clear(); // Limpiar la lista de citas antes de realizar la búsqueda
            string cadena = comboBox1.Text;

            Regex id = new Regex(enteros);
            Regex nombre = new Regex(nombres);

            if(id.IsMatch(cadena))
            {
                listaCitas = controlCita.ConsultarCitasPorMedico(int.Parse(cadena));
                listaCitas.Add(controlCita.ConsultarCita(int.Parse(cadena)));
            }
            else if (nombre.IsMatch(cadena))
            {
                // Si la cadena es un nombre, se permite
                // Aquí puedes agregar la lógica que necesites
            }
            else
            {
                // Si no es ni un número ni un nombre, se muestra un mensaje de error
                MessageBox.Show("El campo solo acepta números o letras.");
                comboBox1.Text = "";
            }
        }
    }
}
