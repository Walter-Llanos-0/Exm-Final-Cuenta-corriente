using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;
namespace CapaNegocio
{
    public class MoviProovedorBL
    {
        MoviProovedorDL or_moviproDL = new MoviProovedorDL();
        // listar movi proovedor
        public List<MoviProovedor> listarMovi()
        {
            return or_moviproDL.listar();
        }

        //agregar movi proovedor
        public string agregarmovi(MoviProovedor or_movipro)
        {
            return or_moviproDL.agregar(or_movipro);


        }

        //actualizar movi proovedor
        public string actualizarmovi (MoviProovedor or_movipro)
        {
            return or_moviproDL.actualizar(or_movipro);
        }

       //buscar proovedor 

        public MoviProovedor buscarmovi (Int32 id)
        {

            return or_moviproDL.buscar(id);
        }
         
        //eliminar moviproovedor
        public string eliminarmovi (Int16 id)
        {
            return or_moviproDL.eliminar(id);
        }



    }
}
