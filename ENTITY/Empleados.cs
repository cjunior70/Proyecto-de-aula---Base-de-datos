using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Empleados:Datos_Personales
    {

        //Lista de clientes asignados 
        public List<Cliente> lista_de_clientes = new List<Cliente>();
        //Lista de los servicios disponibles del empleado
        public List<Servicios> lista_de_servicios = new List<Servicios>();

        //Informacion basica del empleado 
        public int cupos_disponibles { get; set; }
        public int experiencia { get; set; }
        public string estado { get; set; }

        //Constructor para acceso a la clase
        public Empleados()
        {
        }

        //Construtor para los datos personales de los empleados
        public Empleados(string nombre_de_usuario, string contraseña, char cargo, string cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int telefono, string correo_electronico, byte foto) : base(nombre_de_usuario, contraseña, cargo, cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono, correo_electronico, foto)
        {
        }

        //Construtor para la lisata de servicios disponibles,lista de los clientes asignados, y informacion basica del empleado
        public Empleados(List<Cliente> lista_de_clientes, List<Servicios> lista_de_servicios, int cupos_disponibles, int experiencia, string estado)
        {
            this.lista_de_clientes = lista_de_clientes;
            this.lista_de_servicios = lista_de_servicios;
            this.cupos_disponibles = cupos_disponibles;
            this.experiencia = experiencia;
            this.estado = estado;
        }


    }
}
