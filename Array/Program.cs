using System;

namespace arrayAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números que deseja ter:");
            int x = int.Parse(Console.ReadLine());
            int[] arrayUsuario = new int[x];

            for (int i = 0; i < arrayUsuario.Length; i++)
            {
                Console.WriteLine("Digite seus números:");
                arrayUsuario[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < arrayUsuario.Length; i++)
            {
                Console.WriteLine("Posição {0}: {1}", i, arrayUsuario[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Deseja remover algum número? (s/n)");


            if (Console.ReadLine() == "s")
            {
                Console.WriteLine();
                Console.WriteLine("Digite o número desejado:");
                int numDelete = int.Parse(Console.ReadLine());

                int indiceNum = -1;

                for (int i = 0; i < arrayUsuario.Length; i++)
                {
                    int numAtual = arrayUsuario[i];

                    if (numDelete == arrayUsuario[i])
                    {
                        indiceNum = i;
                        Console.WriteLine("Número removido!");
                    }
                    else
                    {
                        Console.WriteLine($"Número[{numDelete}] não encontrado para remoção.");
                    }
                }

            }

            else
            {
                Console.WriteLine("Processamento Finalizado!");
            }

            Remover();

            void Remover()
            {

            }
        }
    }
}