using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MoviProovedorDL
    {
        //listar MoviProovedor

        public List<MoviProovedor> listar()
        {
            List<MoviProovedor> lista = new List<MoviProovedor>();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_listamoviPro";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            lista.Add(new MoviProovedor(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                reader[4].ToString(), reader[5].ToString(), double.Parse(reader[6].ToString())));
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

        // agregar movi proovedor
        public string agregar(MoviProovedor unminiproovedor)
        {
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_insertarmovi";
                    cmd.Parameters.AddWithValue("@p_fecha", unminiproovedor.fecha);
                    cmd.Parameters.AddWithValue("@p_concepto", unminiproovedor.concepto);
                    cmd.Parameters.AddWithValue("@p_tipomov", unminiproovedor.tipomovimiento);
                    cmd.Parameters.AddWithValue("@p_tipomon", unminiproovedor.tipomoneda);
                    cmd.Parameters.AddWithValue("@p_importe", unminiproovedor.importe);
                    cmd.Parameters.AddWithValue("@p_nota", unminiproovedor.nota);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Movimiento de Proovedor agregado con exito";

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


        // actualizar movi proovedor
        public string actualizar(MoviProovedor unminiproovedor)
        {
            SqlCommand cmd = new SqlCommand();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_actualizarmovi";
                    cmd.Parameters.AddWithValue("@p_idmProovedor", unminiproovedor.idmProovedor);
                    cmd.Parameters.AddWithValue("@p_concepto", unminiproovedor.concepto);
                    cmd.Parameters.AddWithValue("@p_tipomov", unminiproovedor.tipomovimiento);
                    cmd.Parameters.AddWithValue("@p_tipomon", unminiproovedor.tipomoneda);
                    cmd.Parameters.AddWithValue("@p_importe", unminiproovedor.importe);
                    cmd.Parameters.AddWithValue("@p_nota", unminiproovedor.nota);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "Movimiento proovedor actualizado con exito";

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

        // buscar movi proovedor
        public MoviProovedor buscar(int id)
        {
            MoviProovedor or_Movi = null;
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_buscarmovi";
                    cmd.Parameters.AddWithValue("@p_idmProovedor", id);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            or_Movi = new MoviProovedor(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                                dr[4].ToString(), dr[5].ToString(), double.Parse(dr[6].ToString()));

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


        //eliminar movi proovedor

        public string eliminar (int id)
        {
            SqlCommand cmd = new SqlCommand ();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_eliminarmovi";
                    cmd.Parameters.AddWithValue("@p_idmProovedor", id);

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
                    cn.Dispose ();
                }
            }
            return a;
        }
 

    }
}
