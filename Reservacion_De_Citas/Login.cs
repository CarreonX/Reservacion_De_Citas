using Formularios;

namespace Reservacion_De_Citas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if( ValidarUsuario.validarUsuario(txtUsuario.Text, txtPass.Text))
            {
                switch( ValidarUsuario.tipo )
                {
                    case "admin":
                        // Abrir formulario de administrador
                        frmAdmin_ adminForm = new frmAdmin_(ValidarUsuario.indice);
                        adminForm.ShowDialog();
                        this.Hide();
                        break;

                    case "secre":
                        // Abrir formulario de secretaria
                        frmSecretaria secreForm = new frmSecretaria(ValidarUsuario.indice);
                        secreForm.ShowDialog();
                        this.Hide();
                        break;

                    case "dent":
                        // Abrir formulario de dentista
                        frmDentista dentForm = new frmDentista(ValidarUsuario.indice);
                        dentForm.ShowDialog();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show(ValidarUsuario.mensaje);
            }
        }
    }
}
