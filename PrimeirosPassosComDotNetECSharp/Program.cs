using System;

namespace PrimeirosPassosComDotNetECSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numeroDeVezes = 10;
            // for (int i = 0; i < numeroDeVezes; i++)
            // {
            //     Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
            // }

            var pilha = new Pilha();
            pilha.Empilha(1);
            pilha.Empilha(10);
            pilha.Empilha(100);
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
        }
    }
}
