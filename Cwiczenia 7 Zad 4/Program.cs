namespace Cwiczenia_7_Zad_4
{
    static class Funkcje
    {
        public static long Potega(int a, int b)
        {
            if (b == 1)
                return a;
            else
                return Potega(a, b - 1) * a;
        }
        public static long Silnia(int n)
        {
            if (n == 1)
                return n;
            else
                return Silnia(n-1) * n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Funkcje.Potega(2, 10));
            Console.WriteLine(Funkcje.Silnia(7));
        }
    }
}