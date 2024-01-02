using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class R_ClienteBL
    {
        R_ClienteDL orClienteDL = new R_ClienteDL();

        // LISTAR USUARIO BL 
        public List<R_Cliente> listarCliente()
        {
            return orClienteDL.listar();
        }


        // AGREGAR USUARIO BL 
        public string agregarCliente(R_Cliente or_cliente)
        {
            return orClienteDL.agregar(or_cliente);
        }


        // ACTUALIZAR USUARIO BL 
        public string actualizarCliente(R_Cliente or_cliente)
        {
            return orClienteDL.actualizar(or_cliente);
        }


        // BUSCAR USUARIO BL 
        public R_Cliente buscarCliente(int id)
        {
            return orClienteDL.buscar(id);
        }


        // ELIMINAR USUARIO BL 
        public string eliminarCliente(int id)
        {
            return orClienteDL.eliminar(id);
        }

    }
}
