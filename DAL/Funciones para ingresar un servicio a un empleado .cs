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
    public class Funciones_para_ingresar_un_servicio_a_un_empleado
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

        //Funcion para poder regirtar un cliente
        public Boolean Ingresar_Un_Servicio_a_un_empleado(Datos_login Conexion_del_cliente, Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {

            try
            {

                conexion(Conexion_del_cliente);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_del_servicio_del_empleado);


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

        //Funcion privada para registrar los datos de un servicio a un empleado
        private void Enviar_Datos(Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_REGISTRAR_UN_SERVICO_A_UN_EMPLEADO", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_servicios_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_del_empleado.codigo_del_servicio;
                cmd.Parameters.Add("p_empleado_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_del_empleado.codigo_del_empleado;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los servicios de los empleados
        DataTable Tabla_de_los_servicios_de_los_empleados = new DataTable();
        //Funcion para poder traer todos los usuarios existentes
        public DataTable Consultar_servicios_de_los_empleados(Datos_login Conexion_del_Cliente)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_de_los_servicios_de_los_empleados;

            }
            catch (Exception)
            {
                ora.Close();

                return null;
            }

        }
        //Funcion privada para buscar en la bases de datos todos los servicios y sus empleados
        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_SERVICIOS_Y_EMPLEADOS_RELACIONADOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_de_los_servicios_de_los_empleados);
        }


        //Funcion para poder modificar los datos de un servicio de un empleado
        public Boolean Modificar_datos_de_un_servicio_De_un_Empleado(Datos_login Conexion_del_Cliente, Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Cliente);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_del_servicio_del_empleado);

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
        private void Enviar_actualizacion(Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {

            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UN_SERVICO_DE_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int64).Value = datos_del_servicio_del_empleado.codigo;
            comando.Parameters.Add("p_codigo_servicio", OracleDbType.Varchar2).Value = datos_del_servicio_del_empleado.codigo_del_servicio;
            comando.Parameters.Add("p_codigo_empleado", OracleDbType.Varchar2).Value = datos_del_servicio_del_empleado.codigo_del_empleado;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar un usuario
        public Boolean borrar_un_servicio_de_un_cliente(Datos_login Conexion_del_Cliente, Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            try
            {

                conexion(Conexion_del_Cliente);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_cliente(datos_del_servicio_del_empleado);


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

        private void buscar_y_borrar_un_cliente(Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UN_SERVICIO_DE_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_del_empleado.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los servicios de un empleado
        DataTable servicio_de_un_empleado = new DataTable();
        //Funcion para poder traer todos los usuario existentes
        public DataTable Consultar_Un_Servicio_de_un_Empleado(Datos_login Conexion_del_Cliente, Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                //Abir conexion
                ora.Open();

                traer_datos_del_servicio(datos_del_servicio_del_empleado);

                //Cerrar conexion
                ora.Close();

                return servicio_de_un_empleado;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la base de dato al administrador
        private void traer_datos_del_servicio(Servicio_de_un_empleado datos_del_servicio_del_empleado)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_SERVICIOS_DE_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_del_empleado.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(servicio_de_un_empleado);
        }

    }
}
