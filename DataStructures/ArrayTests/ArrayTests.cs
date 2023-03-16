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
        } //teorik-week1

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
        } //teorik-week1

        [Fact]
        public void Array_Find_Test() { 
            //Arrange
            var array = new Array.Array();
            array.Add("Ahmet");   // index : 0
            array.Add("Mehmet");  // index : 1

            //Act
            var item1 = array.Find("Mehmet");
            var item2 = array.Find("Ali");

            //Assert
            Assert.Equal(1, item1);  //liste i�inde bulabilirse  index : 1 oldu�undan 1 d�nmeli.
            Assert.Equal(-1, item2); //listede yok, o halde fonk.'a g�re -1 d�nmeli


        } //LAB-week1

        [Fact]
        public void Array_Swap_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            array.Swap(0, 1);
            var item1 = array.GetItem(0);
            var item2 = array.GetItem(1);

            Assert.Equal("Mehmet", item1);
            Assert.Equal("Ahmet", item2);
        } //LAB-week1

        [Fact]
        public void Array_RemoveItem_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");

            //Act
            var item = array.RemoveItem(1);
            var item2 = array.RemoveItem(2);
            var item3 = array.RemoveItem(2);

            //Assert
            Assert.Equal("Mehmet", item);
            Assert.Equal("Canan", item2);
            Assert.Equal("Filiz", item3);
        } //LAB-week1
        
        [Fact]
        public void Array_Remove_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            //Act
            var item1 = array.Remove();
            var item2 = array.Remove();

            //Assert
            Assert.Equal("Mehmet", item1);
            Assert.Equal("Ahmet", item2);
        } //LAB-week1

        [Fact]
        public void Array_Remove_Exception_Test() {
            try
            {
                //Arrange
                var array = new Array.Array();
                array.Add(0);

                //Act
                var item = array.Remove();

                //Assert
                Assert.True(false);
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        } //LAB-week1

        [Fact]
        public void Array_GetEnumerator_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            //Act
            var result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);
            }

            //Assert
            Assert.Equal("AhmetMehmetCan", result);
        }

    }      
}