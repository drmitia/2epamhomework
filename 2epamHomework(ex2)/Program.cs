namespace _2epamHomework_ex2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());           
            int position1 = number / 100;
            int position2 = (number / 10) % 10;
            int position3 = number % 10;
                      
            int max = Math.Max(position1, Math.Max(position2, position3));
           
            int min = Math.Min(position1, Math.Min(position2, position3));

            int middle = position1 + position2 + position3 - max - min;

            int result = max * 100 + middle * 10 + min;

            Console.WriteLine($"Наше максимальне число: {result}");
        }
    }
}