namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact] //Fact ifadeleri void ile döner
        public void Array_Count_Test() //testi çalýþtýrmak için Array_Count_Test üzerine sað týk -> Run Tests => Test Explorer'dan takip edilebilir
        {
            //Dependencies -> Add Project Reference -> Array (classlib)

            //Test yazarken 3A pattern'i uygulanýr.

            //1.Arrange - Düzenleme
            var array = new Array.Array(); // sadece Array() yazdýðýmýzda c# kendi Array'i ile karýþtýrýp hangisi olduðunu çözümleyemediði için kitaplýk adýyla birlikte belirttik.
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            //2. Act - Eylem
            int count = array.Count;
            int capacity = array.Capasity;

            //3. Assertion - Ýddia
            Assert.Equal(3, count); // "count(actual-gerçek) deðiþkenimde 2(beklenen-expected) deðerini bekliyorum" (count ise burada gerçek deðer)
            Assert.Equal(4, capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            //1.Arrange - Düzenleme
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");

            //2. Act - Eylem
            int count = array.Count;

            //3. Assertion - Ýddia
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capasity);
        }
    }
}