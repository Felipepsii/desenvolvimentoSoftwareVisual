using System;

namespace Aula02
{ 

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escreva a Base: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Escreva a Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());


            double area = CalculaAreaTriangulo(largura, altura);

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                throw;
            }
            
        }

        static double CalculaAreaTriangulo(double largura, double altura){

        
        double area = largura * altura;

        

        Console.Write("A area equivale a: ");
        Console.WriteLine(area);

        return area;
        }

        static void escolher(int valor){

        Console.Write("Escolha qual moeda vc quer converter(1 para dolar, 2 para Euro e 3 para Pesos Argentinos): ");

        



        }



    }

    
}
