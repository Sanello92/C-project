using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestEnumerable
{

    public class MyEnumerator : IEnumerator<int>
    {

        private int[] _array;

        public MyEnumerator(int[] array)
        {
            _array = array;
        }

        private int _i = -1;

        public int Current
        {
            get
            {
                try
                {
                    return _array[_i];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("ouch");
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            _array = null;
        }

        public bool MoveNext()
        {
            _i++;
            return _i < _array.Length;
        }

        public void Reset()
        {
            _i = -1;
        }
    }

    public class MyCollection : IEnumerable<int>

    {
        private int[] list;

        public MyCollection(int[] elements)
        {
            list = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerator(list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}