using Formularios;

namespace Reservacion_De_Citas
{
    public partial class Login : Form
    {
        ValidarUsuario validarUsuario = new ValidarUsuario();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (validarUsuario.validar(txtUsuario.Text, txtPass.Text))
            {
                switch (validarUsuario.tipo)
                {
                    case "admin":
                        // Abrir formulario de administrador
                        frmAdmin_ adminForm = new frmAdmin_(validarUsuario.indice);
                        adminForm.ShowDialog();
                        break;

                    case "secre":
                        // Abrir formulario de secretaria
                        frmSecretaria secreForm = new frmSecretaria(validarUsuario.indice);
                        secreForm.ShowDialog();
                        break;

                    case "dent":
                        // Abrir formulario de dentista
                        frmDentista dentForm = new frmDentista(validarUsuario.indice);
                        dentForm.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show(validarUsuario.mensaje);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
