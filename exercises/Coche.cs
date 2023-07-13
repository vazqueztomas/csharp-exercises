using System;
namespace exercises
{
//	1. Crea una clase Coche con las siguientes propiedades:

//– ID
//– Marca
//– Modelo
//– KM
//– Precio
    public class Coche
	{
		public int Id { get; set; }
		public string Marca { get; set; }
		public int Modelo { get; set; }
		public int Km { get; set; }
		public int Precio { get; set; }
		public Coche(int id, string marca, int modelo, int km, int precio)
		{
			Id = id;
			Marca = marca;
			Modelo = modelo;
			Km = km;
			Precio = precio;
		}

    }
}

