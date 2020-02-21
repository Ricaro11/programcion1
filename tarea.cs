using System;

public class Ejemplo
{
	public static void Main()
	{
		Ejemplo clase = new Ejemplo();
		clase.Contador();
		clase.HolaEstudiante("Pedro");
		clase.Azar();
	}
	void HolaEstudiante(string nombre)
	{
		Console.WriteLine("Hola, estudiante {0}. Bienvenido a programación I", nombre);
	}
	void Contador()
	{
		for (int i = 1; i < 50; i++)
		{
			Console.WriteLine(i);
		}
	}
	void Azar()
	{
		int oportunidades = 6;
		Random rand = new Random();
		int ran = rand.Next(1, 100);

		for (; oportunidades > 0; oportunidades--)
		{

			Console.WriteLine("Adivina el numero del 1 al 100 tienes {0} oportunidades", oportunidades);
			int entrada = Convert.ToInt32(Console.ReadLine());
			if (entrada == Convert.ToInt32(ran))
			{
				Console.WriteLine("Felicidades adivinaste");
				break;
			}
		}
		Console.WriteLine("El numero era {0}", ran);
	}
}
