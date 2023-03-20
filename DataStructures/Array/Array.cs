using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Array
{
    public class Array : IEnumerable
    {
        private Object[] _InnerArray;
        public int Count => index; //Dizide kaç eleman var? //sadece get kullandık
        public int Capasity => _InnerArray.Length; //sadece get kullandık // -  get; set; -> ACCESSOR denir

        public Array()
        {   //block allocation
            _InnerArray = new Object[4]; //eğer ctor içinde tanımlanan diziyi oluşturmazsak dışarda new'lenmesini bekleyeceği için null olma durumu için uyarı gösterir 
        }
        public Array(params Object[] srcArray) //overloading //bu şekilde oluşturulan instancelarda count ve capasity propları değişkenlik gösteriyor index field'ından ötürü.
        {
            _InnerArray = new Object[srcArray.Length];
            for (int i = 0; i < srcArray.Length; i++) {
                _InnerArray[i] = srcArray[i];
            }
        } //teori-week2 

        private int index = 0;
        public void Add(object o)
        {
            if  ( index == _InnerArray.Length )
            {
                DoubleArray(_InnerArray);
            }
            _InnerArray[index] = o;
            index++;
        }  //teori-week1

        private void DoubleArray(object[] array)
        {
            var newArray = new Object[array.Length * 2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray = newArray;
        } //teori-week1

        public Object GetItem(int index)
        {
            if (index < 0 || index >= _InnerArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _InnerArray[index];
        } //LAB-week1

        public void SetItem(int index, Object o)
        {
            if (index < 0 || index >= _InnerArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            _InnerArray[index] = o;
        } //teori-week2

        public Object Find(object o) //listenin içinde verilen elemanı bulan metot
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (o.Equals(_InnerArray[i])) // DİKKAT !!! koşul (o == _InnerArray[i] yazabilirdik ama bu şekilde veri türünü kontrol edememiş oluruz!!!
                {
                    return i;
                }
            }
            return -1; // verdiğimiz elemanı bulamazsa -1 döndürsün
        }  //LAB-week1

        public void Swap( int p1, int p2) //verilen konum bilgileri p1 ile p2 olan elemanların yerlerini değiştiren metot
        {
            var item = _InnerArray[p1];
            _InnerArray[p1] = _InnerArray[p2];
            _InnerArray[p2] = item;
        } //LAB-week1

        public Object RemoveItem(int index)  // istenen yerdeki elemanı siliyor ardındaki elemanları kaldırıyor. Dizi kapasitesi değişmez. 
        {
            if (index < 0 || index >= _InnerArray.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (_InnerArray[index] == null)
            {
                throw new Exception("this index is null.");
            }
            //Other method
            /*
            var item = GetItem(position);
            SetItem(position, null);
            for(int i=position; i< Count-1; i++)
            {
                // _InnerArray[i] = _InnerArray[i + 1];
                Swap(i, i + 1);
            }
            index--;
            if(index == _InnerArray.Length / 2)
            {
                var newArray = new Object[_InnerArray.Length / 2];
                System.Array.Copy(_InnerArray, newArray, newArray.Length);
                _InnerArray = newArray;
            }
            return item;
            */
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
        } //LAB-week1

        public Object Remove() // --->> sondan eleman silen metot. gereken noktada dizi kapasitesi yarıya düşürülüyor. 
        {
            if (index == 0)
            {
                throw new Exception("Out of index!");
            }
            if ((index-1) ==  (_InnerArray.Length / 2)) //diziyi yarıya düşürme işlemi //LAB-week2
            {
                var temp1 = _InnerArray[index - 1];
                _InnerArray[index - 1] = null;
                index--;
                var newArray = new Object[_InnerArray.Length / 2];
                System.Array.Copy(_InnerArray, newArray, _InnerArray.Length/2);
                _InnerArray = newArray;
                return temp1;
            }
            var temp2 = _InnerArray[index-1];
            _InnerArray[index-1] = null;
            index--;
            return temp2;
        }  //LAB-week1 and LAB-week2

        public IEnumerator GetEnumerator()
        {
            return _InnerArray.GetEnumerator();
        } //teori-week2 !!!!!!!!!!

        public Object[] Copy(int i1, int i2) //bir dizinin bir kısmını veya tamamını bir başka diziye kopyalayan metot
        {
            // sayilar = {a, b, c, d, e, f, g};
            // numbers = sayilar.Copy(2, 4);  -->  istenen = {c, d}

            if (i1 < 0 || i1 > _InnerArray.Length || i2 < 0 || i2 > _InnerArray.Length )
            {
                throw new IndexOutOfRangeException();
            }
            else if (i1==i2)
            {
                var zero = new Object[i2-i1]; //eleman eklenebilsin istersek kapasiteyi i2 kadar da yapabiliriz.
                return zero;
            }
            var newArray = new Object[i2-i1];
            int yeniIndex = 0;
            for (int i = i1; i < i2; i++)
            {
                newArray[yeniIndex] = _InnerArray[i];
                yeniIndex++;
            }
            return newArray;
        } //LAB-week2
    }
}