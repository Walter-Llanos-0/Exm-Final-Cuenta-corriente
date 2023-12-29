using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class R_UsuarioBL
    {
        R_UsuarioDL or_usuarioDL =new R_UsuarioDL();    

        // LISTAR USUARIO BL 
        public List<R_Usuario> listarUsuario()
        {
            return or_usuarioDL.listar();
        }


        // AGREGAR USUARIO BL 
        public string agregarUsuario(R_Usuario or_usuario)
        {
            return or_usuarioDL.agregar(or_usuario);
        }


        // ACTUALIZAR USUARIO BL 
        public string actualizarUsuario(R_Usuario or_usuario)
        {
            return or_usuarioDL.actualizar(or_usuario);
        }


        // BUSCAR USUARIO BL 
        public R_Usuario buscarUsuario(Int16 id)
        {
            return or_usuarioDL.buscar(id);
        }


        // ELIMINAR USUARIO BL 
        public string eliminarUsuario(Int16 id)
        {
            return or_usuarioDL.eliminar(id);
        }
    }
}
