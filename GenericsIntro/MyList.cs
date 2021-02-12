namespace GenericsIntro
{
    // Imitation of the List class
    // Generic class
    class MyList<T>
    {
        // This value below has no access specifier but 
        // C# uses private access specifier for the class members
        T[] _arr;
        T[] _tmpArr;

        public MyList()
        {
            _arr = new T[0];
        }
        
        public void Add(T item)
        {
            _tmpArr = _arr;
            _arr = new T[_arr.Length + 1];
            for (int i = 0; i < _tmpArr.Length; i++)
            {
                _arr[i] = _tmpArr[i];
            }

            _arr[_arr.Length - 1] = item;
        }

        public int Count
        {
            get { return _arr.Length; }
        }

    }
}
