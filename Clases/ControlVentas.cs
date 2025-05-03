using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clases
{
    public class ControlVentas
    {
        private ValidarUsuario validarUsuario = new ValidarUsuario();

        public ControlVentas()
        {
        }
        public List<Venta> consultarVentas( int idx_caja )
        {
            List<Venta> listaVentas = new List<Venta>();

            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspConsultarVentas", validarUsuario.conn);
                validarUsuario.cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlParameter c_idx = new MySqlParameter("c_idx", MySqlDbType.Int32);
                c_idx.Value = idx_caja;
                MySqlDataReader reader = validarUsuario.cmd.ExecuteReader();

                while (validarUsuario.dr.Read())
                {
                    int idx = Convert.ToInt32(validarUsuario.dr["idx"]);
                    int cantidad = Convert.ToInt32(validarUsuario.dr["cantidad"]);
                    string nombreProducto = Convert.ToString(validarUsuario.dr["nombreProducto"]);
                    float precio = Convert.ToSingle(validarUsuario.dr["precio"]);
                    int idPaciente = Convert.ToInt32(validarUsuario.dr["idPaciente"]);
                    int idCajaRegistradora = Convert.ToInt32(validarUsuario.dr["idCajaRegistradora"]);

                    Venta venta = new Venta(idx, cantidad, nombreProducto, precio, idPaciente, idCajaRegistradora);
                    listaVentas.Add(venta);
                }
            }
            catch (MySqlException ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                if(validarUsuario.dr != null)
                {
                    validarUsuario.dr.Close();
                }
                validarUsuario.desconectar();
            }
            return listaVentas;
        }
        public Venta consultarVenta(int idVenta)
        {
            Venta venta = null;
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspConsultarVenta", validarUsuario.conn);
                validarUsuario.cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlParameter v_idx = new MySqlParameter("v_idx", MySqlDbType.Int32);
                v_idx.Value = idVenta;
                validarUsuario.cmd.Parameters.Add(v_idx);

                validarUsuario.dr = validarUsuario.cmd.ExecuteReader();

                if (validarUsuario.dr.Read())
                {
                    int idx = Convert.ToInt32(validarUsuario.dr["idx"]);
                    int cantidad = Convert.ToInt32(validarUsuario.dr["cantidad"]);
                    string nombreProducto = Convert.ToString(validarUsuario.dr["nombreProducto"]);
                    float precio = Convert.ToSingle(validarUsuario.dr["precio"]);
                    int idPaciente = Convert.ToInt32(validarUsuario.dr["idPaciente"]);
                    int idCajaRegistradora = Convert.ToInt32(validarUsuario.dr["idCajaRegistradora"]);

                    venta = new Venta(idx, cantidad, nombreProducto, precio, idPaciente, idCajaRegistradora);
                }
            }
            catch (MySqlException ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                if (validarUsuario.dr != null)
                {
                    validarUsuario.dr.Close();
                }
                validarUsuario.desconectar();
            }
            return venta;
        }

        public bool agregarVenta(Venta venta)
        {
            bool bandera = false;
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspModificarVenta", validarUsuario.conn);
                validarUsuario.cmd.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlParameter v_cantidad = new MySqlParameter("v_cantidad", MySqlDbType.Int32);
                v_cantidad.Value = venta.Cantidad;
                validarUsuario.cmd.Parameters.Add(v_cantidad);

                MySqlParameter v_nombreProducto = new MySqlParameter("v_nombreProducto", MySqlDbType.VarChar);
                v_nombreProducto.Value = venta.NombreProducto;
                validarUsuario.cmd.Parameters.Add(v_nombreProducto);

                MySqlParameter v_precio = new MySqlParameter("v_precio", MySqlDbType.Float);
                v_precio.Value = venta.Precio;
                validarUsuario.cmd.Parameters.Add(v_precio);

                MySqlParameter v_idPaciente = new MySqlParameter("v_idPaciente", MySqlDbType.Int32);
                v_idPaciente.Value = venta.IDPaciente;
                validarUsuario.cmd.Parameters.Add(v_idPaciente);

                MySqlParameter v_idCajaRegistradora = new MySqlParameter("v_idCajaRegistradora", MySqlDbType.Int32);
                v_idCajaRegistradora.Value = venta.IDCajaRegistradora;
                validarUsuario.cmd.Parameters.Add(v_idCajaRegistradora);

                int filasAfectadas = validarUsuario.cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    bandera = true;
                }
            }
            catch (MySqlException ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                validarUsuario.desconectar();
            }
            return bandera;
        }

        public bool eliminarVenta(int idVenta)
        {
            bool bandera = false;
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspEliminarVenta", validarUsuario.conn);
                validarUsuario.cmd.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlParameter v_idx = new MySqlParameter("v_idx", MySqlDbType.Int32);
                v_idx.Value = idVenta;
                validarUsuario.cmd.Parameters.Add(v_idx);
                int filasAfectadas = validarUsuario.cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    bandera = true;
                }
            }
            catch (MySqlException ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                validarUsuario.desconectar();
            }
            return bandera;
        }

        public bool modificarVenta( Venta venta)
        {
            bool bandera = false;
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspModificarVenta", validarUsuario.conn);
                validarUsuario.cmd.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlParameter v_idx = new MySqlParameter("v_idx", MySqlDbType.Int32);
                v_idx.Value = venta.IDx;
                validarUsuario.cmd.Parameters.Add(v_idx);
                MySqlParameter v_cantidad = new MySqlParameter("v_cantidad", MySqlDbType.Int32);
                v_cantidad.Value = venta.Cantidad;
                validarUsuario.cmd.Parameters.Add(v_cantidad);
                MySqlParameter v_nombreProducto = new MySqlParameter("v_nombreProducto", MySqlDbType.VarChar);
                v_nombreProducto.Value = venta.NombreProducto;
                validarUsuario.cmd.Parameters.Add(v_nombreProducto);
                MySqlParameter v_precio = new MySqlParameter("v_precio", MySqlDbType.Float);
                v_precio.Value = venta.Precio;
                validarUsuario.cmd.Parameters.Add(v_precio);
                MySqlParameter v_idPaciente = new MySqlParameter("v_idPaciente", MySqlDbType.Int32);
                v_idPaciente.Value = venta.IDPaciente;
                validarUsuario.cmd.Parameters.Add(v_idPaciente);
                MySqlParameter v_idCajaRegistradora = new MySqlParameter("v_idCajaRegistradora", MySqlDbType.Int32);
                v_idCajaRegistradora.Value = venta.IDCajaRegistradora;
                validarUsuario.cmd.Parameters.Add(v_idCajaRegistradora);
                int filasAfectadas = validarUsuario.cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    bandera = true;
                }
            }
            catch (MySqlException ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                validarUsuario.desconectar();
            }
            return bandera;
        }

    }
}
