using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Reservacion
    {

        //Nombre del empleado
        public List<Empleados> Empleados=new List<Empleados>();
        //Nombre de la empresa
        public Empresa empresa { get; set; }
        //Lista de los servicos escogidos
        public List<Servicios> lista_de_serivicios_escogidos = new List<Servicios>();

        //Datos basicos de la resevacion
        public string codigo { get; set; }
        public DateTime creacion_de_la_reservacion { get; set; }
        public DateTime fecha_de_la_reservacion { get; set; }
        public TimeSpan hora { get; set; }

        //Constructor para la entrada a la clase
        public Reservacion()
        {
        }

        public Reservacion(List<Empleados> empleados, Empresa empresa, List<Servicios> lista_de_serivicios_escogidos, string codigo, DateTime creacion_de_la_reservacion, DateTime fecha_de_la_reservacion, TimeSpan hora)
        {
            Empleados = empleados;
            this.empresa = empresa;
            this.lista_de_serivicios_escogidos = lista_de_serivicios_escogidos;
            this.codigo = codigo;
            this.creacion_de_la_reservacion = creacion_de_la_reservacion;
            this.fecha_de_la_reservacion = fecha_de_la_reservacion;
            this.hora = hora;
        }
    }
}
