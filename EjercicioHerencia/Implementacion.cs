


using System.Drawing;

namespace EjercicioHerencia
{
    public class Implementacion : Operaciones
    {

        public double N1 { get; set; }
        public double N2 { get; set; } 

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
          
            Console.WriteLine($"Sacar area: {Area(N1,N2)}");
            Console.WriteLine($"Elevar al cuadrado: {Cuadrado(N1)}");
            Console.WriteLine($"Redondear: {Redondear(N1)}");
            Console.WriteLine($"Sacar Raiz Cubica: {RaizCubica(N1)}");




        }

    }
}
