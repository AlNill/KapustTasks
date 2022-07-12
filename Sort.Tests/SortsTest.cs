namespace Sort.Tests
{
    public class Tests
    {
        public List<int> GenerateRandomList(int size, int maxValue)
        {
            var list = new List<int>();
            var rand = new Random();
            for (int i = 0; i < size; i++)
                list.Add(rand.Next(0, maxValue));
            return list;
        }

        [Test]
        public void PregeneratedListTest()
        {
            int maxValue = 20;
            var list = new List<int>()
            {
                20, 17, 10, 9, 5, 2, 3, 5, 0, 5, 2, 6, 4, 8, 0, 17
            };
            var expectedList = new List<int>()
            {
                0, 0, 2, 2, 3, 4, 5, 5, 5, 6, 8, 9, 10, 17, 17, 20
            };

            CountingSort cs = new CountingSort();
            int counter = 0;
            foreach(int i in cs.Sort(list, 20, maxValue))
            {
                Assert.That(i, Is.EqualTo(expectedList[counter++]));
            }
        }

        [Test]
        public void RandomListTest()
        {
            int size = 100000;
            int maxValue = 2000;
            var list = GenerateRandomList(size, maxValue);
            var expectedList = new List<int>();

            for (int i = 0; i < list.Count; ++i)
                expectedList.Add(list[i]);

            expectedList.Sort();
            CountingSort cs = new CountingSort();
            int counter = 0;
            foreach (int i in cs.Sort(list, 20, maxValue))
            {
                Assert.That(i, Is.EqualTo(expectedList[counter++]));
            }
        }
    }
}