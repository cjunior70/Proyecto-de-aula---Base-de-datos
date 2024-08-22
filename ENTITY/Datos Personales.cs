using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Datos_Personales
    {
        //Datos basicos 
        public string nombre_de_usuario { get; set; }
        public string contraseña { get; set; }
        public char cargo { get; set; }
        public string cedula { get; set; }
        public string Primer_nombre { get; set; }
        public string Segundo_nombre { get; set; }
        public string Primer_apellido { get; set; }
        public string Segundo_apellido { get; set; }
        public int telefono { get; set; }
        public string correo_electronico { get; set; }
        public byte Foto { get; set; }

        //Consturctor para entrar a la clases
        public Datos_Personales()
        {
        }

        //Constructor para llenar los datos basicos
        public Datos_Personales(string nombre_de_usuario, string contraseña, char cargo, string cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int telefono, string correo_electronico, byte foto)
        {
            this.nombre_de_usuario = nombre_de_usuario;
            this.contraseña = contraseña;
            this.cargo = cargo;
            this.cedula = cedula;
            Primer_nombre = primer_nombre;
            Segundo_nombre = segundo_nombre;
            Primer_apellido = primer_apellido;
            Segundo_apellido = segundo_apellido;
            this.telefono = telefono;
            this.correo_electronico = correo_electronico;
            Foto = foto;
        }


    }
}
