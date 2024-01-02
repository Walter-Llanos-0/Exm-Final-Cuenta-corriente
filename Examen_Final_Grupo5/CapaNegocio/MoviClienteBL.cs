using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class MoviClienteBL
    {

        MoviClienteDL or_movicliDL = new MoviClienteDL();
        // listar 

        public List<MoviCliente> listarMovi()
        {
            return or_movicliDL.listar();
        }

        //agregar 
        public string agregarmovi(MoviCliente or_movicli)
        {
            return or_movicliDL.agregar(or_movicli);


        }

        //actualizar
        public string actualizarmovi(MoviCliente or_movicli)
        {
            return or_movicliDL.actualizar(or_movicli);
        }

        //buscar 

        public MoviCliente buscarmovi(Int32 id)
        {

            return or_movicliDL.buscar(id);
        }

        //eliminar
        public string eliminarmovi(Int16 id)
        {
            return or_movicliDL.eliminar(id);
        }

    }
}
