using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-2T10M4M;Initial Catalog=Grupo_5;Persist Security Info=True;User ID=sa;Password=74994175");

        public SqlConnection conectar()
        {
            return cn;
        }

        public void abrir()
        {
            cn.Open();
        }

        public void cerrar()
        {
            cn.Close();
        }
    }
}
