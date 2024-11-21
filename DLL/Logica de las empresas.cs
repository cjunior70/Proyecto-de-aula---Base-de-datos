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
    public class logica_de_las_empresas
    {

        //Funcion para el ingreso de datos de una empresa
        public Boolean registro_de_una_empresa(Empresa datos_de_la_empresa, Datos_login datos_de_conexion)
        {

            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_de_la_empresa = new Funciones_de_Empresa();

            //Variabale para la confirmacion de ninguno error ajeno
            Boolean confirmacion;

           confirmacion = funciones_de_la_empresa.Ingresar_Una_Empresa(datos_de_conexion, datos_de_la_empresa);

           return confirmacion;


        }

        //Funcion para consultar los datos de una empresa con interes o datos de la empresa
        public List<Empresa> consultar_datos_de_una_empresa(Empresa datos_de_la_empresa, Datos_login datos_de_conexion)
        {
            List<Empresa> Datos_De_la_empresa = new List<Empresa>();

            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_De_Empresa.Consultar_Una_Empresa(datos_de_conexion, datos_de_la_empresa);

            Datos_De_la_empresa = mapeo_del_datatable_que_tiene_los_datos_de_informacion_de_una_sola_empresa(existencia,datos_de_la_empresa);

            return Datos_De_la_empresa;

        }

        private List<Empresa> mapeo_del_datatable_que_tiene_los_datos_de_informacion_de_una_sola_empresa(DataTable datos_de_todas_las_empresa_globales, Empresa datos_de_la_empresa_a_buscar)
        {
            List<Empresa> lista_de_las_empresas = new List<Empresa>();

            for (int i = 0; i < datos_de_todas_las_empresa_globales.Rows.Count; i++)
            {

                Empresa datos = new Empresa();
                datos.codigo = Convert.ToInt32(datos_de_todas_las_empresa_globales.Rows[i]["codigo"]);
                datos.nombre_de_la_empresa = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["nombre"]);
                datos.descripcion_de_la_empresa = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["DESCRIPCION_DE_LA_EMPRESA"]);

                if (datos_de_todas_las_empresa_globales.Rows[i]["EXTRELLAS"] != null)
                {
                    //datos.extrellas = Convert.ToInt16(datos_de_todas_las_empresa_globales.Rows[i]["EXTRELLAS"]);
                }


                datos.whatsapp = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["WHATSAPP"]);
                datos.correo = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["CORREO_ELECTRONICO"]);
                datos.instagram = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["INSTAGRAM"]);
                datos.facebook = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["FACEBOOK"]);
                datos.descripcion_de_la_localizacion = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["DESCRIPCION_DE_LA_LOCALIZACION"]);
                datos.imagen_miniatura = (Byte[])(datos_de_todas_las_empresa_globales.Rows[i]["IMAGEN_EN_MINIATURA"]);
                datos.imagen_general = (Byte[])(datos_de_todas_las_empresa_globales.Rows[i]["IMAGEN_GENERAL"]);
                datos.usuario.codigo = Convert.ToInt32(datos_de_todas_las_empresa_globales.Rows[i]["PROPIETARIO"]);
                datos.ubicaion.codigo = Convert.ToInt32(datos_de_todas_las_empresa_globales.Rows[i]["UBICACION"]);

                if ( datos.codigo == datos_de_la_empresa_a_buscar.codigo )
                {
                    lista_de_las_empresas.Add(datos);
                }

            }

            return lista_de_las_empresas;
        }

        //Funcion para consultar todas las empresas registradas
        public List<Empresa> consultar_todas_las_empresas(Datos_login datos_de_conexion)
        {
            List<Empresa> lista_de_las_empresas = new List<Empresa>();

            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_De_Empresa.Consultar_Todas_las_Empresas(datos_de_conexion);

            lista_de_las_empresas =  mapeo_del_datatable_que_tiene_los_datos_de_informacion(existencia);

            return lista_de_las_empresas;
        }

        private List<Empresa> mapeo_del_datatable_que_tiene_los_datos_de_informacion(DataTable datos_de_todas_las_empresa_globales )
        {
            List<Empresa> lista_de_las_empresas = new List<Empresa>();

            for (int i = 0; i < datos_de_todas_las_empresa_globales.Rows.Count; i++)
            {

                Empresa datos = new Empresa();
                datos.codigo = Convert.ToInt32(datos_de_todas_las_empresa_globales.Rows[i]["codigo"]);
                datos.nombre_de_la_empresa = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["nombre"]);
                datos.descripcion_de_la_empresa = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["DESCRIPCION_DE_LA_EMPRESA"]);

                if (datos_de_todas_las_empresa_globales.Rows[i]["EXTRELLAS"] != null)
                {
                    //datos.extrellas = Convert.ToInt16(datos_de_todas_las_empresa_globales.Rows[i]["EXTRELLAS"]);
                }

                
                datos.whatsapp = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["WHATSAPP"]);
                datos.correo = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["CORREO_ELECTRONICO"]);
                datos.instagram = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["INSTAGRAM"]);
                datos.facebook = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["FACEBOOK"]);
                datos.descripcion_de_la_localizacion = Convert.ToString(datos_de_todas_las_empresa_globales.Rows[i]["DESCRIPCION_DE_LA_LOCALIZACION"]);
                datos.imagen_miniatura = (Byte[])(datos_de_todas_las_empresa_globales.Rows[i]["IMAGEN_EN_MINIATURA"]);
                datos.imagen_general = (Byte[])(datos_de_todas_las_empresa_globales.Rows[i]["IMAGEN_GENERAL"]);
                datos.usuario.codigo = Convert.ToInt32(datos_de_todas_las_empresa_globales.Rows[i]["PROPIETARIO"]);
                datos.ubicaion.codigo = Convert.ToInt32(datos_de_todas_las_empresa_globales.Rows[i]["UBICACION"]);

                lista_de_las_empresas.Add(datos);

            }

            return lista_de_las_empresas;
        }

        //Funcion para actualizar datos de una empresa 
        public Boolean actualizar_datos_de_la_empresa(Empresa datos_actualizados, Datos_login datos_de_conexion)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_De_Empresa.Modificar_datos_una_empresa(datos_de_conexion, datos_actualizados);

            return existencia;

        }

        //Funcion para poder borrar datos de la empresa
        public Boolean borrar_datos_de_la_empresa(Empresa datos_de_la_empresa, Datos_login datos_de_conexion)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_De_Empresa.borrar_una_empresa(datos_de_conexion, datos_de_la_empresa);

            return existencia;
        }

    }
}
