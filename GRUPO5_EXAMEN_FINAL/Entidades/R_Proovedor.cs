using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R_Proovedor
    {
        public int  idProveedor { get; set; }
        public string tipopro { get; set; }
        public string tipodoc {  get; set; }
        public string numerodoc { get; set; }
        public string apepat { get; set; }
        public string apemat {  get; set; }
        public string nombre { get; set; }
        public string ruc {  get; set; }
        public string razon {  get; set; }
        public string domicilio { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }

        public string telefono { get; set; }
        public string contacto { get; set; }
        public string correo { get; set; }
        public string banco { get; set; }

        public int nrocuenta { get; set; }
        public int nrointer {  get; set; }
        public string estado { get; set; }

        //colocando constructores

        public R_Proovedor(int idproovedor, string tipopro, string tipodoc,string numerodoc,string apepat,string apemat,
            string nombre,string ruc,string razon,string domicilio,string departamento,string provincia,string distrito,string telefono,
            string contacto,string correo,string banco,int nrocuenta,int nrointer,string estado)
        {
            this.idProveedor=idproovedor;
            this.tipopro=tipopro;
            this.tipodoc=tipodoc;
            this.numerodoc=numerodoc;
            this.apepat=apepat;
            this.apemat=apemat;
            this.nombre=nombre;
            this.ruc=ruc;
            this.razon=razon;
            this.domicilio=domicilio;
            this.departamento=departamento;
            this.provincia=provincia;
            this.distrito=distrito;
            this.telefono=telefono;
            this.contacto=contacto;
            this.correo=correo;
            this.banco=banco;
            this.nrocuenta=nrocuenta;
            this.nrointer=nrointer;
            this.estado=estado;
        }

        public R_Proovedor(string tipopro,string tipodoc,string numerodoc,string apepat,string apemat,string nombre,
            string ruc,string razon,string domicilio,string departamento,string provincia,string distrito,string telefono,
            string contacto,string correo,string banco,int nrocuenta,int nrointer,string estado)
        {

            this.tipopro = tipopro;
            this.tipodoc = tipodoc;
            this.numerodoc = numerodoc;
            this.apepat = apepat;
            this.apemat = apemat;
            this.nombre = nombre;
            this.ruc = ruc;
            this.razon = razon;
            this.domicilio = domicilio;
            this.departamento = departamento;
            this.provincia = provincia;
            this.distrito = distrito;
            this.telefono = telefono;
            this.contacto = contacto;
            this.correo = correo;
            this.banco = banco;
            this.nrocuenta = nrocuenta;
            this.nrointer = nrointer;
            this.estado = estado;


        }

        public R_Proovedor()
        {

        }





    }

}
