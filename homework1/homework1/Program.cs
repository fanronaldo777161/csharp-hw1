namespace homework1
{
    internal class Program
    {
        //обнуляет разряд десятков
        static int secondnumtozero(int n)
        {
            int h = (n / 100) * 100;
            int u = n % 10;
            return h + u;
        }

        static string deckcolor(int x, int y)
        {
            if ((x + y) % 2 == 0)
                return "Black";
            else
                return "White";
        }
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine(secondnumtozero(123));
            Console.WriteLine(secondnumtozero(987));
            Console.WriteLine(secondnumtozero(333));
            //task2
            Console.WriteLine(deckcolor(1, 1));
            Console.WriteLine(deckcolor(2, 1));
            Console.WriteLine(deckcolor(2, 7));
        }
    }
}
