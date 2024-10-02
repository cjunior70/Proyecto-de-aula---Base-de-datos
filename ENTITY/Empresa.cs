using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Empresa
    {
        //Datos del propietario o el usario
        public Usuario usuario = new Usuario();
        //Ubicacion de la empresa
        public Ubicacion ubicaion = new Ubicacion();
        //Lista de los empleados de la empresa
        public List<Empleados> lista_de_empleados = new List<Empleados>();
        //Lista de los servicios disponivles de la empresa
        public List<Servicios> lista_de_servicios = new List<Servicios>();

        //Datos de la empresa
        public string codigo { get; set; }
        public string nombre_de_la_empresa { get; set; }
        public string descripcion_de_la_empresa { get; set; }
        public int extrellas { get; set; }
        public string whatsapp {  get; set; }
        public string correo {  get; set; }
        public string instagram {  get; set; }
        public string facebook { get; set; }
        public string descripcion_de_la_localizacion { get; set; }
        public byte imagen_miniatura { get; set; }
        public byte imagen_general { get; set; }

        //Constructor para el acceso a la clase
        public Empresa()
        {
        }

        //Construtor de los
        public Empresa(Usuario usuario, Ubicacion ubicaion, List<Empleados> lista_de_empleados, List<Servicios> lista_de_servicios, string codigo, string nombre_de_la_empresa, string descripcion_de_la_empresa, int extrellas, string whatsapp, string correo, string instagram, string facebook, string descripcion_de_la_localizacion, byte imagen_miniatura, byte imagen_general)
        {
            this.usuario = usuario;
            this.ubicaion = ubicaion;
            this.lista_de_empleados = lista_de_empleados;
            this.lista_de_servicios = lista_de_servicios;
            this.codigo = codigo;
            this.nombre_de_la_empresa = nombre_de_la_empresa;
            this.descripcion_de_la_empresa = descripcion_de_la_empresa;
            this.extrellas = extrellas;
            this.whatsapp = whatsapp;
            this.correo = correo;
            this.instagram = instagram;
            this.facebook = facebook;
            this.descripcion_de_la_localizacion = descripcion_de_la_localizacion;
            this.imagen_miniatura = imagen_miniatura;
            this.imagen_general = imagen_general;
        }
    }
}
