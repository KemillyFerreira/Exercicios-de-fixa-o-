using System;

namespace Exercícios_de_fixação
{
    class Program
    {
        static float CalcularMedia( float[] numeros )
        {
            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                //soma = soma + numeros[i]; variavel acumulativa
                soma += numeros[i];
            }

            float resultado = soma / numeros.Length;

            return resultado; 
        }

        static void Main(string[] args)
        {
            /*
            1-Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
                A. A Média do aluno - Função
                B. A quantidade de Aprovados  (Média >=7)
                C. A quantidade de Reprovados (Média <7)
                D. A Média geral dos 10 alunos.
            */

            
            //Criar as variáveis necessárias
            string[] nomes = new string[5];
            float[] medias = new float[5];
            float[] notas = new float [4];

            //Estruturaas de repetição
            //Laços contatos (já tem na sua sintaxe o contador)
            //nomes.Length => identifica o tamanho do array
            for (var i = 0; i < nomes.Length ; i++)
            {
                Console.WriteLine("Digite um nome de aluno : ");
                nomes[i] = Console.ReadLine();

                    for (int n = 0; n < notas.Length; n++)
                    {
                        Console.WriteLine($"Digite a {(n+1)}° nota: ");
                        notas[n] = float.Parse( Console.ReadLine() );    
                    }

                //Calculamos a média fora do laço de notas

                medias[i] = CalcularMedia(notas);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

                //Laços condicionais (condição)
            foreach (string nomeAvulso in nomes)
            {
                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;

                //Mostramos as infos
            for (var i = 0; i < nomes.Length; i++)
            {
                //Interpolação
                Console.WriteLine($"Nome: {nomes[i]} Média: {medias[i]} ");
            }

            Console.ResetColor();
            
            Console.WriteLine("Media geral da turma: " + CalcularMedia(medias));

        }
    }
}