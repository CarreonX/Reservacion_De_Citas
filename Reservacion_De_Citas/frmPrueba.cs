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
    public partial class frmPrueba : Form
    {
        public frmPrueba( int a )
        {
            InitializeComponent();
            montarControl(a);
        }

        private void montarControl( int b )
        {
            switch( b)
            {
                /*case 1:
                    ucCita cita = new ucCita();

                */
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Se ingresó corrrextamente");
        }
    }
}
