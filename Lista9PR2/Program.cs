using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
        }
         public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
        }

        static void Main(string[] args) { 
            int program = 1;

            do
            {


                int p;
                Console.WriteLine("escolha um programa para executar(ex:1)");
                p = int.Parse(Console.ReadLine());

                Console.WriteLine("==========menu==========");
                Console.WriteLine("para executar o exercicio 1 digite 1");
                Console.WriteLine("para executar o exercicio 2 digite 2");
                Console.WriteLine("para executar o exercicio 3 digite 3");
                Console.WriteLine("para executar o exercicio 4 digite 4");
                Console.WriteLine("========================");


                switch (p)
                {
                    case 1:
                        int[] vet2;
                        int t, soma = 0, media;
                        Console.WriteLine("entre com o tamanho");
                        t = int.Parse(Console.ReadLine());
                        vet2 = new int[t];
                        Random rand = new Random();
                        for (int i = 0; i < t; i++)
                        {

                            vet2[i] = rand.Next(10, 50);
                            soma = soma + vet2[i];

                        }


                        for (int i = 0; i < t; i++)
                        {
                            Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
                        }
                        media = soma / t;
                        Console.WriteLine("a media é igual à: {0}", media);
                        break;

                    case 2:

                        int[] vet1;
                        int r, som = 0, somas = 0;
                        Console.WriteLine("entre com o tamanho");
                        t = int.Parse(Console.ReadLine());
                        vet1 = new int[t];
                        Random rando = new Random();
                        for (int i = 0; i < t; i++)
                        {

                            vet1[i] = rando.Next(10, 50);
                            if (vet1[i] % 2 == 0)
                            {
                                som = som + vet1[i];
                            }
                            else
                            {
                                somas = somas + vet1[i];
                            }

                        }


                        for (int i = 0; i < t; i++)
                        {
                            Console.WriteLine("posição[{0}] = {1}", i, vet1[i]);
                        }
                        Console.WriteLine("pares:{0}", som
        );
                        Console.WriteLine("impares:{0}", somas);
                        break;

                    case 3:
                        int[] vet3;
                        int h = 0, n, m, b;
                        int u;
                        Console.WriteLine("entre com o tamanho");
                        t = int.Parse(Console.ReadLine());
                        vet3 = new int[t];
                        Random random = new Random();
                        for (int c = 0; c < t; c++)
                        {
                            
                            vet3[c] = random.Next(0, 50);

                            n = vet3[c];




                            if (vet3[c] > n)
                            {
                                Console.WriteLine(vet3[c]);
                                m = vet3[c];
                            }
                            else if (vet3[c]> m)
                            {

                            }
                          
                       
                        }


                        for (int c = 0; c < t; c++)
                        {
                            Console.WriteLine("posição[{0}] = {1}", c, vet3[c]);
                        }
                      

                        break;
                }

            }
            while (program != 0);
        }
    }
}