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
    public class Funciones_de_Empresa
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

        //Funcion para poder regirtar una empresa
        public Boolean Ingresar_Una_Empresa(Datos_login Conexion_del_usuario, Empresa datos_de_la_empresa)
        {

            try
            {

                conexion(Conexion_del_usuario);

                //Abirir conexion
                ora.Open();


                Enviar_Datos(datos_de_la_empresa);


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

        //Funcion privada para registrar los datos de una empresa
        private void Enviar_Datos(Empresa datos_de_la_empresa)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_INGRESAR_UNA_EMPRESA", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = datos_de_la_empresa.nombre_de_la_empresa;
                cmd.Parameters.Add("p_Descripcion_De_la_empresa", OracleDbType.Varchar2).Value = datos_de_la_empresa.descripcion_de_la_empresa;
                cmd.Parameters.Add("p_whatsapp", OracleDbType.Varchar2).Value = datos_de_la_empresa.whatsapp;
                cmd.Parameters.Add("p_correo_electronico", OracleDbType.Varchar2).Value = datos_de_la_empresa.correo;
                cmd.Parameters.Add("p_instagram", OracleDbType.Varchar2).Value = datos_de_la_empresa.instagram;
                cmd.Parameters.Add("p_facebook", OracleDbType.Varchar2).Value = datos_de_la_empresa.facebook;
                cmd.Parameters.Add("p_descripcion_de_la_localizacion", OracleDbType.Varchar2).Value = datos_de_la_empresa.descripcion_de_la_localizacion;
                cmd.Parameters.Add("p_imagen_en_miniatura", OracleDbType.Blob).Value = datos_de_la_empresa.imagen_miniatura;
                cmd.Parameters.Add("p_imagen_general", OracleDbType.Blob).Value = datos_de_la_empresa.imagen_general;
                cmd.Parameters.Add("p_usuario_codigo", OracleDbType.Varchar2).Value = datos_de_la_empresa.usuario.codigo;
                cmd.Parameters.Add("P_ubicacion_codigo", OracleDbType.Varchar2).Value = datos_de_la_empresa.ubicaion.codigo;

                cmd.ExecuteNonQuery();
            }

        }

        //Variable para poder guarda las empresas registradas
        DataTable Tabla_De_Empresas = new DataTable();
        //Funcion para poder traer todos las empresa existentes
        public DataTable Consultar_Todas_las_Empresas(Datos_login Conexion_del_Usuario)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                ora.Open();

                traer_datos();

                ora.Close();

                return Tabla_De_Empresas;

            }
            catch (Exception)
            {
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la bases de datos todos las empresas registrados
        private void traer_datos()
        {
            OracleCommand comando = new OracleCommand("PK_MOSTRAR_TODOS_LOS_EMPRESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(Tabla_De_Empresas);
        }



        //Funcion para poder modificar los datos de una empresa
        public Boolean Modificar_datos_una_empresa(Datos_login Conexion_del_Usuario, Empresa datos_nuevo_de_la_empresa)
        {
            try
            {
                //Funcion para hacer la conexion con la base de datos
                conexion(Conexion_del_Usuario);

                //Abrir la conexion con la base
                ora.Open();

                //Funcion para enviar los datos nuevos a la base
                Enviar_actualizacion(datos_nuevo_de_la_empresa);

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

        //Funcion privada para buscar en la base de datos una empresa y actualizar sus datos
        private void Enviar_actualizacion(Empresa datos_de_empresa_actualizados)
        {

            //Comando para poder buscar el procedimiento en la base de datod y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ACTUALIZAR_DATOS_DE_UNA_EMPRESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.codigo;
            comando.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.nombre_de_la_empresa;
            comando.Parameters.Add("p_Descripcion_De_la_empresa", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.descripcion_de_la_empresa;
            comando.Parameters.Add("p_whatsapp", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.whatsapp;
            comando.Parameters.Add("p_correo_electronico", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.correo;
            comando.Parameters.Add("p_instagram", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.instagram;
            comando.Parameters.Add("p_facebook", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.facebook;
            comando.Parameters.Add("p_descripcion_de_la_localizacion", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.descripcion_de_la_localizacion;
            comando.Parameters.Add("p_imagen_en_miniatura", OracleDbType.Blob).Value = datos_de_empresa_actualizados.imagen_miniatura;
            comando.Parameters.Add("p_imagen_general", OracleDbType.Blob).Value = datos_de_empresa_actualizados.imagen_general;
            comando.Parameters.Add("p_usuario_codigo", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.usuario.codigo;
            comando.Parameters.Add("P_ubicacion_codigo", OracleDbType.Varchar2).Value = datos_de_empresa_actualizados.ubicaion.codigo;

            comando.ExecuteNonQuery();

        }

        //Funcion para poder borrar una empresa
        public Boolean borrar_una_empresa(Datos_login Conexion_del_Usuario, Empresa datos_de_una_empresa)
        {
            try
            {

                conexion(Conexion_del_Usuario);

                //Abirir conexion
                ora.Open();


                buscar_y_borrar_una_empresa(datos_de_una_empresa);


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

        private void buscar_y_borrar_una_empresa(Empresa datos_de_la_empresa_a_eliminar)
        {
            //Comando para poder busacar el procedimiento en la base de datos y enviar los datos
            OracleCommand comando = new OracleCommand("PK_ELIMINAR_UNA_EMPRESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_de_la_empresa_a_eliminar.codigo;

            comando.ExecuteNonQuery();
        }

        //Variable para traer los datos de una sola empresa
        DataTable empresa = new DataTable();
        //Funcion para poder traer todos las empresas existentes
        public DataTable Consultar_Una_Empresa(Datos_login Conexion_del_Usuario, Empresa datos_de_la_empresa)
        {

            try
            {
                conexion(Conexion_del_Usuario);

                //Abir conexion
                ora.Open();

                traer_datos_de_una_empresa(datos_de_la_empresa);

                //Cerrar conexion
                ora.Close();

                return empresa;

            }
            catch (Exception)
            {
                //Cerrar conexion
                ora.Close();

                return null;
            }

        }

        //Funcion privada para buscar en la base de dato a un empleado
        private void traer_datos_de_una_empresa(Empresa datos_de_la_empresa)
        {
            OracleCommand comando = new OracleCommand("PK_BUSCAR_UNA_EMPRESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;


            comando.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = datos_de_la_empresa.codigo;
            comando.Parameters.Add("p_registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(empresa);
        }


    }
}
