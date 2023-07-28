using Sorting;

namespace Tests;

public class InsertionSortTests
{
    [Theory]
    [InlineData(new int[] { 3 })]
    [InlineData(new int[] { 3, 2 })]
    [InlineData(new int[] { 23, 4, 67, 34, 7, 1, 85, 34, 674, 343, 5, 22, 884 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void Sorts_correctly(IEnumerable<int> unsorted)
    {
        var insertionSort = new InsertionSort();
        var sorted = insertionSort.Sort(unsorted);
        Assert.True(unsorted.OrderBy(x => x).SequenceEqual(sorted));
    }

    [Fact]
    public void Should_have_atleast_one_element()
    {
        Assert.Throws<ArgumentException>(() => new InsertionSort().Sort(Enumerable.Empty<int>()));
    }
}