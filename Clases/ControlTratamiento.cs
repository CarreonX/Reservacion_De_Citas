using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Clases
{
    class ControlTratamiento
    {
        private ValidarUsuario validarUsuario = new ValidarUsuario();
        public ControlTratamiento()
        {
        }

        public bool AgregarTratamiento(Tratamiento tratamiento)
        {
            bool bandera = false;

            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspAgregarMedicamentoRecetado", validarUsuario.conn);
                validarUsuario.cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter t_cantidad = new MySqlParameter("mr_cantidad", MySqlDbType.Int32);
                t_cantidad.Value = tratamiento.Cantidad;
                validarUsuario.cmd.Parameters.Add(t_cantidad);

                MySqlParameter t_nombre = new MySqlParameter("mr_nombre", MySqlDbType.VarChar, 50);
                t_nombre.Value = tratamiento.Nombre;
                validarUsuario.cmd.Parameters.Add(t_nombre);

                MySqlParameter t_precio = new MySqlParameter("mr_precio", MySqlDbType.Float);
                t_precio.Value = tratamiento.PrecioUnitario;
                validarUsuario.cmd.Parameters.Add(t_precio);

                if (validarUsuario.cmd.ExecuteNonQuery() > 0)
                {
                    bandera = true;
                }
            }
            catch (Exception ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                validarUsuario.desconectar();
            }
            return bandera;
        }

        public bool ModificarTratamiento(Tratamiento tratamiento)
        {
            bool bandera = false;

            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspModificarMedicamentoRecetado", validarUsuario.conn);
                validarUsuario.cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter t_idx = new MySqlParameter("mr_idx", MySqlDbType.Int32);
                t_idx.Value = tratamiento.Cantidad;
                validarUsuario.cmd.Parameters.Add(t_idx);

                MySqlParameter t_cantidad = new MySqlParameter("mr_cantidad", MySqlDbType.Int32);
                t_cantidad.Value = tratamiento.Cantidad;
                validarUsuario.cmd.Parameters.Add(t_cantidad);

                MySqlParameter t_nombre = new MySqlParameter("mr_nombre", MySqlDbType.VarChar, 50);
                t_nombre.Value = tratamiento.Nombre;
                validarUsuario.cmd.Parameters.Add(t_nombre);

                MySqlParameter t_precio = new MySqlParameter("mr_precio", MySqlDbType.Float);
                t_precio.Value = tratamiento.PrecioUnitario;
                validarUsuario.cmd.Parameters.Add(t_precio);

                if (validarUsuario.cmd.ExecuteNonQuery() > 0)
                {
                    bandera = true;
                }
            }
            catch (Exception ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                validarUsuario.desconectar();
            }
            return bandera;
        }

        public bool EliminarTratamiento(int mr_idx)
        {
            bool bandera = false;
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspEliminarMedicamentoRecetado", validarUsuario.conn);
                validarUsuario.cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter t_idx = new MySqlParameter("mr_idx", MySqlDbType.Int32);
                t_idx.Value = mr_idx;
                validarUsuario.cmd.Parameters.Add(t_idx);
                if (validarUsuario.cmd.ExecuteNonQuery() > 0)
                {
                    bandera = true;
                }
            }
            catch (Exception ex)
            {
                validarUsuario.mensaje = ex.Message;
            }
            finally
            {
                validarUsuario.desconectar();
            }
            return bandera;
        }


        public List<Tratamiento> ConsultarTratamiento( int r_idx )
        {
            List<Tratamiento> lista = new List<Tratamiento>();
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspConsultarMedicamentoRecetado", validarUsuario.conn);
                validarUsuario.cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter t_idx = new MySqlParameter("mr_idx", MySqlDbType.Int32);
                t_idx.Value = r_idx;
                validarUsuario.cmd.Parameters.Add(t_idx);

                validarUsuario.dr = validarUsuario.cmd.ExecuteReader();
                while (validarUsuario.dr.Read())
                {
                    Tratamiento tratamiento = new Tratamiento(
                    Convert.ToInt32(validarUsuario.dr["idReceta"]),
                    Convert.ToInt32(validarUsuario.dr["cantidad"]),
                    Convert.ToString(validarUsuario.dr["nombre"]),
                    Convert.ToSingle(validarUsuario.dr["precioUnitario"])
                    );
                    lista.Add(tratamiento);
                }
            }
            catch (Exception ex)
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
            return lista;
        }

        public List<Tratamiento> ConsultarTratamientos()
        {
            List<Tratamiento> lista = new List<Tratamiento>();
            try
            {
                validarUsuario.conectar();
                validarUsuario.cmd = new MySqlCommand("uspConsultarMedicamentosRecetados", validarUsuario.conn);
                validarUsuario.cmd.CommandType = CommandType.StoredProcedure;
                validarUsuario.dr = validarUsuario.cmd.ExecuteReader();
                while (validarUsuario.dr.Read())
                {
                    Tratamiento tratamiento = new Tratamiento(
                    Convert.ToInt32(validarUsuario.dr["idReceta"]),
                    Convert.ToInt32(validarUsuario.dr["cantidad"]),
                    Convert.ToString(validarUsuario.dr["nombre"]),
                    Convert.ToSingle(validarUsuario.dr["precioUnitario"])
                    );
                    lista.Add(tratamiento);
                }
            }
            catch (Exception ex)
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
            return lista;
        }
    }
}
