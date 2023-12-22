using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace CapaDatos
{
    public class R_ProovedorDL
    {
        //listar Proovedor

        public List <R_Proovedor> listar ()
        {
            List<R_Proovedor> lista = new List<R_Proovedor> ();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_listaProveedor";
                    cn.Open ();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new R_Proovedor(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),
                                reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(),
                                reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), int.Parse(reader[17].ToString()),
                                int.Parse(reader[18].ToString()), reader[19].ToString()));

                        }


                    }
                    cn.Close ();


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

            return lista;


        }

        // AGREGAR PROVEEDOR

        public string agregar (R_Proovedor unProovedor)
        {
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                       SqlCommand cmd = new SqlCommand();
                       cmd.Connection = cn;
                       cmd.CommandType = CommandType.StoredProcedure;
                       cmd.CommandText = "sp_insertarProveedor";
                       cmd.Parameters.AddWithValue("@p_tipoPro", unProovedor.tipopro);
                       cmd.Parameters.AddWithValue("@p_tipoDoc", unProovedor.tipodoc);
                       cmd.Parameters.AddWithValue("@p_numeroDoc", unProovedor.numerodoc);
                       cmd.Parameters.AddWithValue("@p_apePat", unProovedor.apepat);
                       cmd.Parameters.AddWithValue("@p_apeMat", unProovedor.apemat);
                       cmd.Parameters.AddWithValue("@p_nombre", unProovedor.nombre);
                       cmd.Parameters.AddWithValue("@p_ruc", unProovedor.ruc);
                       cmd.Parameters.AddWithValue("@p_razon", unProovedor.razon);
                       cmd.Parameters.AddWithValue("@p_domi", unProovedor.domicilio);
                       cmd.Parameters.AddWithValue("@p_depar", unProovedor.departamento);
                       cmd.Parameters.AddWithValue("@p_provi", unProovedor.provincia);
                       cmd.Parameters.AddWithValue("@p_dist", unProovedor.distrito);
                       cmd.Parameters.AddWithValue("@p_tele", unProovedor.telefono);
                       cmd.Parameters.AddWithValue("@p_contacto", unProovedor.contacto);
                       cmd.Parameters.AddWithValue("@p_correo", unProovedor.correo);
                       cmd.Parameters.AddWithValue("@p_bancofina", unProovedor.banco);
                       cmd.Parameters.AddWithValue("@p_nroCuenta", unProovedor.nrocuenta);
                       cmd.Parameters.AddWithValue("@p_nroInter", unProovedor.nrointer);
                       cmd.Parameters.AddWithValue("@p_estado", unProovedor.estado);

                       cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "PROOVEDOR GUARDADO CON EXITO";

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

        //actualizar proovedor - DL

        public string actualizar(R_Proovedor unProovedor)
        {
            SqlCommand cmd = new SqlCommand();
            string a = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_actualizarProveedor";
                    cmd.Parameters.AddWithValue("@p_idProveedor", unProovedor.idProveedor);
                    cmd.Parameters.AddWithValue("@p_tipoPro", unProovedor.tipopro);
                    cmd.Parameters.AddWithValue("@p_tipoDoc", unProovedor.tipodoc);
                    cmd.Parameters.AddWithValue("@p_numeroDoc", unProovedor.numerodoc);
                    cmd.Parameters.AddWithValue("@p_apePat", unProovedor.apepat);
                    cmd.Parameters.AddWithValue("@p_apeMat", unProovedor.apemat);
                    cmd.Parameters.AddWithValue("@p_nombre", unProovedor.nombre);
                    cmd.Parameters.AddWithValue("@p_ruc", unProovedor.ruc);
                    cmd.Parameters.AddWithValue("@p_razon", unProovedor.razon);
                    cmd.Parameters.AddWithValue("@p_domi", unProovedor.domicilio);
                    cmd.Parameters.AddWithValue("@p_depar", unProovedor.departamento);
                    cmd.Parameters.AddWithValue("@p_provi", unProovedor.provincia);
                    cmd.Parameters.AddWithValue("@p_dist", unProovedor.distrito);
                    cmd.Parameters.AddWithValue("@p_tele", unProovedor.telefono);
                    cmd.Parameters.AddWithValue("@p_contacto", unProovedor.contacto);
                    cmd.Parameters.AddWithValue("@p_correo", unProovedor.correo);
                    cmd.Parameters.AddWithValue("@p_bancofina", unProovedor.banco);
                    cmd.Parameters.AddWithValue("@p_nroCuenta", unProovedor.nrocuenta);
                    cmd.Parameters.AddWithValue("@p_nroInter", unProovedor.nrointer);
                    cmd.Parameters.AddWithValue("@p_estado", unProovedor.estado);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        a = "PROOVEDOR ACTUALIZADO CON EXITO";

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


        //buscar proovedor DL

        public R_Proovedor Buscar (int id)
        {
            R_Proovedor or_Proovedor = null;
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                  cmd.Connection = cn;
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.CommandText = "sp_buscarProovedor";
                    cmd.Parameters.AddWithValue("@p_idProveedor", id);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            or_Proovedor = new R_Proovedor(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(),
                                dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),
                                dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(),
                                dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), int.Parse(dr[17].ToString()),
                                int.Parse(dr[18].ToString()), dr[19].ToString());
                        }
                        else
                        {
                            or_Proovedor = null;
                        }


                    }
                    cn.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception (ex.Message);
                }
                finally
                {
                    cn.Dispose ();
                }

            }

            return or_Proovedor;
        }


        // eliminar Proovedor DL

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
                    cmd.CommandText = "sp_eliminarProovedor";
                    cmd.Parameters.AddWithValue("@p_idProovedor", id);

                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0) 
                    {
                        a = "REGISTRO ELIMINADO CON EXITO";
                    }
                    cn.Close();  

                }
                catch (Exception ex)
                {
                    throw new Exception (ex.Message);
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
