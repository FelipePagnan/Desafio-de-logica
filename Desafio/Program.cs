using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja calcula a media?");
            Console.WriteLine("'s' para sim, 'n' para não");
            char resp = char.Parse(Console.ReadLine().ToLower());

            

            while(resp == 's')
            {
                Console.WriteLine("Quantas notas deseja calcular?");
                int num = int.Parse(Console.ReadLine());

                double nota = 0;
                double media = 0;
                double resultado = 0;

                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Informe a nota " + i);
                    nota = double.Parse(Console.ReadLine());

                    media += nota;

                    resultado = media / num;

                }
                Console.WriteLine("Sua media é: " + resultado);
                
                if(resultado >= 6)
                {
                    Console.WriteLine("Aprovado.");
                }
                else
                {
                    Console.WriteLine("Reprovado.");
                }

                Console.WriteLine("Deseja calcular outra media?");
                Console.WriteLine("'s' para sim, 'n' para não");
                resp = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Finalizado.");


            Console.ReadLine();
        }
    }
}
