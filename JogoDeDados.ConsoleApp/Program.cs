namespace JogoDeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoJogador = 0;
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("_____________________________________");

                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    Random geradorDeNumeros = new Random();

                    int resultado = geradorDeNumeros.Next(1, 7);

                    Console.WriteLine("_____________________________________");
                    Console.WriteLine($"O valor sorteado foi: {resultado}");
                    Console.WriteLine("_____________________________________");

                    posicaoJogador += resultado;

                    Console.WriteLine($"Voce está na posição {posicaoJogador} de {limiteLinhaChegada}");

                    if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 20)
                    {
                        posicaoJogador += 3;

                        Console.WriteLine("_____________________________________");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas");
                        Console.WriteLine($"Voce avançou para a posição: {posicaoJogador}");
                    }

                    if (posicaoJogador == 8 || posicaoJogador == 13 || posicaoJogador == 21)
                    {
                        posicaoJogador -= 4;

                        Console.WriteLine("_____________________________________");
                        Console.WriteLine("EVENTO ESPECIAL: Volte 4 casas");
                        Console.WriteLine($"Voce voltou para a posição: {posicaoJogador}");
                    }

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("Parabéns!");
                        Console.WriteLine("__________________________________");
                    }

                    Console.WriteLine("_____________________________________");
                    Console.ReadLine();
                }

                Console.WriteLine("Pressione 'ENTER' para continuar");
                Console.ReadLine();
            }
        }
    }
}
    

