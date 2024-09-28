using ENTITY;
using Oracle.ManagedDataAccess.Client;
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
    public class Funciones_de_la_ubicacion
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

        //Funcion para poder regirtar una ubiacion
        public Boolean Ingresar_Una_Ubicacion(Datos_login Conexion_del_usuario, Ubicacion datos_de_la_ubicacion)
        {

            try
            {

                conexion(Conexion_del_usuario);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_de_la_ubicacion);


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

        //Funcion privada para registrar los datos de una ubicacion
        private void Enviar_Datos(Ubicacion datos_de_ubicacion)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_INGRESAR_UNA_UBICACION", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_lalitud", OracleDbType.Double).Value = datos_de_ubicacion.latitud;
                cmd.Parameters.Add("p_longitud", OracleDbType.Double).Value = datos_de_ubicacion.longitud;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de las ubicaciones guardados
        DataTable Tabla_Empleados = new DataTable();
        //Funcion para poder traer todos las ubicaciones existentes
        public DataTable Consultar_Todas_las_ubicaciones(Datos_login Conexion_del_Usuario)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_Empleados;

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
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LAS_UBICACIONES", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_Empleados);
        }



        //Funcion para poder modificar los datos de una ubicacion
        public Boolean Modificar_datos_una_ubicacion(Datos_login Conexion_del_Usuario, Ubicacion datos_nuevo_de_una_ubicacion)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Usuario);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_nuevo_de_una_ubicacion);

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
        //Funcion privada para buscar en la base de datos ana ubicacion y actualizar sus datos
        private void Enviar_actualizacion(Ubicacion datos_de_ubicacion)
        {

            //Comando para poder busacar el procedimiento en la base de datod y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UNA_UBICACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int16).Value = datos_de_ubicacion.codigo;
            comando.Parameters.Add("p_lalitud", OracleDbType.Double).Value = datos_de_ubicacion.latitud;
            comando.Parameters.Add("p_longitud", OracleDbType.Double).Value = datos_de_ubicacion.longitud;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar una ubicacion
        public Boolean borrar_una_ubicacion(Datos_login Conexion_del_Usuario, Ubicacion datos_de_la_ubicacion)
        {
            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_una_ubicacion(datos_de_la_ubicacion);


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

        private void buscar_y_borrar_una_ubicacion(Ubicacion datos_de_la_ubicacion_a_eliminar)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UNA_UBICACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_de_la_ubicacion_a_eliminar.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los datos de una sola ubicacion
        DataTable Usuario = new DataTable();
        //Funcion para poder traer todos las ubicaciones existentes
        public DataTable Consultar_Un_Empleado(Datos_login Conexion_del_Usuario, Ubicacion datos_de_la_ubicacion)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                //Abir conexion
                ora.Open();

                traer_datos_de_una_ubicacion(datos_de_la_ubicacion);

                //Cerrar conexion
                ora.Close();

                return Usuario;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la base de dato a un empleado
        private void traer_datos_de_una_ubicacion(Ubicacion datos_del_usuario)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_UNA_UBICACION", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_usuario.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Usuario);
        }


    }
}
