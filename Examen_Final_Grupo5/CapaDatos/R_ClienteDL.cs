using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class R_ClienteDL
    {

        // LISTAR  DL 
        public List<R_Cliente> listar()
        {
            List<R_Cliente> lista = new List<R_Cliente>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ListarRegistro_Cliente";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new R_Cliente(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString()));
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

        ///////////////////////////////////////////////////////////////////////////////////////////////

        // AGREGAR  DL 
        public string agregar(R_Cliente unCliente)
        {
            string a = "";

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InsertarRegistro_Cliente";

                    cmd.Parameters.AddWithValue("@p_Tipocliente", unCliente.Tipocliente);
                    cmd.Parameters.AddWithValue("@p_Tipodocumento", unCliente.Tipodocumento);
                    cmd.Parameters.AddWithValue("@p_Numerodocumento", unCliente.Numerodocumento);
                    cmd.Parameters.AddWithValue("@p_ApellidoPaterno", unCliente.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@p_ApellidoMaterno", unCliente.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@p_Nombre", unCliente.Nombre);
                    cmd.Parameters.AddWithValue("@p_Ruc", unCliente.Ruc);
                    cmd.Parameters.AddWithValue("@p_RazonSocial", unCliente.RazonSocial);
                    cmd.Parameters.AddWithValue("@p_Domicilio", unCliente.Domicilio);
                    cmd.Parameters.AddWithValue("@p_Departamento", unCliente.Departamento);
                    cmd.Parameters.AddWithValue("@p_Provincia", unCliente.Provincia);
                    cmd.Parameters.AddWithValue("@p_Distrito", unCliente.Distrito);
                    cmd.Parameters.AddWithValue("@p_Telefono1", unCliente.Telefono1);
                    cmd.Parameters.AddWithValue("@p_Celular", unCliente.Celular);
                    cmd.Parameters.AddWithValue("@p_Correo", unCliente.Correo);
                    cmd.Parameters.AddWithValue("@p_Moroso", unCliente.Moroso);
                    cmd.Parameters.AddWithValue("@p_Estado", unCliente.Estado);


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

        /////////////////////////////////////////////////////////////////////////////////////////////////

        // ACTUALIZAR  DL 
        public string actualizar(R_Cliente unCliente)
        {
            SqlCommand cmd = new SqlCommand();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {

                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarResgistro_Cliente";

                    cmd.Parameters.AddWithValue("@p_IdCliente", unCliente.IdCliente);
                    cmd.Parameters.AddWithValue("@p_Tipocliente", unCliente.Tipocliente);
                    cmd.Parameters.AddWithValue("@p_Tipodocumento", unCliente.Tipodocumento);
                    cmd.Parameters.AddWithValue("@p_Numerodocumento", unCliente.Numerodocumento);
                    cmd.Parameters.AddWithValue("@p_ApellidoPaterno", unCliente.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@p_ApellidoMaterno", unCliente.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@p_Nombre", unCliente.Nombre);
                    cmd.Parameters.AddWithValue("@p_Ruc", unCliente.Ruc);
                    cmd.Parameters.AddWithValue("@p_RazonSocial", unCliente.RazonSocial);
                    cmd.Parameters.AddWithValue("@p_Domicilio", unCliente.Domicilio);
                    cmd.Parameters.AddWithValue("@p_Departamento", unCliente.Departamento);
                    cmd.Parameters.AddWithValue("@p_Provincia", unCliente.Provincia);
                    cmd.Parameters.AddWithValue("@p_Distrito", unCliente.Distrito);
                    cmd.Parameters.AddWithValue("@p_Telefono1", unCliente.Telefono1);
                    cmd.Parameters.AddWithValue("@p_Celular", unCliente.Celular);
                    cmd.Parameters.AddWithValue("@p_Correo", unCliente.Correo);
                    cmd.Parameters.AddWithValue("@p_Moroso", unCliente.Moroso);
                    cmd.Parameters.AddWithValue("@p_Estado", unCliente.Estado);

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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // BUSCAR USUARIO DL

        public R_Cliente buscar(int id)
        {
            R_Cliente orCliente = null;

            using (SqlConnection cn = new ConexionBD().conectar())
            {

                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BuscarRegistro_Cliente";
                    cmd.Parameters.AddWithValue("@p_IdCliente", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            orCliente = new R_Cliente(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString());
                        }
                        else
                        {
                            orCliente = null;
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
            return orCliente;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // ELIMINAR  DL 
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
                    cmd.CommandText = "sp_EliminarRegistro_Cliente";
                    cmd.Parameters.AddWithValue("@p_IdCliente", id);

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
