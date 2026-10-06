namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 202401391
            int suma = Add(id[0], id[-1])
            Console.WriteLine($"la suma es: {suma}");

        }

        public static int Add(int x, int y) 
        {
            return x + y 
        }
    }
}