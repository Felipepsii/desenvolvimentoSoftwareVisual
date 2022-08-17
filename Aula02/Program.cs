using System;

namespace Aula02
{ 

    class Program
    {
        static void Main(string[] args)
        {

            
            Ex4();
        }

        static void Ex1(){

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

        static void Ex2(){

        Console.Write("valor para conversão: ");
        double dinheiros = Convert.ToDouble(Console.ReadLine());


        Console.Write("Escolha qual moeda vc quer converter(1 para dolar, 2 para Euro e 3 para Pesos Argentinos): ");

            double moeda = Convert.ToInt16(Console.ReadLine());

            double resultado = 0;
        
             try
             {
                 switch(moeda){
                        case 1:
                    
                    resultado = dinheiros * 5.17;

                Console.Write(dinheiros + " em dolar (5,17) é " + resultado);
                    break;
                 }
                 switch(moeda){
                        case 2:

                    resultado = dinheiros * 6.14;

                Console.Write(dinheiros + " em euros (6,14) é " + resultado);

                    break;
                  }  

                 switch(moeda){
                        case 3:
                    resultado = dinheiros * 0.05;

                Console.Write(dinheiros + " em pesos argentinos (0,05) é " + resultado);
                    break;
                 }   
                 


             }
             catch (Exception erro)
             {
                 Console.WriteLine(erro.Message);
                 throw;
             }

        }

        static void Ex3(){

            Console.Write("Escreva 2 numeros que vou te dizer o maior e o menor, primeiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.Write(num1 + " é o numero maior e " +  num2 + " é o menor");
            }else{
                Console.Write(num2 + " é o numero maior"  +  num1 + " é o menor");
            }


        }

        static void Ex4(){
            Console.Write("Digite a idade da pessoa e direi se ela é criança, adolescente, gente ou idoso: ");

            int idade = Convert.ToInt32(Console.ReadLine());

           if (idade <= 13 || idade > 0)
            {
                Console.Write("É crinça");
            }else if (idade > 14 || idade <= 18){
                Console.Write("É adolescente");
            }else if (idade > 19 || idade <= 60){
                Console.Write("É gente");
            }else if (idade > 61){
                Console.Write("É idoso");
            }

        }

        static void Ex5(){
            
        }

    }

    
}
