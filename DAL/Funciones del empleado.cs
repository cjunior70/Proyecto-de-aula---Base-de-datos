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
    public class Funciones_del_empleado
    {

        //Variables para poder uso globar
        private OracleConnection ora;

        //Funcion para la conexion con la base de datos 
        private void conexion(Datos_login datos_de_conexion)
        {
            //Cadena de conexion para ingresar el nombre de empleado y su contraseña
            string conexion = $"DATA SOURCE=localhost:1521/xepdb1;PASSWORD={datos_de_conexion.constraseña};USER ID={datos_de_conexion.usuario};";

            //Instancia de la clase de oracleconection para la conexion a la base de datos de oracle
            this.ora = new OracleConnection(conexion);
        }

        //Funcion para poder regirtar un empleado
        public Boolean Ingresar_Un_Empleado(Datos_login Conexion_del_usuario, Empleados datos_del_empleado, Empresa datos_de_la_empresa)
        {

            try
            {

                conexion(Conexion_del_usuario);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_del_empleado, datos_de_la_empresa);


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

        //Funcion privada para registrar los datos del nuevo empleado
        private void Enviar_Datos(Empleados datos_empleado,Empresa datos_de_la_empresa)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_INGRESAR_UN_EMPLEADO", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = datos_empleado.cedula;
                cmd.Parameters.Add("p_primer_nombre", OracleDbType.Varchar2).Value = datos_empleado.Primer_nombre;
                cmd.Parameters.Add("p.segundo_nombre", OracleDbType.Varchar2).Value = datos_empleado.Segundo_nombre;
                cmd.Parameters.Add("p.primer_apellido", OracleDbType.Varchar2).Value = datos_empleado.Primer_apellido;
                cmd.Parameters.Add("p.segundo_apellido", OracleDbType.Varchar2).Value = datos_empleado.Segundo_apellido;
                cmd.Parameters.Add("p.telefono", OracleDbType.Varchar2).Value = datos_empleado.telefono;
                cmd.Parameters.Add("p.correo", OracleDbType.Varchar2).Value = datos_empleado.correo_electronico;
                cmd.Parameters.Add("p.foto", OracleDbType.Blob).Value = datos_empleado.Foto;
                cmd.Parameters.Add("p_cupos_disponibles", OracleDbType.Int16).Value = datos_empleado.cupos_disponibles;
                cmd.Parameters.Add("p_fecha_de_inicio", OracleDbType.Date).Value = datos_empleado.fecha_de_inicio;
                cmd.Parameters.Add("p_fecha_final", OracleDbType.Date).Value = datos_empleado.fecha_de_final;
                cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = datos_empleado.estado;
                cmd.Parameters.Add("p_cargo", OracleDbType.Varchar2).Value = datos_empleado.cargo;
                cmd.Parameters.Add("p_Codigo_empresa", OracleDbType.Varchar2).Value = datos_de_la_empresa.codigo;
                cmd.Parameters.Add("p.sexo", OracleDbType.Char).Value = datos_empleado.sexo;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los empleados guardados
        DataTable Tabla_Empleados = new DataTable();
        //Funcion para poder traer todos los usuarios existentes
        public DataTable Consultar_Empleados(Datos_login Conexion_del_Usuario)
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
        //Funcion privada para buscar en la bases de datos todos los usuario registrados

        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_EMPLEADOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_Empleados);
        }



        //Funcion para poder modificar los datos de un usuario
        public Boolean Modificar_datos_del_usuario(Datos_login Conexion_del_Usuario, Empleados datos_nuevo_del_empleado, Empresa datos_de_la_empresa)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Usuario);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_nuevo_del_empleado,datos_de_la_empresa);

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
        //Funcion privada para buscar en la base de datos al usuario y actualizar sus datos
        private void Enviar_actualizacion(Empleados datos_nuevos_del_empleado, Empresa datos_de_la_empresa)
        {

            //Comando para poder busacar el procedimiento en la base de datod y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Int32).Value = datos_nuevos_del_empleado.codigo;
            comando.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.cedula;
            comando.Parameters.Add("p_primer_nombre", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.Primer_nombre;
            comando.Parameters.Add("p.segundo_nombre", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.Segundo_nombre;
            comando.Parameters.Add("p.primer_apellido", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.Primer_apellido;
            comando.Parameters.Add("p.segundo_apellido", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.Segundo_apellido;
            comando.Parameters.Add("p.telefono", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.telefono;
            comando.Parameters.Add("p.correo", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.correo_electronico;
            comando.Parameters.Add("p.foto", OracleDbType.Blob).Value = datos_nuevos_del_empleado.Foto;
            comando.Parameters.Add("p_cupos_disponibles", OracleDbType.Int16).Value = datos_nuevos_del_empleado.cupos_disponibles;
            comando.Parameters.Add("p_fecha_de_inicio", OracleDbType.Date).Value = datos_nuevos_del_empleado.fecha_de_inicio;
            comando.Parameters.Add("p_fecha_final", OracleDbType.Date).Value = datos_nuevos_del_empleado.fecha_de_final;
            comando.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.estado;
            comando.Parameters.Add("p_cargo", OracleDbType.Varchar2).Value = datos_nuevos_del_empleado.cargo;
            comando.Parameters.Add("p_Codigo_empresa", OracleDbType.Varchar2).Value = datos_de_la_empresa.codigo;
            comando.Parameters.Add("p.sexo", OracleDbType.Char).Value = datos_nuevos_del_empleado.sexo;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar un empleado
        public Boolean borrar_un_empleado(Datos_login Conexion_del_Usuario, Empleados datos_del_empleado)
        {
            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_usuario(datos_del_empleado);


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

        private void buscar_y_borrar_un_usuario(Empleados datos_del_usuario_a_eliminar)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_usuario_a_eliminar.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los datos de un solo administrador
        DataTable Usuario = new DataTable();
        //Funcion para poder traer todos los usuario existentes
        public DataTable Consultar_Un_Empleado(Datos_login Conexion_del_Usuario, Empleados datos_del_usuario)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                //Abir conexion
                ora.Open();

                traer_datos_de_un_empleado(datos_del_usuario);

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
        private void traer_datos_de_un_empleado(Empleados datos_del_usuario)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_UN_EMPLEADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_usuario.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Usuario);
        }

    }
}
