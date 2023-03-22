

using System.Collections;

namespace data_structures.array
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] arr;
        private int capacity;
        private int size = 0;

        public DynamicArray()
        {
            this.capacity = 10;
            arr = new T[capacity];
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("Capacity cannot be negative" + capacity);
            this.capacity = capacity;
            arr = new T[capacity];
        }

        public bool isEmty()
        {
            return this.size == 0;
        }

        public int Size()
        {
            return this.size;
        }

        public T Get(int idex)
        {
            return arr[idex];
        }

        public void Set(int idex, T emlement)
        {
            arr[idex] = emlement;
        }

        public void Clear()
        {
            for (var i = 0; i < size; i++)
            {
                arr[i] = default(T);
            }
            size = 0;

        }

        public void Add(T element)
        {
            if (size >= capacity - 1)
            {
                if (capacity == 0) capacity = 1;
                else
                {
                    capacity *= 2;
                }
                T[] newArr = new T[capacity];
                for(int i = 0;i<  arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr= newArr;
            }
            arr[size++] = element;

        }
















        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
