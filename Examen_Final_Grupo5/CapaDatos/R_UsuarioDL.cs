using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class R_UsuarioDL
    {
        // LISTAR USUAORIO DL 
        public List<R_Usuario> listar()
        {
            List<R_Usuario> lista = new List<R_Usuario>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ListarRegistro_Usuario";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new R_Usuario(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString()));// METODO DATA READER 
                        }
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }

            return lista;
        }


        // AGREGAR USUARIO DL 
        public string agregar(R_Usuario unUsuario)
        {
            string a = "";

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InsertarRegistro_Usuario";
                    cmd.Parameters.AddWithValue("@p_usuario", unUsuario.usuario);
                    cmd.Parameters.AddWithValue("@p_contrasenia", unUsuario.contrasenia);
                    cmd.Parameters.AddWithValue("@p_apepaterno", unUsuario.apepaterno);
                    cmd.Parameters.AddWithValue("@p_apematerno", unUsuario.apematerno);
                    cmd.Parameters.AddWithValue("@p_nombre", unUsuario.nombre);
                    cmd.Parameters.AddWithValue("@p_perfil", unUsuario.perfil);
                    cmd.Parameters.AddWithValue("@p_estado", unUsuario.estado);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Registro Agregado";
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }

            return a;
        }



        // ACTUALIZAR USUARIO - DL 
        public string actualizar(R_Usuario unUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {

                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarResgistro_Usuario";
                    cmd.Parameters.AddWithValue("@p_idusuario", unUsuario.idusuario);
                    cmd.Parameters.AddWithValue("@p_usuario", unUsuario.usuario);
                    cmd.Parameters.AddWithValue("@p_contrasenia", unUsuario.contrasenia);
                    cmd.Parameters.AddWithValue("@p_apepaterno", unUsuario.apepaterno);
                    cmd.Parameters.AddWithValue("@p_apematerno", unUsuario.apematerno);
                    cmd.Parameters.AddWithValue("@p_nombre", unUsuario.nombre);
                    cmd.Parameters.AddWithValue("@p_perfil", unUsuario.perfil);
                    cmd.Parameters.AddWithValue("@p_estado", unUsuario.estado);

                    // ABRIR CONEXION 
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Registro Actualizado";
                    }

                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return a;
        }



        // BUSCAR USUARIO DL

        public R_Usuario buscar(int id)
        {
            R_Usuario or_Usuario = null;

            using (SqlConnection cn = new ConexionBD().conectar())
            {

                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BuscarRegistro_Usuario";
                    cmd.Parameters.AddWithValue("@p_idusuario", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            or_Usuario = new R_Usuario(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());// METODO DATA READER 
                        }
                        else
                        {
                            or_Usuario = null;
                        }
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return or_Usuario;
        }



        // ELIMINAR USUARIO DL 
        public string eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_EliminarRegistro_Usuario";
                    cmd.Parameters.AddWithValue("@p_idusuario", id);

                    // abrir conexion
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Registro Eliminado";
                    }
                    // cerrar conexion
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return a;
        }
    }
}
