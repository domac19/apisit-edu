using System;
using System.Collections.Generic;

namespace stackDesign
{
    public class Stack
    {
        public List<object> List { get; } = new List<object>();
        public void Push(object obj)
        {
            if (obj != null)
            {
                List.Add(obj);
            }
            else
            {
                throw new Exception("You store null in Stack!");
            }
        }
        public object Pop()
        {
            int index = List.Count - 1;
            object obj = null;

            if (List.Count > 0)
            {
                obj = List[index];
                List.RemoveAt(index);
            }
            else
            {
                throw new Exception("Can not call Pop() method on empty stack!");
            }
            return obj;
        }
        public void Clear()
        {
            List.Clear();
        }
    }
}
