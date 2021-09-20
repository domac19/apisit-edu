﻿using System;

namespace stackDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There is output of Stack!");
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
