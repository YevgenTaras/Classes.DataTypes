using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DataTypes.DynamicArray
{
    public class DynamicArray 
    {
        private object[] _items;
        private int _count;

        public DynamicArray(int Size)
        {
            _items = new object[Size];
            _count = 0;
        }

        public object this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Clear()
        {
            _count = 0;
            _items = new object[Count];
        }

        public void Add(object item)
        {
            if( Count == _items.Length )
            {
                GrowArray();
            }

            _items[Count] = item;
            _count++;
        }

        public int IndexOf(object item)
        {
            int index = -1;

            for(int i = 0; i < Count; i++)
            {
                if(_items[i] == item)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _items[Count - 1] = null;
                _count--;
            }
        }

        public void Remove(object item)
        {
            RemoveAt(IndexOf(item));
        }

        public void Insert(int index, object item)
        {
            if(index >= 0 && index < Count)
            {
                if(Count == _items.Length)
                {
                    GrowArray();
                }

                _count++;

                for(int i = Count - 1; i > index; i--)
                {
                    _items[i] = _items[i - 1];
                }
                _items[index] = item;
            }
        }

        public bool Contains(object item)
        {
            bool inArray = false;

            for(int i = 0; i < Count; i++)
            {
                if(_items[i] == item)
                {
                    inArray = true;
                    break;
                }
            }

            return inArray;
        }

        private void GrowArray()
        {
            object[] newArray = new object[Count << 1];
            CopyTo(newArray, 0);
            _items = newArray;
        }

        public void CopyTo(Array array, int index)
        {
            int j = index;

            for(int i = 0; i < Count; i++)
            {
                array.SetValue(_items[i], j);
                j++;
            }
        }

        public void PrintContent()
        {
            Console.WriteLine("Array has a capacity: {0}; And now contains: {1} elements.",_items.Length, Count);
            Console.WriteLine("[ " + string.Join(",", _items) + " ]");
        }








    }

}
