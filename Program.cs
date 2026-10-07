namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resta = Subtract(2, 1);
            Console.WriteLine($"la resta es: {resta}");

            int division = Divide(2, 1);
            Console.WriteLine($"la división es: {division}");
            

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return (x * y);
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }
        

    }
}