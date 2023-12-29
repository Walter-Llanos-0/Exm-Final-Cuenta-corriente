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
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-B9COPN0L;Database=Grupo_5;User ID=sa;Password=1234");

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
