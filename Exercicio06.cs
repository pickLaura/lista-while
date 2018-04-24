using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWhile
{
    class Exercicio06
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\n|codigo  |tipo       |nome                        | Valor  |" +
                            "\n  |__________________________________________________________|" +
                            "\n  | 1      |Bolo       |Bolo brijadeiro             |R$29.50 |" +
                            "\n  |2       |Bolo       |Bolo floresta negra         |R$2.00  |" +
                            "\n  |3       |bolo       |bolo leita com nutella      |R$29.23 |" +
                            "\n  |4       |bolo       |bolo muse de chocolate      |R$7.10  |" +
                            "\n  |5       |bolo       |bolo nega maluca            |R$19.33 |" +
                            "\n  |6       |Doces      |bomba de creme              |R$17.71 |" +
                            "\n  |7       |Doce       |bomba de morango            |R$4.82  |" +
                            "\n  |8       |Sanduiche  |file mignon com fritas      |R$21.16 |" +
                            "\n  |9       |sanduiche  |Hanburguer com queijos      |R$12.70 |" +
                            "\n  |        |           |champignon e rucula         |        |" +
                            "\n  |10      |sanduiche  |Provolone com salame        |R$19.70 |" +
                            "\n  |11      |Sanduiche  |Vegetariano de beringela    |R$28.22 |" +
                            "\n  |12      |Pizza      |calabreva                   |R$8.98  |" +
                            "\n  |13      |Pizza      |Napolitana                  |R$0.45  |" +
                            "\n  |14      |Pizza      |pereuina                    |R$18.36 |" +
                            "\n  |15      |Pizza      |portuguesa                  |R$17.50 |" +
                            "\n  |16                |sair                                   |" +
                            "\n  |_________________________________________________________ |");
            int codigo = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0;
            int quantidadeBolo = 0;
            int quantidadeDoces = 0;
            int quantidadeSand = 0;
            int quantidadePizza = 0;
            int produto = 0;
            double valorTotal = 0;

            while (codigo != 16)
            {
                if (codigo == 1)
                {

                    Console.WriteLine("digite um codigo");
                    valorTotal = valorTotal + 29.50;
                    quantidadeBolo = quantidadeBolo + 1;

                }
                else if (codigo == 2)
                {
                    Console.WriteLine("digite um codigo");

                    valorTotal = valorTotal + 2.00;
                    quantidadeBolo = quantidadeBolo + 1;


                }
                else if (codigo == 3)
                {
                    Console.WriteLine("digite um codigo");

                    valorTotal = valorTotal + 29.23;
                    quantidadeBolo = quantidadeBolo + 1;


                }
                else if (codigo == 4)
                {

                    Console.WriteLine("digite um codigo");

                    valorTotal = valorTotal + 7.10;
                    quantidadeBolo = quantidadeBolo + 1;
                }
                else if (codigo == 5)
                {
                    Console.WriteLine("digite um codigo");

                    valorTotal = valorTotal + 19.33;
                    quantidadeBolo = quantidadeBolo + 1;


                }
                else if (codigo == 6)
                {
                    Console.WriteLine("digite um codigo");

                    valorTotal = valorTotal + 17.71;
                    quantidadeDoces = quantidadeDoces + 1;

                }
                else if (codigo == 7)
                {
                    Console.WriteLine("digite um codigo");

                    valorTotal = valorTotal + 4.82;
                    quantidadeDoces = quantidadeDoces + 1;
                }
                else if (codigo == 8)
                {
                    Console.WriteLine("digite um codigo");
                    valorTotal = valorTotal + 21.16;
                    quantidadeSand = quantidadeSand + 1;



                }
                else if (codigo == 9)
                {
                    Console.WriteLine("digite um codigo");
                    valorTotal = valorTotal + 12.70;
                    quantidadeSand = quantidadeSand + 1;


                }
                else if (codigo == 10)
                {
                    Console.WriteLine("digite um codigo");

                    quantidadeSand = quantidadeSand + 1;
                    valorTotal = valorTotal + 19.70;

                }
                else if (codigo == 11)
                {
                    Console.WriteLine("digite um codigo");

                    quantidadeSand = quantidadeSand + 1;
                    valorTotal = valorTotal + 28.22;
                }
                else if (codigo == 12)
                {
                    Console.WriteLine("digite um codigo");

                    quantidadePizza = quantidadePizza + 1;
                    valorTotal = valorTotal + 8.98;

                }
                else if (codigo == 13)
                {
                    Console.WriteLine("digite um codigo");

                    quantidadePizza = quantidadePizza + 1;
                    valorTotal = valorTotal + 18.36;
                }
                else if (codigo == 14)
                {
                    Console.WriteLine("digite um codigo");

                    quantidadePizza = quantidadePizza + 1;
                    valorTotal = valorTotal + 18.36;
                }
                else if (codigo == 15)
                {
                    Console.WriteLine("digite um codigo");

                    quantidadePizza = quantidadePizza + 1;
                    valorTotal = valorTotal + 17.50;

                }

                Console.WriteLine("\n|codigo  |tipo       |nome                        | Valor  |" +
                    "\n  |__________________________________________________________|" +
                    "\n  | 1      |Bolo       |Bolo brijadeiro             |R$29.50 |" +
                    "\n  |2       |Bolo       |Bolo floresta negra         |R$2.00  |" +
                    "\n  |3       |bolo       |bolo leita com nutella      |R$29.23 |" +
                    "\n  |4       |bolo       |bolo muse de chocolate      |R$7.10  |" +
                    "\n  |5       |bolo       |bolo nega maluca            |R$19.33 |" +
                    "\n  |6       |Doces      |bomba de creme              |R$17.71 |" +
                    "\n  |7       |Doce       |bomba de morango            |R$4.82  |" +
                    "\n  |8       |Sanduiche  |file mignon com fritas      |R$21.16 |" +
                    "\n  |9       |sanduiche  |Hanburguer com queijos      |R$12.70 |" +
                    "\n  |        |           |champignon e rucula         |        |" +
                    "\n  |10      |sanduiche  |Provolone com salame        |R$19.70 |" +
                    "\n  |11      |Sanduiche  |Vegetariano de beringela    |R$28.22 |" +
                    "\n  |12      |Pizza      |calabreva                   |R$8.98  |" +
                    "\n  |13      |Pizza      |Napolitana                  |R$0.45  |" +
                    "\n  |14      |Pizza      |pereuina                    |R$18.36 |" +
                    "\n  |15      |Pizza      |portuguesa                  |R$17.50 |" +
                    "\n  |16                |sair                                   |" +
                    "\n  |_________________________________________________________ |");

                codigo = Convert.ToInt32(Console.ReadLine());
            }




            quantidade = quantidadeBolo + quantidadePizza + quantidadeSand + quantidadeDoces;
            double media = valorTotal / quantidade;
            Console.WriteLine("Quantidade de Bolo " + quantidadeBolo);
            Console.WriteLine("Quantidade de Doces " + quantidadeDoces);
            Console.WriteLine("Quantidade de sanduiche " + quantidadeSand);
            Console.WriteLine("Quantidade de pizza " + quantidadePizza);
            Console.WriteLine("Media " + media);


        }
    }
}
