using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R_Usuario
    {
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string apepaterno { get; set; }
        public string apematerno { get; set; }
        public string nombre { get; set; }
        public string perfil { get; set; }
        public string estado { get; set; }
        public string fotos { get; set; }

        // COLOCANDO CONSTRUCTORES 


        public R_Usuario(int idusuario, string usuario, string contrasenia, string apepaterno, string apematerno, string nombre, string perfil, string estado, string fotos)
        {
            this.idusuario = idusuario;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.apepaterno = apepaterno;
            this.apematerno = apematerno;
            this.nombre = nombre;
            this.perfil = perfil;
            this.estado = estado;
            this.fotos = fotos;
        }


        public R_Usuario(string usuario, string contrasenia, string apepaterno, string apematerno, string nombre, string perfil, string estado, string fotos)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.apepaterno = apepaterno;
            this.apematerno = apematerno;
            this.nombre = nombre;
            this.perfil = perfil;
            this.estado = estado;
            this.fotos = fotos;

        }



        public R_Usuario()
        {

        }
    }
}
