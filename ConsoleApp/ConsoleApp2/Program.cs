namespace ConsoleApp2
{
    public class Program
    {

        public static int Fib(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            else
            {
                return Fib(x - 1) + Fib(x - 2);
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            Console.Write(Fib(n));
        }
    }
}