using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _arrKeys;
        TValue[] _arrValues;
        TKey[] _tmpArrKeys;
        TValue[] _tmpArrValues;
        public MyDictionary()
        {
            // Instantiate the arrays
            _arrValues = new TValue[0];
            _arrKeys = new TKey[0];
        }
        
        public void Add(TKey key, TValue value)
        {
            _tmpArrKeys = _arrKeys;
            _tmpArrValues = _arrValues;

            _arrKeys = new TKey[_arrKeys.Length + 1];
            _arrValues = new TValue[_arrValues.Length + 1];

            for (int i = 0; i < _tmpArrKeys.Length; i++)
            {
                _arrKeys[i] = _tmpArrKeys[i];
            }

            for (int i = 0; i < _tmpArrValues.Length; i++)
            {
                _arrValues[i] = _tmpArrValues[i];
            }

            _arrKeys[_arrKeys.Length - 1] = key;
            _arrValues[_arrValues.Length - 1] = value;  
        }
    }
}
