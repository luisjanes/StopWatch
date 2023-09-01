namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - 10s - para segundos");
            Console.WriteLine("M - 2m - para minutos");
            Console.WriteLine("Q - para sair");
            Console.WriteLine("Quantos segundos você quer seu contador??");
            string inTimeType = Console.ReadLine().ToLower();
            char type = char.Parse(inTimeType.Substring(inTimeType.Length - 1));
            bool testingIn = int.TryParse(inTimeType.Substring(0, inTimeType.Length - 1), out int inTime);
            if (!testingIn)
            {
                Console.WriteLine("Valor inválido.");
                Thread.Sleep(1500);
                Menu();
            }
            switch (type)
            {
                case 's':
                    PreStart(inTime);
                    break;
                case 'm':
                    PreStart(inTime * 60);
                    break;
                case 'q':
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Parametro não encontrado.");
                    Thread.Sleep(2000);
                    Menu();
                    break;
            }
        }
        static void PreStart(int inTime)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);  
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!!!");
            Thread.Sleep(1000);
            Console.Clear();
            Start(inTime);
        }

        static void Start(int time) 
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado! Retornando ao menu");
            Thread.Sleep(3000);
            Menu();
        }
    }
}

