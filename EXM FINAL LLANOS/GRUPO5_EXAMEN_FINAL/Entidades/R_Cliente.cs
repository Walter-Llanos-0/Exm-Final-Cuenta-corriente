using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R_Cliente
    {


        public int IdCliente { get; set; }
        public string Tipocliente { get; set; }
        public string Tipodocumento { get; set; }
        public string Numerodocumento { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Telefono1 { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Moroso { get; set; }
        public string Estado { get; set; }




        // COLOCANDO CONSTRUCTORES 



        public R_Cliente(string Tipocliente, string Tipodocumento, string Numerodocumento, string ApellidoPaterno, string ApellidoMaterno, string Nombre, string Ruc, string RazonSocial, string Domicilio, string Departamento, string Provincia, string Distrito, string Telefono1, string Celular, string Correo, string Moroso, string Estado)
        {
            this.Tipocliente = Tipocliente;
            this.Tipodocumento = Tipodocumento;
            this.Numerodocumento = Numerodocumento;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.Nombre = Nombre;
            this.Ruc = Ruc;
            this.RazonSocial = RazonSocial;
            this.Domicilio = Domicilio;
            this.Departamento = Departamento;
            this.Provincia = Provincia;
            this.Distrito = Distrito;
            this.Telefono1 = Telefono1;
            this.Celular = Celular;
            this.Correo = Correo;
            this.Moroso = Moroso;
            this.Estado = Estado;
        }




        public R_Cliente(int IdCliente, string Tipocliente, string Tipodocumento, string Numerodocumento, string ApellidoPaterno, string ApellidoMaterno, string Nombre, string Ruc, string RazonSocial, string Domicilio, string Departamento, string Provincia, string Distrito, string Telefono1, string Celular, string Correo, string Moroso, string Estado)
        {
            this.IdCliente = IdCliente;
            this.Tipocliente = Tipocliente;
            this.Tipodocumento = Tipodocumento;
            this.Numerodocumento = Numerodocumento;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.Nombre = Nombre;
            this.Ruc = Ruc;
            this.RazonSocial = RazonSocial;
            this.Domicilio = Domicilio;
            this.Departamento = Departamento;
            this.Provincia = Provincia;
            this.Distrito = Distrito;
            this.Telefono1 = Telefono1;
            this.Celular = Celular;
            this.Correo = Correo;
            this.Moroso = Moroso;
            this.Estado = Estado;
        }

        public R_Cliente()
        {
        }
    }
}
