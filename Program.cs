using System;

namespace AI_moduel
{
    class Program
    {
        public static int readInput(string userInput)
        {
            if(userInput.Contains("address"))
            {
                return 0;
            }
            else if(userInput.Contains("hours"))
            {
                return 1;
            }
            else if(userInput.Contains("stock"))
            {
                return 2;
            }
            else
            {
                return 999  ;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("what can I help you with?");
            int input = readInput(Console.ReadLine());
            Console.WriteLine(input);
        }
    }
}
