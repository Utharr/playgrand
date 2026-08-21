namespace GenericType
{
    public class GenericClass<T>
    { 
        private T _value;

        public GenericClass(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }

        public void SetValue(T value)
        {
            _value = value;
        }
    }
}