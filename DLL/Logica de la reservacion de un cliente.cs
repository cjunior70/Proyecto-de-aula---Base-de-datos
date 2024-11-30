using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Data;

namespace DLL
{
    public class Logica_de_la_reservacion_de_un_cliente
    {

        Datos_login datos_de_conexion = new Datos_login();

        Funciones_para_agregar_una_reservacion_de_un_cliente funciones_Para_Agregar_una_reservacion_de_un_cliente = new Funciones_para_agregar_una_reservacion_de_un_cliente();

        //Funcion para poder registraar un empleado a una reservacion
        public Boolean registrar_un_empleado_a_una_reservacion(Datos_login datos_de_conexion, Reservacion datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_una_reservacion_de_un_cliente.Ingresar_Una_reservacion_de_un_cliente(datos_de_conexion, datos_del_servicio);

            return confirmacion;
        }

        //Funcion para traer todos los empleados de todas las reservaciones
        public DataTable traer_todos_los_empleados_de_una_reservacion()
        {
            DataTable datos;

            datos = funciones_Para_Agregar_una_reservacion_de_un_cliente.Consultar_reservaciones_y_sus_cliente(datos_de_conexion);

            return datos;
        }

        //Funcion para traer los empleados de una reservacion
        public DataTable traer_los_empleados_de_una_reservacion(Cliente datos_del_servicio)
        {
            DataTable datos;

            datos = funciones_Para_Agregar_una_reservacion_de_un_cliente.Consultar_Una_reservacion_de_un_cliente(datos_de_conexion, datos_del_servicio);

            return datos;
        }

        //Funcion para eliminar un empleado de una reservacion
        public Boolean eliminar_un_empleado_de_una_reservacion(Cliente datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_una_reservacion_de_un_cliente.borrar_una_reservacion_de_un_cliente(datos_de_conexion, datos_del_servicio);

            return confirmacion;

        }

        //Funcion para actualizar datos de un empleado de una reservacion
        public Boolean actualizacion_de_datos_de_un_empleado_de_una_reservacion(Cliente datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_una_reservacion_de_un_cliente.Modificar_datos_de_una_reservacion_de_un_cliente(datos_de_conexion, datos_del_servicio);

            return confirmacion;

        }


    }

}
