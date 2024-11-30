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

                cmd.Parameters.Add("p_fecha_de_la_reservacion", OracleDbType.Date).Value = datos_de_la_reservacion.fecha_de_la_reservacion.Date ;
                cmd.Parameters.Add("p_empresa_codigo", OracleDbType.Int16).Value = datos_de_la_reservacion.empresa.codigo;
                cmd.Parameters.Add("p_cliente_codigo", OracleDbType.Int16).Value = datos_de_la_reservacion.Cliente.codigo;
                cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = datos_de_la_reservacion.estado;
                cmd.Parameters.Add("p_tiempo", OracleDbType.Varchar2).Value = datos_de_la_reservacion.hora;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los servicos
        DataTable Tabla_Servicios = new DataTable();
        //Funcion para poder traer todos los servicios existentes
        public DataTable Consultar_Todas_las_reservaciones(Datos_login Conexion_del_Usuario)
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
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LAS_RESERVACIONES", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_Servicios);
        }



        //Funcion para poder modificar los datos de una reservacion
        public Boolean Modificar_datos_una_reservacion(Datos_login Conexion_del_Usuario, Reservacion datos_nuevo_de_una_reservacion)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Usuario);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_nuevo_de_una_reservacion);

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
        private void Enviar_actualizacion(Reservacion datos_de_la_reservacion)
        {

            //Comando para poder buscar el procedimiento en la base de datod y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UNA_RESERVACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_fecha_de_la_reservacion", OracleDbType.Date).Value = datos_de_la_reservacion.fecha_de_la_reservacion.Date;
            comando.Parameters.Add("p_empresa_codigo", OracleDbType.Int16).Value = datos_de_la_reservacion.empresa.codigo;
            comando.Parameters.Add("p_cliente_codigo", OracleDbType.Int16).Value = datos_de_la_reservacion.Cliente.codigo;
            comando.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = datos_de_la_reservacion.estado;
            comando.Parameters.Add("p_tiempo", OracleDbType.Varchar2).Value = datos_de_la_reservacion.hora;


            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar una reservacion
        public Boolean borrar_una_reservacion(Datos_login Conexion_del_Usuario, Reservacion datos_de_la_reservacion)
        {
            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_una_reservacion(datos_de_la_reservacion);


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

        private void buscar_y_borrar_una_reservacion(Reservacion datos_de_la_ubicacion_a_eliminar)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UNA_RESERVACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_de_la_ubicacion_a_eliminar.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los datos des una reservacion
        DataTable Servicio = new DataTable();
        //Funcion para poder traer todos las reservaciones existentes
        public DataTable Consultar_Una_Reservacion(Datos_login Conexion_del_Usuario, Reservacion datos_del_servicio)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                //Abir conexion
                ora.Open();

                traer_datos_de_una_Reservacion(datos_del_servicio);

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

        //Funcion privada para buscar en la base de dato a una reservacion
        private void traer_datos_de_una_Reservacion(Reservacion datos_del_servicio)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_UNA_RESERVACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_cliente_codigo", OracleDbType.Int16).Value = datos_del_servicio.Cliente.codigo;
            comando.Parameters.Add("p_empresa_codigo", OracleDbType.Int16).Value = datos_del_servicio.empresa.codigo;
            comando.Parameters.Add("p_fecha", OracleDbType.Date).Value = datos_del_servicio.fecha_de_la_reservacion;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Servicio);
        }



    }
}
