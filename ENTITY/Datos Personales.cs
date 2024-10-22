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
        public int codigo { get; set; }
        public string cedula { get; set; }
        public string Primer_nombre { get; set; }
        public string Segundo_nombre { get; set; }
        public string Primer_apellido { get; set; }
        public string Segundo_apellido { get; set; }
        public string telefono { get; set; }
        public string correo_electronico { get; set; }
        public byte Foto { get; set; }
        public char sexo { get; set; }

        //Consturctor para entrar a la clases
        public Datos_Personales()
        {
        }


        //Constructor para llenar los datos basicos
        public Datos_Personales(int codigo, string cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, string telefono, string correo_electronico, byte foto, char sexo)
        {
            this.codigo = codigo;
            this.cedula = cedula;
            Primer_nombre = primer_nombre;
            Segundo_nombre = segundo_nombre;
            Primer_apellido = primer_apellido;
            Segundo_apellido = segundo_apellido;
            this.telefono = telefono;
            this.correo_electronico = correo_electronico;
            Foto = foto;
            this.sexo = sexo;
        }
    }
}
