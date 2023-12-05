namespace Test14C
{
    public class Szamol
    {
        public static double Kivonas(dynamic a, dynamic b)
        {
            return a - b;
        }

        public static double Szorzas(dynamic a, dynamic b)
        {
            return a * b;
        }

        public static double Gyok(dynamic a)
        {
            return Math.Sqrt(a);
        }

        public static bool SzerkezhetoE(int a, int b, int c)
        {
            return a + b > c && b + c > a && c + a > b;
        }
    }
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Itt nincs semmi, futtasd a teszteket!!!");
        }
    }
}