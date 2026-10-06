namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = Add(2, 1);
            Console.WriteLine($"la suma es: {suma}");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}