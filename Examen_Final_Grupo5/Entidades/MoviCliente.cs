using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MoviCliente
    {


        public int IdMoviCliente { get; set; }
        public string Fecha { get; set; }
        public string Concepto { get; set; }
        public string Tipomovimiento { get; set; }
        public string Tipomoneda { get; set; }
        public string Importe { get; set; }
        public string Nota { get; set; }
        public string IdCliente { get; set; }



        public MoviCliente(int IdMoviCliente, string Fecha, string Concepto, string Tipomovimiento, string Tipomoneda, string Importe, string Nota, string IdCliente)
        {
            this.IdMoviCliente = IdMoviCliente;
            this.Fecha = Fecha;
            this.Concepto = Concepto;
            this.Tipomovimiento = Tipomovimiento;
            this.Tipomoneda = Tipomoneda;
            this.Importe = Importe;
            this.Nota = Nota;
            this.IdCliente = IdCliente;

        }

        public MoviCliente( string Fecha, string Concepto, string Tipomovimiento, string Tipomoneda, string Importe, string Nota, string IdCliente)
        {
            
            this.Fecha = Fecha;
            this.Concepto = Concepto;
            this.Tipomovimiento = Tipomovimiento;
            this.Tipomoneda = Tipomoneda;
            this.Importe = Importe;
            this.Nota = Nota;
            this.IdCliente = IdCliente;

        }

        public MoviCliente()
        {

        }


    }
}
