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
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine(secondnumtozero(123));
            Console.WriteLine(secondnumtozero(987));
            
        }
    }
}
