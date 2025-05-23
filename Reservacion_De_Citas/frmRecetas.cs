using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;

namespace Formularios
{
    public partial class frmRecetas : Form
    {
        ControlReceta controlReceta = new ControlReceta();
        bool cambio = false;
        int idRecetaActual = -1;
        public frmRecetas()
        {
            InitializeComponent();
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvConsultas.Visible = true;
            List<Receta> recetas = new List<Receta>();
            List<Receta> recetasFiltradas = new List<Receta>();
            recetas = controlReceta.ConsultarRecetasPorMedico( int.Parse(cbBusqueda.Text));
            recetasFiltradas = controlReceta.ConsultarRecetasPorPaciente(int.Parse(cbBusqueda.Text));
            foreach( Receta receta in recetasFiltradas)
            {
                recetas.Add(receta);
            }
            dgvConsultas.DataSource = recetas;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvConsultas.Visible = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;

            ucReceta ucReceta = new ucReceta();
            ucReceta.Dock = DockStyle.Fill;
            ucReceta.ModificarInformacion( false );
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
