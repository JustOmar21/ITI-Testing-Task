using IdealWeightCalc;

namespace Day1
{
    internal class Program
    {
        //test value
        //h=176 , w   => 63
        //h=170 , m   => 65
        //any char =>   0
        static void Main(string[] args)
        {
            WeightCalc calc = new WeightCalc() { Height = 170, Gender = 'M' };

            double weight = calc.GetIdealWeight();



            if(weight == 65)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Successful");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
            }
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
