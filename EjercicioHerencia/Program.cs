using EjercicioHerencia;
double opcion=0;
Implementacion implementacion = new Implementacion();
Console.WriteLine("1.Sacar area presione ");
Console.WriteLine("2.Elevar numero al cuadrado ");
Console.WriteLine("3.Redondear un numero");
Console.WriteLine("4.Sacar raiz cubica de un numero");
Console.WriteLine("5.Salir");
opcion = Convert.ToDouble(Console.ReadLine());
switch (opcion)
{
	case 1:
		{
			Console.WriteLine("Ingrese la base: ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la altura: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine(implementacion.Area(b, a));

			break;

		}
	case 2:
		{
			Console.WriteLine("Ingrese un numero para elevarlo al cuadrado: ");
			double numero = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine(implementacion.Cuadrado(numero));
		}
		break;

	case 3:
		{
			Console.WriteLine("Ingrese un numero para redondearlo: ");
			double numero = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine(implementacion.Redondear(numero));
			break;

		}

	case 4:
		{
			Console.WriteLine("Ingrese un numero para sacarle la raiz cubica: ");
			double numero = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine(implementacion.RaizCubica(numero));
			break;

		}
	case 5:

	default:

		Console.WriteLine("Opcion no valida");
			break;

		

		

	
}


