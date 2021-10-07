using System;

namespace nullableExample
{
    public class CheckNullable
    {
        private int? _number;
        public void AddSomething(int numberParse)
        {
            _number = numberParse;
            var inputData = Console.ReadLine();
            Int32.TryParse(inputData, out numberParse);

            if (numberParse > 0)
            {
                Console.WriteLine(numberParse);
            }
            else
            {
                Console.WriteLine("Nullable check");
            }
        }
    }
}
