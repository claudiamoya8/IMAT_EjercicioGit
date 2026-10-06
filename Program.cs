namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicacion = Multiply(2, 1);
            Console.WriteLine($"la multiplicación es: {multiplicacion}");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return (x * y);
        }

    }
}