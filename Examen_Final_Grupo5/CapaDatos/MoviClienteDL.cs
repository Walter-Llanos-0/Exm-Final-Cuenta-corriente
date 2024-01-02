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
    public class MoviClienteDL
    {
       
        /// /listar
       

        public List<MoviCliente> listar()
        {
            List<MoviCliente> lista = new List<MoviCliente>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_listamovicli";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new MoviCliente(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),
                                reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));


                        }
                        cn.Close();

                    }
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

        //agregar

        public string agregar(MoviCliente unminicli)
        {
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_insertarmovicli";
                    cmd.Parameters.AddWithValue("@p_fecha", unminicli.Fecha);
                    cmd.Parameters.AddWithValue("@p_concepto", unminicli.Concepto);
                    cmd.Parameters.AddWithValue("@p_nota", unminicli.Nota);
                    cmd.Parameters.AddWithValue("@p_tipomov", unminicli.Tipomovimiento);
                    cmd.Parameters.AddWithValue("@p_tipomon", unminicli.Tipomoneda);
                    cmd.Parameters.AddWithValue("@p_importe", unminicli.Importe);
                    cmd.Parameters.AddWithValue("@p_idCliente", unminicli.IdCliente);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Movimiento de Cliente agregado con exito";

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

        //actualizar

        public string actualizar(MoviCliente unminicli)
        {
            SqlCommand cmd = new SqlCommand();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_actualizarmovicli";
                    cmd.Parameters.AddWithValue("@p_idmCliente", unminicli.IdMoviCliente);
                    cmd.Parameters.AddWithValue("@p_fecha", unminicli.Fecha);
                    cmd.Parameters.AddWithValue("@p_concepto", unminicli.Concepto);
                    cmd.Parameters.AddWithValue("@p_nota", unminicli.Nota);
                    cmd.Parameters.AddWithValue("@p_tipomov", unminicli.Tipomovimiento);
                    cmd.Parameters.AddWithValue("@p_tipomon", unminicli.Tipomoneda);
                    cmd.Parameters.AddWithValue("@p_importe", unminicli.Importe);
                    cmd.Parameters.AddWithValue("@p_idCliente", unminicli.IdCliente);
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Movimiento cliente actualizado con exito";

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


        // buscar

        public MoviCliente buscar(int id)
        {
            MoviCliente or_Movi = null;
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_buscarmovicli";
                    cmd.Parameters.AddWithValue("@p_idmCliente", id);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            or_Movi = new MoviCliente(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(),
                                dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),
                                dr[7].ToString());


                        }
                        else
                        {
                            or_Movi = null;
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

            return or_Movi;
        }


        //eliminar 


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
                    cmd.CommandText = "sp_eliminarmovicli";
                    cmd.Parameters.AddWithValue("@p_idmCliente", id);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {

                        a = "REGISTRO ELIMINADO";

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








    }
}
