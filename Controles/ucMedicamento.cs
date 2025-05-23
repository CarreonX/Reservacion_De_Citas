using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Controles
{
    public partial class ucMedicamento : UserControl
    {
        public Medicamento Medicamento { get; set; }
        public ucMedicamento()
        {
            InitializeComponent();
        }

        public void LlenarInformacion(Medicamento medicamento)
        {
            Medicamento = medicamento;
            txtEstante.Text = medicamento.Estante;
            txtId.Text = medicamento.IDMedicamento.ToString();
            txtNombre.Text = medicamento.Nombre;
            txtDivicion.Text = medicamento.DivicionPisoEstante;
            txtCantidad.Text = medicamento.Cantidad.ToString();
            txtPiso.Text = medicamento.PisoEstante.ToString();
            txtPrecio.Text = medicamento.Precio.ToString();
            txtSeccion.Text = medicamento.Seccion;
            txtSubTotal.Text = medicamento.Subtotal.ToString();
            txtUnidadMedida.Text = medicamento.UnidadDeMedida;
        }

        public void ModificarInformacion(bool bandera)
        {
            txtUnidadMedida.ReadOnly = bandera;
            txtSubTotal.ReadOnly = bandera;
            txtCantidad.ReadOnly = bandera;
            txtPrecio.ReadOnly = bandera;
            txtPiso.ReadOnly = bandera;
            txtDivicion.ReadOnly = bandera;
            txtEstante.ReadOnly = bandera;
            txtNombre.ReadOnly = bandera;
            txtSeccion.ReadOnly = bandera;
        }

        public Medicamento ObtenerMedicamento()
        {
            string estante = txtEstante.Text;
            int idMedicamento = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            string divicion = txtDivicion.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int piso = Convert.ToInt32(txtPiso.Text);
            float precio = Convert.ToSingle(txtPrecio.Text);
            string seccion = txtSeccion.Text;
            string unidadMedida = txtUnidadMedida.Text;
            Medicamento medicamento = new Medicamento(idMedicamento, cantidad, divicion, estante, nombre, piso, precio, seccion, unidadMedida);
            return medicamento;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if( Analizador.EsDecimal(txtPrecio.Text) || txtPrecio.Text == string.Empty)
            {
                txtPrecio.BackColor = Color.White;
                txtSubTotal.Text = (float.Parse(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)).ToString();
            }
            else
            {
                txtPrecio.BackColor = Color.LightSalmon;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if( Analizador.EsEntero(txtCantidad.Text) || txtCantidad.Text == string.Empty)
            {
                txtCantidad.BackColor = Color.White;
                txtSubTotal.Text = (float.Parse(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)).ToString();
            }
            else
            {
                txtCantidad.BackColor = Color.LightSalmon;
            }
        }
    }
}
