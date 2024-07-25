


using System.Drawing;

namespace EjercicioHerencia
{
    public class Implementacion : Operaciones
    {
        public override double Area(double b, double altura)
        {
            double area = (b * altura);
            return area;
        }
        public override double Cuadrado(double x)
        {
            double cuadrado = Math.Pow(x, 2);
            return cuadrado;
        }
        
        

         public override double Redondear(double x)
        {
            double redondear = Math.Round(x);
            return redondear;
        }
            
        

    public override double RaizCubica(double x)
    {
        double raizcubica = Math.Cbrt(x);

        return raizcubica;

         
    }
        
        public void Imprimir()
        {
          
            Console.WriteLine($"Sacar area: {Area}");
            Console.WriteLine($"Elevar al cuadrado: {Cuadrado}");
            Console.WriteLine($"Redondear: {Redondear}");
            Console.WriteLine($"Sacar Raiz Cubica: {RaizCubica}");




        }

    }
}
