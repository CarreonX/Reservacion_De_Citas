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
    public partial class frmAdmin_ : Form
    {

        ControlAdministrador controlAdmin = new ControlAdministrador();
        Administrador Administrador = new Administrador();

        public frmAdmin_( int idx )
        {
            InitializeComponent();
            perzonalizarDiseño();
            Administrador = controlAdmin.ConsultarAdministrador( idx );
        }

        private void perzonalizarDiseño()
        {
            panelSubMenuReportes.Visible = false;
            panelSubMenuSeguridad.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;
            if (panelSubMenuSeguridad.Visible == true)
                panelSubMenuSeguridad.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region MenuReportes

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReportes);

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPrueba( 0 ));
            ocultarSubMenu();
        }

        private void btnConsultasMedicas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consultas Medicas");
            ocultarSubMenu();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Almacen");
            ocultarSubMenu();
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finanzas");
            ocultarSubMenu();
        }
        #endregion 

        #region MenuSeguridad

        private void btnSubMenuSeguridad_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuSeguridad);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuarios");
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles");
            ocultarSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Permisos");
            ocultarSubMenu();
        }
        #endregion

        private Form formularioActivo = null;

        private void abrirFormularioHijo( Form frmHijo )
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(frmHijo);
            panelFormulario.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }
    }
}
