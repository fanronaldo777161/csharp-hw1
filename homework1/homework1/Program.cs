namespace homework1
{
    internal class Program
    {
        //обнуляет разряд десятков
        public static int secondnumtozero(int n)
        {
            int h = (n / 100) * 100;
            int u = n % 10;
            return h + u;
        }
        //выводит цвет поля шахматной дочки по номеру
        public static string deckcolor(int x, int y)
        {
            if ((x + y) % 2 == 0)
                return "Black";
            else
                return "White";
        }
        //кол-во корней кв уравнения по кфам
        public static int countofroots(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException("err");
            double d = b * b - 4 * a * c;
            if (d > 0) return 2;
            if (d == 0) return 1;
            return 0;
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
            //task3
            Console.WriteLine(countofroots(1, -5, 6));
            Console.WriteLine(countofroots(2, 0, 0));
            Console.WriteLine(countofroots(10, 0, 1));


        }
    }
}
