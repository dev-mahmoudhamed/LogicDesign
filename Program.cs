namespace LogicDesign
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter hexa number : ");
            string input = Console.ReadLine();
            int result = Converter.ConvertFrom(input, Converter.BaseNumber.Hexadecimal);
            Console.WriteLine("{0} in Hexadecimal = {1} in decimal", input, result);

        }
    }
}