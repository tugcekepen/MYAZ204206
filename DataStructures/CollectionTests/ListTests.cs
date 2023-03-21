namespace CollectionTests
{
    public class ListTests
    {
        [Fact]
        public void Collection_Count_Test()
        {
            //Arrange
            var l1 = new List<int>() { 1, 3, 4 };

            //Act
            var uzunluk = l1.Count;

            //Assert
            Assert.Equal(3, uzunluk);
        }

        [Fact]
        public void Collection_Union_Test()
        {
            //Arrange
            var l1 = new List<char>() { 'a', 'b', 'c', 'e', 'f'};
            var l2 = new List<char>() { 'b', 'w', 'z', 'b', 'e' };

            //Act
            var uzunluk = l1.Union(l2).ToList().Count;

            //Assert
            Assert.Equal(7, uzunluk);
        }

        [Fact]
        public void Collection_Intersection_Test()
        {
            //Arrange
            var l1 = new List<int>() { 1, 3, 4, 5, 6 };
            var l2 = new List<int>() { 1, 3, 7 };

            //Act
            var list = l1.Intersect(l2).ToList();

            //Assert
            Assert.Equal(2, list.Count);
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(3, item));
        }
    }
}