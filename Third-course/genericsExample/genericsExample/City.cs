namespace genericsExample
{
    public class City <Tkey, Tvalue>
    {
        private object _value;
        private object _key;

        public City(Tvalue value, Tkey key)
        {
            _value = value;
            _key = key;
        }
        public Tkey AddId()
        {
            return (Tkey) _key;
        } 
        public Tvalue AddValue()
        {
            return (Tvalue)_value;
        }
    }
}
