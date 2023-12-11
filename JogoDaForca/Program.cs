using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo da Forca!");
        string palavraSecreta = "C#";
        char[] letrasCorretas = new char[palavraSecreta.Length];

        while (true)
        {
            Console.WriteLine("\nPalavra: " + ExibirPalavra(palavraSecreta, letrasCorretas));

            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;

            if (PalavraContemLetra(palavraSecreta, letra))
            {
                Console.WriteLine("\nLetra correta!");
                AdicionarLetraCorreta(palavraSecreta, letrasCorretas, letra);
            }
            else
            {
                Console.WriteLine("\nLetra incorreta. Tente novamente!");
            }

            if (PalavraAdivinhada(palavraSecreta, letrasCorretas))
            {
                Console.WriteLine("\nParabéns! Você adivinhou a palavra: " + palavraSecreta);
                break;
            }
        }
    }

    static string ExibirPalavra(string palavra, char[] letrasCorretas)
    {
        string palavraExibida = "";
        foreach (char letra in palavra)
        {
            if (letrasCorretas.Contains(letra))
            {
                palavraExibida += letra + " ";
            }
            else
            {
                palavraExibida += "_ ";
            }
        }
        return palavraExibida.Trim();
    }

    static bool PalavraContemLetra(string palavra, char letra)
    {
        return palavra.Contains(letra);
    }

    static void AdicionarLetraCorreta(string palavra, char[] letrasCorretas, char letra)
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == letra)
            {
                letrasCorretas[i] = letra;
            }
        }
    }

    static bool PalavraAdivinhada(string palavra, char[] letrasCorretas)
    {
        return palavra.SequenceEqual(letrasCorretas);
    }
}
