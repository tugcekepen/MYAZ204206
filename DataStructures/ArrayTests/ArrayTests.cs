namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact] //Fact ifadeleri void ile d�ner
        public void Array_Count_Test() //testi �al��t�rmak i�in Array_Count_Test �zerine sa� t�k -> Run Tests => Test Explorer'dan takip edilebilir
        {
            //Dependencies -> Add Project Reference -> Array (classlib)

            //Test yazarken 3A pattern'i uygulan�r.

            //1.Arrange - D�zenleme
            var array = new Array.Array(); // sadece Array() yazd���m�zda c# kendi Array'i ile kar��t�r�p hangisi oldu�unu ��z�mleyemedi�i i�in kitapl�k ad�yla birlikte belirttik.
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            //2. Act - Eylem
            int count = array.Count;
            int capacity = array.Capasity;

            //3. Assertion - �ddia
            Assert.Equal(3, count); // "count(actual-ger�ek) de�i�kenimde 2(beklenen-expected) de�erini bekliyorum" (count ise burada ger�ek de�er)
            Assert.Equal(4, capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            //1.Arrange - D�zenleme
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");

            //2. Act - Eylem
            int count = array.Count;

            //3. Assertion - �ddia
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capasity);
        }
    }
}