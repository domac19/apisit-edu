using System;

namespace lambdaExample
{
    public class Message : Hello
    {
        public override void AddMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Action<string> thank = thankMessage =>
            {
                string saluting = $"Hello {thankMessage}";
                Console.WriteLine(saluting);
            };
            thank("thanks for watching!");
            Console.ResetColor();
        }
    }
}
