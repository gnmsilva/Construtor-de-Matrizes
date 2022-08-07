using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosModulo13EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Colando um cabaçalho por um método criado separado.
            Cabecalho();

            // Solicitando e lendo a quantidade de colunas para a matriz.
            Console.WriteLine("Informar a quantidade de colunas para a matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            // Solicitando e lendo a quantidade de linhas para a matriz.
            Console.WriteLine("\nAgora, informe o número de linhas para a matriz");
            int linhas = int.Parse(Console.ReadLine());

            // Limpando Console
            Console.Clear();

            // Criando uma matriz de inteiros de acordo com qtde de linhas e colunas informadas.
            int[,] matrizPrincipal = new int[linhas, colunas];

            // Passando por cada indice da matriz e pedindo para informar um valor para ser armazenado.
            for (int c = 0; c < colunas; c ++)
            {
                Cabecalho();
                for (int l = 0; l < linhas; l ++)
                {                    
                    Console.WriteLine($"\nDigite um valor para a posição para a linha {l + 1} da coluna {c + 1}:");
                    matrizPrincipal[l, c] = int.Parse(Console.ReadLine());                    
                }
                Console.Clear();
            }

            // Criando um array que armazerá as somas das colunas.
            // Tamanho do array é definido pelo números de colunas informados pelo usuário.
            int[] somasColunas = new int[colunas];

            // Chamando cabeçalho.
            Cabecalho();

            // Chamando Método que imprime a matriz na tela com seus parâmetros.
            ImprimirMatriz(matrizPrincipal, linhas, colunas);

            // Passando por cada linha de cada colunas para fazer a soma dos valores por coluna.
            // A soma é armazenada em ordem no array criado anteriormente 'somasColunas'.
            for (int c = 0; c < colunas; c++)
            {
                int soma = 0;
                for (int l = 0; l < linhas; l++)
                {
                    soma += matrizPrincipal[l, c];
                }
                somasColunas[c] = soma;

                Console.WriteLine($"\nA soma da coluna {c + 1} é igual a {somasColunas[c]}!");
            }
        }
       
        /// <summary>
        /// Imprime o cabeçalho criado
        /// </summary>
        public static void Cabecalho()
        {
            Console.WriteLine($"{string.Concat(Enumerable.Repeat('=', 50))}\n" +
                $"{string.Concat(Enumerable.Repeat(' ', 15))}Construindo Matrizes{string.Concat(Enumerable.Repeat(' ', 15))}" +
                $"\n{string.Concat(Enumerable.Repeat('=', 50))}");
        }


        /// <summary>
        /// Imprime a matriz na tela passando como parâmetros a matriz, a qtde de linhas e de colunas
        /// </summary>
        /// <param name="mat">Matriz a ser impressa</param>
        /// <param name="lin">Quantidade de linhas da matriz</param>
        /// <param name="col">Quantidade de colunas da matriz</param>
        public static void ImprimirMatriz(int[,] mat,int lin, int col)
        {
            Console.WriteLine("\nA matriz informada foi: ");
            for (int l = 0; l < lin; l++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (c == 0) { Console.Write('\n'); }
                    Console.Write($"{mat[l,c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
