using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Pasteleria
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion {  get; set; }
        public DateTime FechaFabricacion { get; set; }
        public Cliente(int id_cliente, string nombre, string correo,string direccion)
        {
            Id_Cliente = id_cliente;
            Nombre = nombre;
            CorreoElectronico = correo;
            Direccion = direccion;
            FechaFabricacion = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id:{Id_Cliente}, Nombre:{Nombre}, Correo:{CorreoElectronico},Direccion{Direccion}, Fecha:{FechaFabricacion}";
        }
    }
}
    

