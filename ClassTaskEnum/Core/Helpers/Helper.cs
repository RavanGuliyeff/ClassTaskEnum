using Core.Helpers.Enums;

namespace Core.Helpers
{
    public static class Helper
    {
        public static string GetStringInput(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(input));
            Console.WriteLine();
            return input;
        }


        public static int GetIntInput(string message)
        {
            int result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!int.TryParse(input, out result));
            Console.WriteLine();
            return result;
        }


        public static double GetDoubleInput(string message)
        {
            double result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    return 0.0;

            } while (!double.TryParse(input, out result));
            Console.WriteLine();
            return result;
        }


        public static Types GetTypesInput(string message)
        {

            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (input != "1" && input != "2" && input != "3" && input != "4");
            Console.WriteLine();
            return (Types)int.Parse(input);
        }
    }
}
