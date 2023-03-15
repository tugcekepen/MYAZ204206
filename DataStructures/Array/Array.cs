using System.Runtime.CompilerServices;

namespace Array
{
    public class Array
    {
        private Object[] _InnerArray;
        public int Count => index; //Dizide kaç eleman var?
        public int Capasity => _InnerArray.Length;

        public Array()
        {
            _InnerArray = new Object[4]; //eğer ctor içinde tanımlanan diziyi oluşturmazsak dışarda new'lenmesini bekleyeceği için null olma durumu için uyarı gösterir 
        }

        private int index = 0;
        public void Add(object o)
        {
            if  ( index == _InnerArray.Length )
            {
                DoubleArray(_InnerArray);
            }
            _InnerArray[index] = o;
            index++;
        }

        private void DoubleArray(object[] array)
        {
            var newArray = new Object[array.Length * 2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray = newArray;
        }
    }
}