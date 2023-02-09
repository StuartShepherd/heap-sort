namespace HeapSort.Tests;

[TestClass]
public class HeapSortTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        [DataRow(new int[] { 73, 57, 49, 99, 133, 20, 1 }, new int[] { 1, 20, 49, 57, 73, 99, 133 })]
        public void Sorts_Array_ReturnsSortedArray(int[] x, int[] expected)
        {
            var heapSort = new HeapSort();
            var actual = heapSort.Sort(x);

            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
