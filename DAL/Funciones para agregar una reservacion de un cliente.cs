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
    public class Funciones_para_agregar_una_reservacion_de_un_cliente
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

        //Funcion para poder regirtar un servicio a una reservacion
        public Boolean Ingresar_Una_reservacion_de_un_cliente(Datos_login Conexion_del_cliente, Reservacion datos_de_la_reservacion_y_el_cliente)
        {

            try
            {

                conexion(Conexion_del_cliente);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_de_la_reservacion_y_el_cliente);


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

        //Funcion privada para registrar los datos de una reservacion a un  cliente
        private void Enviar_Datos(Reservacion datos_de_la_reservacion_del_cliente)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_REGISTRAR_UNA_RESERVACION_DE_UN_CLIENTE", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_reservacion_codigo", OracleDbType.Int32).Value = datos_de_la_reservacion_del_cliente.codigo ;
                cmd.Parameters.Add("p_cliente_codigo", OracleDbType.Int32).Value = datos_de_la_reservacion_del_cliente.Cliente.codigo;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los servicios de las reservacion
        DataTable Tabla_de_las_reservacion_y_sus_clientes = new DataTable();
        //Funcion para poder traer todos los usuarios existentes
        public DataTable Consultar_reservaciones_y_sus_cliente(Datos_login Conexion_del_Cliente)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_de_las_reservacion_y_sus_clientes;

            }
            catch (Exception)
            {
                ora.Close();

                return null;
            }

        }
        //Funcion privada para buscar en la bases de datos todos los servicios y sus reservaciones
        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LAS_RESERVACIONES_Y_SUS_CLIENTE", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_de_las_reservacion_y_sus_clientes);
        }


        //Funcion para poder modificar los datos de un servicio de una reservacion
        public Boolean Modificar_datos_de_una_reservacion_de_un_cliente(Datos_login Conexion_del_Cliente, Cliente datos_de_la_reservacion_del_cliente)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Cliente);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_de_la_reservacion_del_cliente);

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
        private void Enviar_actualizacion(Cliente datos_de_la_reservacion_del_cliente)
        {

            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UNA_RESERVACION_DE_UN_CLIENTE", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int64).Value = datos_de_la_reservacion_del_cliente.codigo;
            comando.Parameters.Add("p_codigo_reservacion", OracleDbType.Int32).Value = datos_de_la_reservacion_del_cliente.reservacion.codigo;
            comando.Parameters.Add("p_codigo_cliente", OracleDbType.Int32).Value = datos_de_la_reservacion_del_cliente.codigo;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar un servicio de una reservacion
        public Boolean borrar_una_reservacion_de_un_cliente(Datos_login Conexion_del_Cliente, Cliente datos_de_la_reservacion_y_su_cliente)
        {
            try
            {

                conexion(Conexion_del_Cliente);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_cliente(datos_de_la_reservacion_y_su_cliente);


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

        private void buscar_y_borrar_un_cliente(Cliente datos_de_la_reservacion_del_cliente)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UNA_RESERVACION_DE_UN_CLIENTE", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int32).Value = datos_de_la_reservacion_del_cliente.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los servicios de una reservacion
        DataTable reservacion_de_un_cliente = new DataTable();
        //Funcion para poder traer todos los usuario existentes
        public DataTable Consultar_Una_reservacion_de_un_cliente(Datos_login Conexion_del_Cliente, Cliente datos_de_la_reservacion_del_cliente)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                //Abir conexion
                ora.Open();

                traer_datos_del_servicio(datos_de_la_reservacion_del_cliente);

                //Cerrar conexion
                ora.Close();

                return reservacion_de_un_cliente;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la base de datos
        private void traer_datos_del_servicio(Cliente datos_de_la_reservacion_del_cliente)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_SERVICIOS_EN_UNA_RESERVACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Int32).Value = datos_de_la_reservacion_del_cliente.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(reservacion_de_un_cliente);
        }

    }
}
