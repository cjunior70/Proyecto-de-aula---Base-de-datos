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

        Funciones_del_empleado funciones_Del_Empleado = new Funciones_del_empleado();

        //Funcion para ingresar un empleado
        public Boolean ingresar_un_empleado(Empleados datos_empleado, Datos_login datos_de_conexion)
        {

            Boolean confirmacion;

            confirmacion= funciones_Del_Empleado.Ingresar_Un_Empleado(datos_de_conexion, datos_empleado);

            return confirmacion;

        }

        //Funcion para guardar la foto un empleado
        public Boolean guardar_foto(Empleados datos_empleado, Datos_login datos_de_conexion)
        {

            Boolean confirmacion;

            confirmacion = funciones_Del_Empleado.actualizar_foto(datos_de_conexion, datos_empleado);

            return confirmacion;

        }

        //Funcion para consultar todos los empleados
        public DataTable consultar_todos_los_empleados_de_una_empresa(Datos_login datos_de_conexion, Empresa datos_de_la_empresa)
        {
            DataTable datos;

            datos = funciones_Del_Empleado.Consultar_Empleados(datos_de_conexion, datos_de_la_empresa);

            return datos;

        }

        //Funcion para consultar todos los empleados y devolver un list
        public List<Empleados> consultar_todos_los_empleados_de_una_empresa_y_devolver_una_lista(Datos_login datos_de_conexion, Empresa datos_de_la_empresa)
        {
            List<Empleados> datos_de_los_empleados = new List<Empleados>();

            DataTable datos;

            datos = funciones_Del_Empleado.Consultar_Empleados(datos_de_conexion, datos_de_la_empresa);

            datos_de_los_empleados = mapeo_del_datatable_que_tiene_los_datos_de_un_empleado(datos,datos_de_la_empresa);

            return datos_de_los_empleados;

        }

        private List<Empleados> mapeo_del_datatable_que_tiene_los_datos_de_un_empleado( DataTable datos_de_todos_los_empleados_globales, Empresa datos_de_la_empresa)
        {
            List<Empleados> lista_de_los_empleados_de_la_empresa = new List<Empleados>();

            for (int i = 0; i < datos_de_todos_los_empleados_globales.Rows.Count; i++) 
            { 
                Empleados datos=new Empleados();

                datos.codigo =  Convert.ToInt16(datos_de_todos_los_empleados_globales.Rows[i]["CODIGO"].ToString());
                datos.cedula = datos_de_todos_los_empleados_globales.Rows[i]["CEDULA"].ToString();
                datos.Primer_nombre = datos_de_todos_los_empleados_globales.Rows[i]["PRIMER_NOMBRE"].ToString();
                datos.Segundo_nombre = datos_de_todos_los_empleados_globales.Rows[i]["SEGUNDO_NOMBRE"].ToString();
                datos.Primer_apellido = datos_de_todos_los_empleados_globales.Rows[i]["PRIMER_APELLIDO"].ToString();
                datos.Segundo_apellido = datos_de_todos_los_empleados_globales.Rows[i]["SEGUNDO_APELLIDO"].ToString();
                datos.telefono = datos_de_todos_los_empleados_globales.Rows[i]["TELEFONO"].ToString();
                datos.correo_electronico = datos_de_todos_los_empleados_globales.Rows[i]["CORREO_ELECTRONICO"].ToString();
                datos.Foto = (byte []) (datos_de_todos_los_empleados_globales.Rows[i]["FOTO"]);
                datos.cupos_disponibles = Convert.ToInt16( datos_de_todos_los_empleados_globales.Rows[i]["CUPOS_DISPONIBLES_POR_DIA"]);
                datos.fecha_de_inicio = Convert.ToDateTime( datos_de_todos_los_empleados_globales.Rows[i]["FECHA_DE_INICIO"]) ;
                datos.fecha_de_final = Convert.ToDateTime(datos_de_todos_los_empleados_globales.Rows[i]["FECHA_FINAL"]);
                datos.cargo = datos_de_todos_los_empleados_globales.Rows[i]["CARGO"].ToString();
                datos.codigo_empresa = Convert.ToInt16(datos_de_todos_los_empleados_globales.Rows[i]["EMPRESA_CODIGO"].ToString());
                datos.sexo = Convert.ToChar( datos_de_todos_los_empleados_globales.Rows[i]["SEXO"].ToString());
                datos.estado = datos_de_todos_los_empleados_globales.Rows[i]["ESTADO"].ToString();

                if (  datos.codigo_empresa == datos_de_la_empresa.codigo)
                {
                    lista_de_los_empleados_de_la_empresa.Add(datos);
                }

            }

            return lista_de_los_empleados_de_la_empresa;

        }

        //Funcion para modificar los datos de un empleado
        public Boolean actualizar_datos_de_un_empleado(Empleados datos_actualizados, Datos_login datos_de_conexion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Del_Empleado.Modificar_datos_del_empleado(datos_de_conexion, datos_actualizados);

            return confirmacion;

        }

        //Funcion para poder borrar a un empleado
        public Boolean borrar_un_empleado(Empleados datos_del_empleado, Datos_login datos_de_conexion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Del_Empleado.borrar_un_empleado(datos_de_conexion, datos_del_empleado);

            return confirmacion;

        }

        //Funcion para consultar los datos de un empleado
        public DataTable consultar_datos_de_un_empleado(Empleados datos_del_empleado, Datos_login datos_de_conexion)
        {
            DataTable datos;

            datos = funciones_Del_Empleado.Consultar_Un_Empleado(datos_de_conexion, datos_del_empleado);

            return datos;

        }

    }
}
