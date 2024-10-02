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
    public class Funciones_para_agregar_un_empleado_a_una_reservacion
    {

        //Variables para poder uso globar
        private OracleConnection ora;

        //Funcion para la conexion con la base de datos 
        private void conexion(Datos_login datos_de_conexion)
        {
            //Cadena de conexion para ingresar el un servicio a un empleado
            string conexion = $"DATA SOURCE=localhost:1521/xepdb1;PASSWORD={datos_de_conexion.constraseña};USER ID={datos_de_conexion.usuario};";

            //Instancia de la clase de oracleconection para la conexion a la base de datos de oracle
            this.ora = new OracleConnection(conexion);
        }

        //Funcion para poder regirtar un empleado a una reservacion
        public Boolean Ingresar_Un_Empleado_a_una_Reservacion(Datos_login Conexion_del_cliente, Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {

            try
            {

                conexion(Conexion_del_cliente);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_del_empleado_en_la_reservacion);


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

        //Funcion privada para registrar los datos de un empleado a una reservacion
        private void Enviar_Datos(Empleados_de_una_reservacion datos_del_empleado_a_la_reservacion)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_REGISTRAR_UN_EMPLEADO_A_UNA_RESERVACION", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_codigo_reservacion", OracleDbType.Varchar2).Value = datos_del_empleado_a_la_reservacion.codigo_de_reservacion;
                cmd.Parameters.Add("p_empleado_codigo", OracleDbType.Varchar2).Value = datos_del_empleado_a_la_reservacion.codigo_de_empleado;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los empleados de un servicio
        DataTable Tabla_de_los_empleado_de_un_servicio = new DataTable();
        //Funcion para poder traer todos los datos existentes
        public DataTable Consultar_todas_los_empleados_de_una_reservacion(Datos_login Conexion_del_Cliente)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_de_los_empleado_de_un_servicio;

            }
            catch (Exception)
            {
                ora.Close();

                return null;
            }

        }
        //Funcion privada para buscar en la bases de datos todos los empleados de una reservacion
        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_EMPLEADOS_Y_LAS_RESERVACIONES_RELACIONADOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_de_los_empleado_de_un_servicio);
        }


        //Funcion para poder modificar los datos de los empleados de una reservacion
        public Boolean Modificar_datos_de_un_empleado_de_una_reservacion(Datos_login Conexion_del_Cliente, Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Cliente);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_del_empleado_en_la_reservacion);

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
        //Funcion privada para buscar en la base de datos el servicio y el empleado
        private void Enviar_actualizacion(Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {

            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UN_EMPLEADO_DE_UNA_RESERVACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int64).Value = datos_del_empleado_en_la_reservacion.codigo;
            comando.Parameters.Add("p_codigo_reservacion", OracleDbType.Varchar2).Value = datos_del_empleado_en_la_reservacion.codigo_de_reservacion;
            comando.Parameters.Add("p_codigo_empleado", OracleDbType.Varchar2).Value = datos_del_empleado_en_la_reservacion.codigo_de_empleado;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar un empleado de una reservacion
        public Boolean borrar_un_empleado_de_una_reservacion(Datos_login Conexion_del_Cliente, Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {
            try
            {

                conexion(Conexion_del_Cliente);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_cliente(datos_del_empleado_en_la_reservacion);


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

        private void buscar_y_borrar_un_cliente(Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UN_SERVICIO_DE_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_empleado_en_la_reservacion.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los empleados de una reservacion
        DataTable empleados_de_una_reservacion = new DataTable();
        //Funcion para poder traer todos los usuario existentes
        public DataTable Consultar_Un_Servicio_de_un_Empleado(Datos_login Conexion_del_Cliente, Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                //Abir conexion
                ora.Open();

                traer_datos_del_servicio(datos_del_empleado_en_la_reservacion);

                //Cerrar conexion
                ora.Close();

                return empleados_de_una_reservacion;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la base de dato al administrador
        private void traer_datos_del_servicio(Empleados_de_una_reservacion datos_del_empleado_en_la_reservacion)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_EMPLEADOS_EN_UNA_RESERVACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_empleado_en_la_reservacion.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(empleados_de_una_reservacion);
        }

    }
}
