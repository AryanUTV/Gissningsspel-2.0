namespace Nummergissningsspel_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartaSpel();
        }

        static void StartaSpel()
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 101);
            int attempts = 0;

            while (true)
            {
                attempts++;

                Console.Write("Gissa på ett tal mellan 1 - 100: ");
                Console.Write("Gissa på ett tal mellan 1 - 100: ");

                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Skriv ett giltigt tal!");
                    continue;
                }

                if (guess > secretNumber)
                {
                    Console.WriteLine("Du gissade för högt!");

                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Du gissade för lågt!");

                }
                else
                {
                    Console.WriteLine("Du gissade rätt!");
                    break;
                }
            }
            Console.WriteLine("Totala gissningar: " + attempts);
        }
    }
}
            
            
                
            
