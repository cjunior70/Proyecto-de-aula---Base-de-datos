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
    public class Funciones_para_agregar_un_servicio_a_una_empresa
    {

        //Variables para poder uso globar
        private OracleConnection ora;

        //Funcion para la conexion con la base de datos 
        private void conexion(Datos_login datos_de_conexion)
        {
            //Cadena de conexion para ingresar el un servicio a una empresa
            string conexion = $"DATA SOURCE=localhost:1521/xepdb1;PASSWORD={datos_de_conexion.constraseña};USER ID={datos_de_conexion.usuario};";

            //Instancia de la clase de oracleconection para la conexion a la base de datos de oracle
            this.ora = new OracleConnection(conexion);
        }

        //Funcion para poder regirtar un cliente
        public Boolean Ingresar_Un_Servicio_a_una_Empresa(Datos_login Conexion_del_cliente, Servicio_de_una_Empresa datos_del_servicio_de_la_empresa_y_su_servicio)
        {

            try
            {

                conexion(Conexion_del_cliente);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_del_servicio_de_la_empresa_y_su_servicio);


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

        //Funcion privada para registrar los datos de un servicio a una empresa
        private void Enviar_Datos(Servicio_de_una_Empresa datos_del_servicio_de_la_empresa_y_su_servicio)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_REGISTRAR_UN_SERVICO_A_UNA_EMPRESA", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_servicios_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_de_la_empresa_y_su_servicio.codigo_del_servicio;
                cmd.Parameters.Add("p_empleado_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_de_la_empresa_y_su_servicio.codigo_de_la_empresa;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los servicios de la empresa
        DataTable Tabla_de_los_servicios_de_la_empresa = new DataTable();
        //Funcion para poder traer todos los usuarios existentes
        public DataTable Consultar_servicios_de_un_empresa(Datos_login Conexion_del_Cliente)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_de_los_servicios_de_la_empresa;

            }
            catch (Exception)
            {
                ora.Close();

                return null;
            }

        }
        //Funcion privada para buscar en la bases de datos todos los servicios y sus empresas
        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_SERVICIOS_Y_EMPRESAS_RELACIONADOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_de_los_servicios_de_la_empresa);
        }


        //Funcion para poder modificar los datos de un servicio de una empresa
        public Boolean Modificar_datos_de_un_servicio_De_una_Empresa(Datos_login Conexion_del_Cliente, Servicio_de_una_Empresa datos_del_servicio_de_la_empresa_y_su_servicio)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Cliente);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_del_servicio_de_la_empresa_y_su_servicio);

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
        //Funcion privada para buscar en la base de datos el servicio y la empresa
        private void Enviar_actualizacion(Servicio_de_una_Empresa datos_del_servicio_de_la_empresa_y_su_servicio)
        {

            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UN_SERVICO_DE_UN_EMPRESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int64).Value = datos_del_servicio_de_la_empresa_y_su_servicio.codigo;
            comando.Parameters.Add("p_codigo_servicio", OracleDbType.Varchar2).Value = datos_del_servicio_de_la_empresa_y_su_servicio.codigo_del_servicio;
            comando.Parameters.Add("p_codigo_empleado", OracleDbType.Varchar2).Value = datos_del_servicio_de_la_empresa_y_su_servicio.codigo_de_la_empresa;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar una empresa
        public Boolean borrar_un_servicio_de_una_empresa(Datos_login Conexion_del_Cliente, Servicio_de_una_Empresa datos_del_servicio_de_la_empresa)
        {
            try
            {

                conexion(Conexion_del_Cliente);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_cliente(datos_del_servicio_de_la_empresa);


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

        private void buscar_y_borrar_un_cliente(Servicio_de_una_Empresa datos_del_servicio_de_una_empresa)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UN_SERVICIO_DE_UNA_EMPRESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_de_una_empresa.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los servicios de una empresa
        DataTable servicio_de_un_empleado = new DataTable();
        //Funcion para poder traer todos los usuario existentes
        public DataTable Consultar_Un_Servicio_de_una_empresa(Datos_login Conexion_del_Cliente, Servicio_de_una_Empresa datos_del_servicio_de_una_empresa)
        {

            try
            {
                conexion(Conexion_del_Cliente);

                //Abir conexion
                ora.Open();

                traer_datos_del_servicio(datos_del_servicio_de_una_empresa);

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
        private void traer_datos_del_servicio(Servicio_de_una_Empresa datos_del_servicio_de_la_empresa)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_SERVICIOS_DE_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_servicio_de_la_empresa.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(servicio_de_un_empleado);
        }


    }
}
