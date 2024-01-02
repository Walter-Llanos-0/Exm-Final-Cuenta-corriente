using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MoviProovedor
    {
        public int IdmProovedor { get; set; }
        public string fecha { get; set; }
        public string concepto { get; set; }
        public string nota { get; set; }
        public string tipomovimiento { get; set; }
        public string tipomoneda { get; set; }

        public string importe { get; set; }
        public string idProoveedor { get; set; }

        //colocacion de constructores

        public MoviProovedor(int IdmProovedor, string fecha, string concepto, string nota, string tipomovimiento, string tipomoneda, string importe, string idProoveedor)
        {
            this.IdmProovedor = IdmProovedor;
            this.fecha = fecha;
            this.concepto = concepto;
            this.nota = nota;
            this.tipomovimiento = tipomovimiento;
            this.tipomoneda = tipomoneda;
            this.importe = importe;
            this.idProoveedor = idProoveedor;
        }

        public MoviProovedor(string fecha, string concepto, string nota, string tipomovimiento, string tipomoneda, string importe, string idProoveedor)
        {
            this.fecha = fecha;
            this.concepto = concepto;
            this.nota = nota;
            this.tipomovimiento = tipomovimiento;
            this.tipomoneda = tipomoneda;
            this.importe = importe;
            this.idProoveedor = idProoveedor;

        }

        public MoviProovedor()
        {

        }


    }//fin de clase
}//fin de capa entidad
