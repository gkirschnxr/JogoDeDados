namespace JogoDeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
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


                Console.Write("Pressione ENTER para continuar");
                Console.ReadLine();
            }
        }
    }
}
