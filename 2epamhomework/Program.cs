namespace _2epamhomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скiльки коштує один зошит?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Скiльки коштує одна ручка?");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Скiльки грошей має Петрик?");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Скiльки зошитiв хоче Петрик?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Скiльки Ручок хоче Петрик?");
            int m = Convert.ToInt32(Console.ReadLine());
            if (x*n + y*m <= s) 
            {
            int b = s - x*n - y*m;
            Console.WriteLine("У Петрика залишится " + b + " грн");
            }
            else 
            {
                Console.WriteLine("Петрик не може здiйнити таку покупку");
            }
        }
    }
}