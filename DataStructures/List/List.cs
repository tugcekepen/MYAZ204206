using System.Collections;

namespace List
{
    public class List<T> : IEnumerable<T>
    {
        private T[] _list;

        private int index = 0;

        public int Capacity => _list.Length;

        public int Count => index;

        public List()
        {
            _list = new T[4];
        }
        public void Add(T item)
        {
            if (index == _list.Length)
            {
                DoubleList(_list);
            }
            // throw new NotImplementedException();
            _list[index++] = item;
        }

        public void DoubleList(T[] list)
        {
            var newList = new T[list.Length * 2];
            System.Array.Copy(list, newList, _list.Length);
            _list = newList;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            // throw new NotImplementedException();

            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            // throw new NotImplementedException();
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(item))
                {
                    _list[i] = default(T); //default(T), solundaki yapının boş durumdaki hali ne ise onu veriyor
                    for (int j = i; j < _list.Length - 1; j++)
                    {
                        T temp = _list[j];
                        _list[j] = _list[j + 1];
                        _list[j + 1] = temp;
                    }

                    index--;
                    if (index == _list.Length / 2)
                        HalfList(_list);
                    return true;
                }
            }
            return false;
        }

        public void HalfList(T[] list)
        {
            var newList = new T[list.Length / 2];
            System.Array.Copy(list, newList, newList.Length);
            _list = newList;
        }

        public void RemoveAt(int index)
        {
            // throw new NotImplementedException();

            _list[index] = default(T);

            for (int i = index; i < _list.Length - 1; i++)
            {
                T temp = _list[i];
                _list[i] = _list[i + 1];
                _list[i + 1] = temp;
            }
        }

        public T[] InterSect(IEnumerable<T> collection)
        {
            // throw new NotImplementedException();
            T[] newList = new T[_list.Length];
            int i = 0;
            foreach (T item in _list.Intersect(collection).ToList())
            {
                if (item != null)
                {
                    newList[i] = item;
                    i++;
                }
            }

            return newList;
        }

        public T[] Union(IEnumerable<T> collection)
        {
            // throw new NotImplementedException();
            T[] newList = new T[_list.Length + collection.Count()];
            int i = 0;
            foreach (T item in _list.Union(collection).ToList())
            {
                if (item != null)
                {
                    newList[i] = item;
                    i++;
                }
            }

            return newList;
        }

        public T[] Except(IEnumerable<T> collection)
        {
            // throw new NotImplementedException();
            T[] newList = new T[_list.Length];
            int i = 0;
            foreach (T item in _list.Except(collection).ToList())
            {
                if (item != null)
                {
                    newList[i] = item;
                    i++;
                }
            }

            return newList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.Take(index).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}