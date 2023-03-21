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

        [Fact]
        public void Unique_Char_Set_Tests()
        {
            //Arrange
            var l1 = "selamsamü".ToList();

            //Act
            var result = new List<char>(); 
            foreach (var item in l1)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            //Assert
            Assert.Equal(6, result.Count);
            Assert.Collection<char>(result,
                item => Assert.Equal('s', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('a', item),
                item => Assert.Equal('m', item),
                item => Assert.Equal('ü', item));

        }

        [Fact]
        public void HashSet_Test()
        {
            //Arrange and Act
            var list = new HashSet<char>("tugcekepen");

            //Assert
            Assert.Equal(8, list.Count);
            Assert.Collection<char>(list,
                item => Assert.Equal('t', item),
                item => Assert.Equal('u', item),
                item => Assert.Equal('g', item),
                item => Assert.Equal('c', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('k', item),
                item => Assert.Equal('p', item),
                item => Assert.Equal('n', item));
        }
    }
}