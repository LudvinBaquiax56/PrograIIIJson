using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Telefono
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Memoria { get; set; }
        public string Categoria { get; set; }
        public string FechaDeIngreso { get; set; }
        public string Marca { get; set; }
        public double Descuento { get; set; }

        public Telefono(int codigo, string nombre, double precio, int memoria, string categoria, string fechaDeIngreso, string marca, double descuento)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Memoria = memoria;
            Categoria = categoria;  
            FechaDeIngreso = fechaDeIngreso;    
            Marca = marca;
            Descuento = descuento;
        }
    }
}
