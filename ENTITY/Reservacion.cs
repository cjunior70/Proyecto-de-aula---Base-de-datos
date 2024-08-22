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
        public Empleados empleado_asignado { get; set; }
        //Nombre de la empresa
        public Empresa empresa { get; set; }
        //Lista de los servicos escogidos
        public List<Servicios> lista_de_serivicios_escogidos = new List<Servicios>();

        //Datos basicos de la resevacion
        public string codigo { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }

        //Constructor para la entrada a la clase
        public Reservacion()
        {
        }

        //Constructor para llenar los datos de la reservacion
        public Reservacion(Empleados empleado_asignado, Empresa empresa, List<Servicios> lista_de_serivicios_escogidos, string codigo, DateTime fecha, TimeSpan hora)
        {
            this.empleado_asignado = empleado_asignado;
            this.empresa = empresa;
            this.lista_de_serivicios_escogidos = lista_de_serivicios_escogidos;
            this.codigo = codigo;
            this.fecha = fecha;
            this.hora = hora;
        }

    }
}
