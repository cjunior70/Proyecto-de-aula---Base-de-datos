using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace DLL
{
    public class logica_de_los_servicios_de_un_empleado
    {

        Datos_login datos_de_conexion = new Datos_login();

        Funciones_para_ingresar_un_servicio_a_un_empleado funciones_Para_Agregar_Servicio_A_Un_Empleado = new Funciones_para_ingresar_un_servicio_a_un_empleado();

        logica_de_los_servicios logica_De_Los_Servicios = new logica_de_los_servicios();

        //Funcion para poder registraar un servicio a un empleado
        public Boolean registrar_servicio_a_un_empleado(Servicio_de_un_empleado datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Un_Empleado.Ingresar_Un_Servicio_a_un_empleado(datos_de_conexion, datos_del_servicio);

            return confirmacion;
        }

        //Funcion para traer todos los servicios de un empleado
        public DataTable traer_todos_los_servicios_y_sus_empleados(Datos_login datos_de_conexion, Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Servicio_A_Un_Empleado.Consultar_servicios_de_los_empleados(datos_de_conexion);

            return datos;
        }

        //Funcion para traer los servicios de un empleado
        public DataTable traer_los_servicios_de_un_empleado( Datos_login datos_de_Conexion, Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            DataTable datos;

            datos_de_conexion = datos_de_Conexion;

            datos = funciones_Para_Agregar_Servicio_A_Un_Empleado.Consultar_Un_Servicio_de_un_Empleado(datos_de_Conexion, datos_del_servicio_del_empleado);

            datos = buscar_los_datos_de_los_servicios(datos);

            return datos;
        }

        private DataTable buscar_los_datos_de_los_servicios(DataTable datos)
        {
            DataTable datos_de_los_servicios;

            datos_de_los_servicios =  logica_De_Los_Servicios.funcion_para_consultar_todos_los_servicios(datos_de_conexion);

            Console.WriteLine("hay datos " + datos_de_los_servicios.Rows.Count);

            DataTable datos_de_los_servicios_del_empleado = datos_de_los_servicios.Clone();

            foreach (DataRow fila in datos_de_los_servicios.Rows)
            {
                // Suponiendo que tienes una columna llamada "CodigoServicio" en ambos DataTables
                if (datos.AsEnumerable().Any(r => r["SERVICIOS_CODIGO"].Equals(fila["CODIGO"])))
                {
                    datos_de_los_servicios_del_empleado.ImportRow(fila); // Importar la fila si cumple la condición
                }
            }

            return datos_de_los_servicios_del_empleado;

        }

        //Funcion para eliminar un servicio de un empleado
        public Boolean eliminar_un_servicio_De_un_empleado(Servicio_de_un_empleado datos_De_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Un_Empleado.borrar_un_servicio_de_un_cliente(datos_de_conexion, datos_De_la_reservacion);

            return confirmacion;

        }

        //Funcion para actualizar datos de un servicio de un empleado
        public Boolean actualizacion_de_datos_de_un_servicio_De_un_empleado(Servicio_de_un_empleado datos_de_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Un_Empleado.Modificar_datos_de_un_servicio_De_un_Empleado(datos_de_conexion, datos_de_la_reservacion);

            return confirmacion;

        }


    }
}
