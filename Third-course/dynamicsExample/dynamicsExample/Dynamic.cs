using System;

namespace dynamicsExample
{
    public class Dynamic
    {
        public void TryThis()
        {
            dynamic inputName = Console.ReadLine();

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
        public void OrThis()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Try again!");
            dynamic inputName = Console.ReadLine();

            inputName = 1;
            inputName++;

            if (inputName > 1)
            {
                Console.WriteLine($"Finnaly error is fixed and I get number: {inputName}");
            }
        }
    }
}
