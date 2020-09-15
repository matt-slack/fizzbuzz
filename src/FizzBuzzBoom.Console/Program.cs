
namespace FizzBuzzBoom.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new IntegerProcessor();
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine(processor.ConvertIntegerToWord(i));
            }
        }
    }
}
