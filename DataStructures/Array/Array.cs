using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Array
{
    public class Array
    {
        private Object[] _InnerArray;
        public int Count => index; //Dizide kaç eleman var?
        public int Capasity => _InnerArray.Length;

        public Array()
        {   //block allocation
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

        public Object GetItem(int index) //LAB-week1
        {
            return _InnerArray[index];
        }

        public Object Find(object o)
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (o.Equals(_InnerArray[i])) // DİKKAT !!! koşul (o == _InnerArray[i] yazabilirdik ama bu şekilde veri türünü kontrol edememiş oluruz!!!
                {
                    return i;
                }
            }
            return -1; // verdiğimiz elemanı bulamazsa -1 döndürsün
        } //listenin içinde verilen elemanı bulan metot //LAB-week1

        public void Swap( int p1, int p2) //verilen konum bilgileri p1 ile p2 olan elemanların yerlerini değiştiren metot //LAB-week1
        {
            var item = _InnerArray[p1];
            _InnerArray[p1] = _InnerArray[p2];
            _InnerArray[p2] = item;
        }

        public Object RemoveItem(int index)
        {
            var newArray = new Object[_InnerArray.Length]; // innerAray -> 0 1 2 3     newArray -> 0 1 3     index=2  lenght=4
            var removed = _InnerArray[index];
            for (int i = 0; i < _InnerArray.Length-1; i++)
            {
                if (i >= index)
                {
                    newArray[i] = _InnerArray[i+1];
                }
                else
                {
                    newArray[i] = _InnerArray[i];
                }

            }
            _InnerArray = newArray;
            return removed;
        }

        public Object Remove()
        {
            if (index == 0)
            {
                throw new Exception("Out of index!");
            }
            var temp = _InnerArray[index-1];
            _InnerArray[index-1] = null;
            index--;
            return temp;
        }
        
        
    }
}