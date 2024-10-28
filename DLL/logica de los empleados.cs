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
    public class logica_de_los_empleados
    {

        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        Funciones_del_empleado funciones_Del_Empleado = new Funciones_del_empleado();

        //Funcion para ingresar un empleado
        public Boolean ingresar_un_empleado(Empleados datos_empleado, Empresa datos_de_la_empresa)
        {

            Boolean confirmacion;

            confirmacion= funciones_Del_Empleado.Ingresar_Un_Empleado(datos_de_conexion, datos_empleado);

            return confirmacion;

        }

        //Funcion para consultar todos los empleados
        public DataTable consultar_todos_los_empleados()
        {
            DataTable datos;

            datos = funciones_Del_Empleado.Consultar_Empleados(datos_de_conexion);

            return datos;

        }

        //Funcion para modificar los datos de un empleado
        public Boolean actualizar_datos_de_un_empleado(Empleados datos_actualizados)
        {
            Boolean confirmacion;

            confirmacion = funciones_Del_Empleado.Modificar_datos_del_empleado(datos_de_conexion, datos_actualizados);

            return confirmacion;

        }

        //Funcion para poder borrar a un empleado
        public Boolean borrar_un_empleado(Empleados datos_del_empleado)
        {
            Boolean confirmacion;

            confirmacion = funciones_Del_Empleado.borrar_un_empleado(datos_de_conexion, datos_del_empleado);

            return confirmacion;

        }

        //Funcion para consultar los datos de un empleado
        public DataTable consultar_detos_de_un_empleado(Empleados datos_del_empleado )
        {
            DataTable datos;

            datos = funciones_Del_Empleado.Consultar_Un_Empleado(datos_de_conexion, datos_del_empleado);

            return datos;

        }

    }
}
