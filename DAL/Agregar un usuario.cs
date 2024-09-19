using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class Agregar_un_usuario
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

        //Funcion para poder regirtar un administrador
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

        //Funcion privada para registrar los datos del nuevo administrador
        private void Enviar_Datos(Usuario datos_usuario)
        {
            //Intancia para poder entrar a la funcion
            using (OracleCommand cmd = new OracleCommand("PK_PROCEDIMIENTO_DE_USUARIOS.P_REGISTRAR_USUARIO ", ora))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("v_admin.cedula", OracleDbType.Varchar2).Value = datos_usuario.cedula;
                cmd.Parameters.Add("v_admin.primer_nombre", OracleDbType.Varchar2).Value = datos_usuario.Primer_nombre;
                cmd.Parameters.Add("v_admin.segundo_nombre", OracleDbType.Varchar2).Value = datos_usuario.Segundo_nombre;
                cmd.Parameters.Add("v_admin.primer_apellido", OracleDbType.Varchar2).Value = datos_usuario.Primer_apellido;
                cmd.Parameters.Add("v_admin.segundo_apellido", OracleDbType.Varchar2).Value = datos_usuario.Segundo_apellido;
                cmd.Parameters.Add("v_admin.telefono", OracleDbType.Varchar2).Value = datos_usuario.telefono;
                cmd.Parameters.Add("v_admin.correo", OracleDbType.Varchar2).Value = datos_usuario.correo_electronico;
                cmd.Parameters.Add("v_admin.sexo", OracleDbType.Char).Value = datos_usuario.sexo;
                cmd.Parameters.Add("admin.sexo", OracleDbType.Blob).Value = datos_usuario.Foto;

                cmd.ExecuteNonQuery();
            }

        }

    }
}
