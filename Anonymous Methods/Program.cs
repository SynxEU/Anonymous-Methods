namespace Anonymous_Methods
{
    delegate int MyDelegate(int p, int q);

    class Program
    {
        static void Main()
        {
            MyDelegate arithMethod = (c, d) => c > d ? c : d;

            Console.WriteLine($"Det største af tallene er: {arithMethod(9, 7)}");
        }

        //static int Max(int c, int d)
        //{
        //    if (c > d)
        //        return c;
        //    else
        //        return d;
        //}
    }
}
