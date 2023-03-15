using System.Runtime.CompilerServices;

namespace Array
{
    public class Array
    {
        private Object[] _InnerArray;
        public int Count => _InnerArray.Length;
        public Array()
        {
            _InnerArray = new Object[4]; //eğer ctor içinde tanımlanan diziyi oluşturmazsak dışarda new'lenmesini bekleyeceği için null olma durumu için uyarı gösterir 
        }

        private int index = 0;
        public void Add(object o)
        {
            _InnerArray[index] = o;
            index++;
        }



    }
}