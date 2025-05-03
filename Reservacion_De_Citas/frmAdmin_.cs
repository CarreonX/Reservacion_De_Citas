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
        private Administrador Administrador { get; set; }
        public frmAdmin_(int idx)
        {
            InitializeComponent();
            perzonalizarDiseño();
            Administrador = controlAdmin.ConsultarAdministrador(idx);
            if (Administrador != null)
            {
                lblBienvenida.Text = "Bienvenido " + Administrador.Nombre;
            }
            else
            {
                MessageBox.Show(controlAdmin.validarUsuario.mensaje);
            }
            lblFechaHota.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void perzonalizarDiseño()
        {
            panelSubMenuReportes.Visible = false;
            panelSubMenuUsuarios.Visible = false;
        }

        private void ocultarSubMenu( Panel panel )
        {
            if (panel.Visible == true)
                panel.Visible = false;
            if (panel.Visible == true)
                panel.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                ocultarSubMenu( subMenu );
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
            ocultarSubMenu( panelSubMenuReportes);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            ocultarSubMenu(panelSubMenuUsuarios);
            mostrarSubMenu(panelSubMenuReportes);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPrueba(0));
            ocultarSubMenu( panelSubMenuReportes );
        }

        private void btnConsultasMedicas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consultas Medicas");
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Almacen");
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finanzas");
        }
        #endregion 

        #region MenuSeguridad

        private void btnSubMenuSeguridad_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuUsuarios);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuarios");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Permisos");
        }
        #endregion

        private Form formularioActivo = null;

        private void abrirFormularioHijo(Form frmHijo)
        {
            if (formularioActivo != null)
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ocultarSubMenu(panelSubMenuReportes);
            mostrarSubMenu( panelSubMenuUsuarios);

        }
    }
}
