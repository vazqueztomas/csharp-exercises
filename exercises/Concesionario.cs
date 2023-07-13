using System;
using exercises;
namespace exercises
{
	public class Concesionario
	{
		private Coche[] Coches;
		private int Limite;
		private int CantCoches;
		public Concesionario(int limite)
		{
			this.Coches = new Coche[limite];
			Limite = limite;
			CantCoches = 0;
		}

		public void AddCoche(Coche c)
		{
			if (c != null && CantCoches < Coches.Length)
			{
				Coches[CantCoches] = c;
				CantCoches++;
			}
		}

		public void MostrarCoches()
		{
			foreach(Coche coche in Coches)
			{
				Console.WriteLine(coche);
			}
		}

		public void VaciarCoches()
		{
			this.Coches = new Coche[Limite];
			CantCoches = 0;
		}

		public void EliminarCoche(Coche c)
		{
			if (c != null && CantCoches != 0)
			{
				int posicion = -1;
				for (int i = 0; i < CantCoches; i++)
				{
					if (c.Id == Coches[i].Id)
					{
						posicion = i;
					}
				};
				if (posicion == -1)
				{
					Console.WriteLine("No existe el coche.");
				} else
				{
					Coches[posicion] = null;

					for (int i = posicion; i < CantCoches; i++)
					{
						Coches[i] = Coches[i + 1];
					}
				}

			}
		}
	}
}

