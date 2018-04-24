using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWhile
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.WriteLine("digite um numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite Outro numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(
                           "*\n|____________________________________|" +
                          " *\n|                menu                |" +
                           "*\n|____________________________________|" +
                           "*\n|1                 |somar            |" +
                           "*\n|2                 |subtrair         |" +
                           "*\n|3                 |multiplicar      |" +
                           "*\n|4                 |Dividir          |" +
                           "*\n|5                 |Sair             |" +
                           "*\n|__________________|_________________|");
            int continuar = Convert.ToInt32(Console.ReadLine());



            while (continuar != 5)
            {

                if (continuar == 1)
                {
                    double somar1 = numero1 + numero2;
                    Console.WriteLine("Soma: " + somar1);

                }
                if (continuar == 2)
                {
                    double subtrair2 = numero1 - numero2;

                    Console.WriteLine("Subtrair: "+subtrair2);
                }
                else if (continuar == 3)
                {
                    double mulitplicar3 = numero1 * numero2;
                    Console.WriteLine("multiplicar: "+mulitplicar3);
                    
                }
                else if (continuar == 4)
                {
                    double Dividir4 = numero1 / numero2;
                    Console.WriteLine("Dividir" + Dividir4);

                }
                Console.Clear();

                Console.WriteLine(
                          "*\n|____________________________________|" +
                         " *\n|                menu                |" +
                          "*\n|____________________________________|" +
                          "*\n|1                 |somar            |" +
                          "*\n|2                 |subtrair         |" +
                          "*\n|3                 |multiplicar      |" +
                          "*\n|4                 |Dividir          |" +
                          "*\n|5                 |Sair             |" +
                          "*\n|__________________|_________________|");


            }
        }
    }
}
