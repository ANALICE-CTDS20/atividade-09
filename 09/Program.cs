

using System;

class Program
{
    static void Main()
    {
        // Declaração e inicialização do vetor de nomes
        string[] nomes = { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };




        
    {
        static void Main()
        {
            // Declaração e inicialização do vetor de nomes
            string[] nomes = { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };

            // Solicita ao usuário o nome para pesquisar
            Console.Write("Digite um nome para pesquisar: ");
            string nomeBusca = Console.ReadLine();

            // Variável para controlar se o nome foi encontrado
            bool encontrado = false;

            // Loop para percorrer o vetor de nomes
            foreach (string nome in nomes)
            {
                if (nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break; // Sai do loop assim que encontrar
                }
            }

            // Exibe o resultado da busca
            if (encontrado)
            {
                Console.WriteLine($"O nome {nomeBusca} foi encontrado no vetor.");
            }
            else
            {
                Console.WriteLine($"O nome {nomeBusca} não está no vetor.");
            }
        }
    




