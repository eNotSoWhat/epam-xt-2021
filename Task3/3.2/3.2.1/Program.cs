using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace dynamicArray
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        public int capacity;
        public int size;
        public T[] dArray;

        public DynamicArray()
        {
            capacity = 8;
            dArray = new T[capacity];
        }
        public DynamicArray(int capacity)
        {
            this.capacity = capacity;
            dArray = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> tmp)
        {
            int cnt = tmp.Count();
            dArray = new T[cnt];
            int x = 0;
            foreach (var i in tmp)
                dArray[x++] = i;
        }
        public void Add(T tmp)
        {
            if (size == capacity)
                capacity *= 2;
            dArray[size++] = tmp;
        }
        public void AddRange(IEnumerable<T> tmp)
        {
            int cnt = tmp.Count();
            while (size + cnt > capacity)
                capacity *= 2;
            int x = size;
            foreach (var i in tmp)
                dArray[x++] = i;
            size += cnt;
        }
        public bool Remove(T tmp)
        {
            for (int i = 0; i < size; i++)
                if (dArray[i].Equals(tmp))
                    return true;
            return false;
        }
        public void Insert(T tmp, int i)
        {
            if (size >= capacity)
                capacity *= 2;
            if (i >= 0)
            {
                for (int j = size; j > i; j--)
                {
                    dArray[j] = dArray[j - 1];
                }
                dArray[i] = tmp;
            }
            else
            {
                for (int j = size; j > i; j--)
                {
                    dArray[j] = dArray[j - 1];
                }
                dArray[i + size] = tmp;
            }
            size++;
        }
        public IEnumerator GetEnumerator()
        {
            return dArray.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)dArray).GetEnumerator();
        }
        public T this[int tmp]
        {
            get
            {
                if ((tmp < 0) || (tmp > size + 1))
                    throw new ArgumentOutOfRangeException();
                return dArray[tmp];

            }
            set
            {
                if ((tmp < 0) || (tmp > size + 1))
                    throw new ArgumentOutOfRangeException();
                dArray[tmp] = value;
            }
        }
    }
}
