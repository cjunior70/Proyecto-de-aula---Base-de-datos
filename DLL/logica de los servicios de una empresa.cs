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
    public class logica_de_los_servicios_de_una_empresa
    {

        Datos_login datos_de_conexion = new Datos_login();

        Funciones_para_agregar_un_servicio_a_una_empresa funciones_Para_Agregar_Servicio_A_Una_Empresa = new Funciones_para_agregar_un_servicio_a_una_empresa();

        //Funcion para poder registraar un servicio a una empresa
        public Boolean registrar_servicio_a_una_empresa(Servicio_de_una_Empresa datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Una_Empresa.Ingresar_Un_Servicio_a_una_Empresa(datos_de_conexion, datos_del_servicio);

            return confirmacion;
        }

        //Funcion para traer todos los servicios de una empresa
        public DataTable traer_todos_los_servicios_de_las_empresas()
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Servicio_A_Una_Empresa.Consultar_servicios_y_empresas_relacionados(datos_de_conexion);

            return datos;
        }

        //Funcion para traer los servicios de una empresa
        public DataTable traer_los_servicios_de_una_empresa(Datos_login datos_de_conexion, Servicio_de_una_Empresa datos_de_la_reservacion)
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Servicio_A_Una_Empresa.Consultar_Un_Servicio_de_una_empresa(datos_de_conexion, datos_de_la_reservacion);

            return datos;
        }

        //Funcion para eliminar un servicio de una empresa
        public Boolean eliminar_una_reservacion(Servicio_de_una_Empresa datos_De_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Una_Empresa.borrar_un_servicio_de_una_empresa(datos_de_conexion, datos_De_la_reservacion);

            return confirmacion;

        }

        //Funcion para actualizar datos de un servicio de una empresa
        public Boolean actualizacion_de_datos_de_un_servicio_De_una_empresa(Servicio_de_una_Empresa datos_de_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Una_Empresa.Modificar_datos_de_un_servicio_De_una_Empresa(datos_de_conexion, datos_de_la_reservacion);

            return confirmacion;

        }

    }
}
