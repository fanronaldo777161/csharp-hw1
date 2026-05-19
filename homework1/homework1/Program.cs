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
        //минимум из вещ числе 
        public static double minofdouble(double a, double b)
        {
            return a < b ? a : b;
        }
        //произв всех чет чисел от а до б
        public static double powofoddnum(int a, int b)
        {
            int s = Math.Min(a, b);
            int e = Math.Max(a, b);

            double p = 1;
            bool f = false;

            for (int i = s; i <= e; i++)
            {
                if (i % 2 == 0)
                {
                    p *= i;
                    f = true;
                }
            }
            return  p ;
        }
        //кол-во чисел в массиве до 0 меньше к
        public static (int l, int d) nummenk(int k, int[] v)
        {
            int l = 0;
            int d = 0;

            foreach (var i in v)
            {
                if (i == 0) break;
                if (i < k) l+=1;
                if (i % k == 0) d+=1;
            }
            return (l, d);
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
            //task4
            Console.WriteLine(minofdouble(3.5, 1.2));
            Console.WriteLine(minofdouble(3.5, 7));
            Console.WriteLine(minofdouble(-3.5, 1.2));
            //task5
            Console.WriteLine(powofoddnum(1, 5));
            Console.WriteLine(powofoddnum(2, 7));
            //task6
            var a = new int[] { 1, 2, 3, 4, 5, 6, 0, 7, 7, 7, 7 };
            Console.WriteLine(nummenk(10,a));
            Console.WriteLine(nummenk(3, a));
        }
    }
}
