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
    public class logica_de_los_servicios
    {
        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        Funcion_de_los_servicios Funciones_De_Los_Servicios=new Funcion_de_los_servicios();

        //Funcion para ingresar un servicio
        public Boolean registrar_un_servicio(Servicios datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = Funciones_De_Los_Servicios.Ingresar_Un_Servicio(datos_de_conexion, datos_del_servicio);

            return confirmacion;
        }

        //Funcion para consultar todos los servicios disponibles
        public DataTable funcion_para_consultar_todos_los_servicios(Datos_login datos_de_conexion)
        {
            DataTable datos;

            datos = Funciones_De_Los_Servicios.Consultar_Todas_los_servicios(datos_de_conexion);

            return datos;

        }

        //Funcion para actualizar un servicio
        public Boolean actualizar_un_servicio( Servicios datos_del_servico) 
        {
            Boolean confirmacion;

            confirmacion = Funciones_De_Los_Servicios.Modificar_datos_una_ubicacion(datos_de_conexion, datos_del_servico);

            return confirmacion;

        }

        //Funcion para eliminar un servicio
        public Boolean eliminar_un_servicio(Servicios datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = Funciones_De_Los_Servicios.borrar_un_servicio(datos_de_conexion, datos_del_servicio);

            return confirmacion;

        }

        //Funcion para consultar un servicio
        public DataTable buscar_un_servicio(Servicios datos_del_servicio)
        {
            DataTable datos;

            datos = Funciones_De_Los_Servicios.Consultar_Un_Servicio(datos_de_conexion, datos_del_servicio);

            return datos;

        }

    }
}
