using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class Funciones_de_la_reservacion
    {

        //Variables para poder uso globar
        private OracleConnection ora;

        //Funcion para la conexion con la base de datos 
        private void conexion(Datos_login datos_de_conexion)
        {
            //Cadena de conexion para ingresar el nombre de empleado,cliente o usuario y su contraseña
            string conexion = $"DATA SOURCE=localhost:1521/xepdb1;PASSWORD={datos_de_conexion.constraseña};USER ID={datos_de_conexion.usuario};";

            //Instancia de la clase de oracleconection para la conexion a la base de datos de oracle
            this.ora = new OracleConnection(conexion);
        }

        //Funcion para poder regirtar una reservacion
        public Boolean Ingresar_Una_reservacion(Datos_login Conexion_del_usuario, Reservacion datos_de_una_reservacion)
        {

            try
            {

                conexion(Conexion_del_usuario);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_de_una_reservacion);


                //Cerrar conexion
                ora.Close();
                return true;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return false;
            }

        }

        //Funcion privada para registrar los datos de una reservacion
        private void Enviar_Datos(Reservacion datos_de_la_reservacion)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_INGRESAR_UNA_RESERVACION", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

              //  cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = datos_de_la_reservacion.nombre_del_servicio;
               // cmd.Parameters.Add("p_precio", OracleDbType.Int16).Value = datos_de_la_reservacion.precio;

                //El tiempo toca descomponarlo en string para poder guardarlo como se debe
                //cmd.Parameters.Add("p_tiempo", OracleDbType.Varchar2).Value = datos_de_la_reservacion.tiempo_promedio;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los servicos
        DataTable Tabla_Servicios = new DataTable();
        //Funcion para poder traer todos los servicios existentes
        public DataTable Consultar_Todas_los_servicios(Datos_login Conexion_del_Usuario)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_Servicios;

            }
            catch (Exception)
            {
                ora.Close();

                return null;
            }

        }
        //Funcion privada para buscar en la bases de datos todos las ubicaciones registrados

        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_SERVICIOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_Servicios);
        }



        //Funcion para poder modificar los datos de un servicio
        public Boolean Modificar_datos_una_ubicacion(Datos_login Conexion_del_Usuario, Servicios datos_nuevo_de_un_servicio)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Usuario);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_nuevo_de_un_servicio);

                //Cerrar la conexion con la base
                ora.Close();

                return true;
            }
            catch (Exception)
            {
                ora.Close();
                return false;
            }
        }
        //Funcion privada para buscar en la base de datos un servicio y actualizar sus datos
        private void Enviar_actualizacion(Servicios datos_del_servicio)
        {

            //Comando para poder buscar el procedimiento en la base de datod y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UN_SERVICIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int16).Value = datos_del_servicio.codigo;
            comando.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = datos_del_servicio.nombre_del_servicio;
            comando.Parameters.Add("p_precio", OracleDbType.Double).Value = datos_del_servicio.precio;
            comando.Parameters.Add("p_tiempo", OracleDbType.Varchar2).Value = datos_del_servicio.tiempo_promedio;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar un servicio
        public Boolean borrar_un_servicio(Datos_login Conexion_del_Usuario, Servicios datos_de_un_servicio)
        {
            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_servicio(datos_de_un_servicio);


                //Cerrar conexion
                ora.Close();
                return true;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return false;
            }
        }

        private void buscar_y_borrar_un_servicio(Servicios datos_de_la_ubicacion_a_eliminar)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UN_SERVCIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_de_la_ubicacion_a_eliminar.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los datos de un solo servicio
        DataTable Servicio = new DataTable();
        //Funcion para poder traer todos los servicios existentes
        public DataTable Consultar_Un_Servicio(Datos_login Conexion_del_Usuario, Servicios datos_del_servicio)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                //Abir conexion
                ora.Open();

                traer_datos_de_un_servicio(datos_del_servicio);

                //Cerrar conexion
                ora.Close();

                return Servicio;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la base de dato a un empleado
        private void traer_datos_de_un_servicio(Servicios datos_del_servicio)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_UN_SERVICIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_servicio.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Servicio);
        }



    }
}
