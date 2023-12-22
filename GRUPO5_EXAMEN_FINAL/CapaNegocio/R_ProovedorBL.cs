using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class R_ProovedorBL
    {
        
            R_ProovedorDL or_proovedorDL = new R_ProovedorDL();

            //listar proovedor
            public List<R_Proovedor> listarProovedor()
            {
                return or_proovedorDL.listar();


            }

           //agregar proovedor

        public string agregarProovedor(R_Proovedor or_proovedor)
        {
            return or_proovedorDL.agregar(or_proovedor);

        }
          
        // actualizar proovedor BL
        public string actualizarProovedor (R_Proovedor or_proovedor)
        {
            return or_proovedorDL.actualizar(or_proovedor);

        }

        // buscar proovedor BL

        public R_Proovedor buscarProovedor (Int32 id)
        {
            return or_proovedorDL.Buscar(id);
        }

        //eliminar proovedor BL
        public string eliminarProovedor (Int16 id)
        {
            return or_proovedorDL.eliminar(id);
        }

        }
}
