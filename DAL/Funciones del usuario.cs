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
    public class Funciones_del_usuario
    {

        //Variables para poder uso globar
        private OracleConnection ora;

        //Funcion para la conexion con la base de datos 
        private void conexion(Datos_login datos_de_conexion)
        {
            //Cadena de conexion para ingresar el nombre de usuario y su contraseña
            string conexion = $"DATA SOURCE=localhost:1521/xepdb1;PASSWORD={datos_de_conexion.constraseña};USER ID={datos_de_conexion.usuario};";

            //Instancia de la clase de oracleconection para la conexion a la base de datos de oracle
            this.ora = new OracleConnection(conexion);
        }

        //Funcion para poder regirtar un usuario
        public Boolean Ingresar_Un_Usuario(Datos_login Conexion_del_Usuario, Usuario datos_del_usuario)
        {

            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_del_usuario);


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

        //Funcion privada para registrar los datos del nuevo usuario
        private void Enviar_Datos(Usuario datos_usuario)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_INGRESAR_UN_USUARIO", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = datos_usuario.cedula;
                cmd.Parameters.Add("p_primer_nombre", OracleDbType.Varchar2).Value = datos_usuario.Primer_nombre;
                cmd.Parameters.Add("p.segundo_nombre", OracleDbType.Varchar2).Value = datos_usuario.Segundo_nombre;
                cmd.Parameters.Add("p.primer_apellido", OracleDbType.Varchar2).Value = datos_usuario.Primer_apellido;
                cmd.Parameters.Add("p.segundo_apellido", OracleDbType.Varchar2).Value = datos_usuario.Segundo_apellido;
                cmd.Parameters.Add("p.telefono", OracleDbType.Varchar2).Value = datos_usuario.telefono;
                cmd.Parameters.Add("p.correo", OracleDbType.Varchar2).Value = datos_usuario.correo_electronico;
                cmd.Parameters.Add("p.foto", OracleDbType.Char).Value = datos_usuario.Foto;
                cmd.Parameters.Add("p.sexo", OracleDbType.Blob).Value = datos_usuario.sexo;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda el listado de los usuarios guardados
        DataTable Tabla_Usuarios = new DataTable();
        //Funcion para poder traer todos los usuarios existentes
        public DataTable Consultar_Usuarios(Datos_login Conexion_del_Usuario)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_Usuarios;

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
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_USUARIOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_Usuarios);
        }

        

        //Funcion para poder modificar los datos de un usuario
        public Boolean Modificar_datos_del_usuario(Datos_login Conexion_del_Usuario, Usuario datos_nuevo_del_usuario)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Usuario);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_nuevo_del_usuario);

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
        private void Enviar_actualizacion(Usuario datos_nuevos_del_usuario)
        {

            //Comando para poder busacar el procedimiento en la base de datod y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UN_USUARIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.cedula;
            comando.Parameters.Add("p_primer_nombre", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.Primer_nombre;
            comando.Parameters.Add("p_segundo_nombre", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.Segundo_nombre;
            comando.Parameters.Add("p_primer_apellido", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.Primer_apellido;
            comando.Parameters.Add("p_segundo_apellido", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.Segundo_apellido;
            comando.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.telefono;
            comando.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.correo_electronico;
            comando.Parameters.Add("p_foto", OracleDbType.Blob).Value = datos_nuevos_del_usuario.Foto;
            comando.Parameters.Add("p_sexo", OracleDbType.Varchar2).Value = datos_nuevos_del_usuario.sexo;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar un usuario
        public Boolean borrar_un_usuario(Datos_login Conexion_del_Usuario, Usuario datos_del_usuario)
        {
            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_un_usuario(datos_del_usuario);


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

        private void buscar_y_borrar_un_usuario(Usuario datos_del_usuario_a_eliminar)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UN_USUARIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_usuario_a_eliminar.cedula;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los datos de un solo administrador
        DataTable Usuario = new DataTable();
        //Funcion para poder traer todos los usuario existentes
        public DataTable Consultar_Un_usuario(Datos_login Conexion_del_Usuario, Usuario datos_del_usuario)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                //Abir conexion
                ora.Open();

                traer_datos_de_un_administrador(datos_del_usuario);

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

        //Funcion privada para buscar en la base de dato al administrador
        private void traer_datos_de_un_administrador(Usuario datos_del_usuario)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_UN_SERVICIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_del_usuario.cedula;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Usuario);
        }

    }
}
