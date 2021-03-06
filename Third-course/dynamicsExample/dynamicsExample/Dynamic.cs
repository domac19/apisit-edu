using System;

namespace dynamicsExample
{
    public class Dynamic
    {
        public void TryThis()
        {
            dynamic inputName = Console.ReadLine();

            if (String.IsNullOrEmpty(inputName))
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                try
                {
                    inputName++;
                    Console.WriteLine(inputName);
                }
                catch (Exception error)
                {
                    Console.WriteLine("This can not be done becouse name is type string " + error);
                }
                finally
                {
                    Console.WriteLine(inputName);
                }
            }
        }
        public void OrThis()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Try again!");
            dynamic inputName = Console.ReadLine();

            if (String.IsNullOrEmpty(inputName))
            {
                Console.WriteLine("Please enter name!");
            }
            else
            {
                inputName = 0;
                inputName++;

                if (inputName > 0)
                {
                    Console.WriteLine($"Finnaly error is fixed with dynamics and I get index of name: {inputName}");
                }
            }
        }
    }
}
