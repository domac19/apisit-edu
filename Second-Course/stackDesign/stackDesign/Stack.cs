using System;
using System.Collections.Generic;

namespace stackDesign
{
    public class Stack
    {
        private List<object> _list { get; } = new List<object>();
        public void Push(object obj)
        {
            if (obj != null)
            {
                _list.Add(obj);
            }
            else
            {
                throw new Exception("You store null in Stack!");
            }
        }
        public object Pop()
        {
            int index = _list.Count - 1;
            object obj = null;

            if (_list.Count > 0)
            {
                obj = _list[index];
                _list.RemoveAt(index);
            }
            else
            {
                throw new Exception("Can not call Pop() method on empty stack!");
            }
            return obj;
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
