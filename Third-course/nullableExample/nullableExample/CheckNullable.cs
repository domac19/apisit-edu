using System;

namespace nullableExample
{
    public class CheckNullable
    {
        public int? Maxnum;
        public void AddSomething(int numberParse)
        {
            Maxnum = numberParse;
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
