namespace genericsExample
{
    public class City <Tkey, Tvalue>
    {
        private object _value;
        private object _key;

        public City()
        {
        }
        public Tkey AddId(Tkey key)
        {
            _key = key;
            return (Tkey) key;
            
        } 
        public Tvalue AddValue(Tvalue value)
        {
            _value = value;
            return (Tvalue) value;
        }
    }
}
