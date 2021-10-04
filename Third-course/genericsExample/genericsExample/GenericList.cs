using System;

namespace genericsExample
{
    public class GenericList<T> 
    {
        private object _value;

        public GenericList(T value) 
        {
            _value = value;
        }
        public T Get()
        {
            return (T) _value;
        }
    }
}
