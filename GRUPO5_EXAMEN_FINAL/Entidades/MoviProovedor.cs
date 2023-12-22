using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MoviProovedor
    {
        public int idmProovedor {  get; set; }
        public string fecha { get; set; }
        public string concepto { get; set; }
        public string nota { get; set; }
        public string tipomovimiento { get; set; }
        public string tipomoneda { get; set; }

        public double importe { get; set; }

        //colocacion de constructores

        public MoviProovedor( int idmpro, string fecha,string concepto,string nota,string tipomov,string tipomone,double importe)
        {
            this.idmProovedor = idmpro;
            this.fecha = fecha;
            this.concepto = concepto;
            this.nota = nota;
            this.tipomovimiento = tipomov;
            this.tipomoneda = tipomone;
            this.importe = importe;

        }

        public MoviProovedor(string fecha,string concepto,string nota,string tipomov,string tipomone,double importe)
        {
            this.fecha = fecha;
            this.concepto = concepto;
            this.nota = nota;
            this.tipomovimiento= tipomov;
            this.tipomoneda= tipomone;
            this.importe = importe;


        }

        public MoviProovedor()
        {

        }





    }
}
