using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Usuario
    {
      
        
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public byte [] foto { get; set; }

        public Usuario() { }

        public Usuario(string codigo, string nombre, string clave, string correo, string telefono)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.clave = clave;
            this.correo = correo;
            this.telefono = telefono;
            this.foto = foto;
        }

        public Usuario(string codigo, string clave)
        {
            this.codigo = codigo;
            this.clave = clave;
        }
    }
}
