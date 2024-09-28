using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario:Datos_Personales
    {

        //Lista de empresas del usuario
        public List<Empresa> lista_de_empresas = new List<Empresa>();

        //Constructor para acceso a la clase
        public Usuario()
        {
        }

        //Construtor para la lista de empresas del usuario ( dueño )
        public Usuario(List<Empresa> lista_de_empresas)
        {
            this.lista_de_empresas = lista_de_empresas;
        }

        //Construtor para los datos personales de los clientes
        public Usuario(int codigo, string cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, string telefono, string correo_electronico, byte foto, char sexo) : base(codigo, cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono, correo_electronico, foto, sexo)
        {
        }
    }
}
