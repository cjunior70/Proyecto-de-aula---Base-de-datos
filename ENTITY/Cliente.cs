﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente: Datos_Personales
    {

        //Lista de reservaciones echas por el cliente
        public List<Reservacion> lista_de_reservaciones = new List<Reservacion>();

        //Constructor para acceso a la clase
        public Cliente()
        {
        }

        //Construtor para los datos personales de los clientes
        public Cliente(string nombre_de_usuario, string contraseña, char cargo, string cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int telefono, string correo_electronico, byte foto) : base(nombre_de_usuario, contraseña, cargo, cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono, correo_electronico, foto)
        {
        }

        //Construtor para la lisata de reservaciones echas
        public Cliente(List<Reservacion> lista_de_resetvaciones)
        {
            this.lista_de_reservaciones = lista_de_resetvaciones;
        }

    }
}