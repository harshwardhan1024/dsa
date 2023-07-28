namespace Sorting;

public class InsertionSort
{
    public List<int> Sort(IEnumerable<int> unsorted)
    {
        var _unsorted = unsorted.ToList();
        if (_unsorted.Count == 0)
        {
            throw new ArgumentException("unsorted should have atleast 1 element.");
        }

        var sorted = new List<int>(_unsorted.Count());
        sorted.Add(_unsorted[0]);

        for (var i = 1; i < _unsorted.Count; i++)
        {
            InsertInSortedList(sorted, _unsorted[i]);
        }

        return sorted;
    }

    private void InsertInSortedList(List<int> sorted, int el)
    {
        for (var j = sorted.Count() - 1; j >= 0; j--)
        {
            if (sorted[j] <= el)
            {
                sorted.Insert(j + 1, el);
                break;
            }
            else if (j == 0)
            {
                sorted.Insert(0, el);
            }
        }
    }
}