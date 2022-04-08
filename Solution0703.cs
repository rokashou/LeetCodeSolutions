/*
1st try: Sort.
Runtime: 2786 ms, faster than 5.28% of C# online submissions for Kth Largest Element in a Stream.
Memory Usage: 50.7 MB, less than 31.69% of C# online submissions for Kth Largest Element in a Stream.
Uploaded: 04/08/2022 21:17
*/

public class KthLargest {

    private List<int> _stock;
    private int index_k;

    public KthLargest(int k, int[] nums)
    {
        index_k = k;
        _stock = new List<int>();
        _stock.AddRange(nums);
    }

    public int Add(int val)
    {
        _stock.Add(val);
        _stock.Sort();

        return _stock[(_stock.Count) - index_k];
    }
}

