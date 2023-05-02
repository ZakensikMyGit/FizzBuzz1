namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<><><>\tZagrajmy w FizzBuzz\t<><><>\n******\t    Podaj liczbę:\t******\n");
            int number = GetNumber();

            var fizzBuzz = new FizzBuzz();
            Console.WriteLine(fizzBuzz.GetFizzBuzz(number));

            

            Console.ReadLine();
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine("Podaj liczbę");
                    continue;
                }
                return result;
            }
        }
    }
}