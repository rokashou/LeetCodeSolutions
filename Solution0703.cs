/*
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


/*
Runtime: 1500 ms
Memory Usage: 49.7 MB
Uploaded: 04/08/2022 21:53
*/
public class KthLargest {

    private List<int> _stock;
    private int index_k;

    public KthLargest(int k, int[] nums)
    {
        index_k = k;
        _stock = new List<int>();
        foreach(int n in nums){
            Add(n);
        }
    }

    public int Add(int val)
    {
        if(_stock.Count == index_k && _stock[0] >= val) return _stock[0];
        _stock.Add(val);
        _stock.Sort();
        //if(_stock.Count == index_k) return _stock[0];

        if(_stock.Count > index_k){
            _stock.RemoveAt(0);
        }

        return _stock[0];
    }
}

/*
by PriorityQueue(.Net 6 new feature)
Runtime: 219 ms, faster than 57.75% of C# online submissions for Kth Largest Element in a Stream.
Memory Usage: 49.7 MB, less than 55.99% of C# online submissions for Kth Largest Element in a Stream.
Uploaded: 04/08/2022 22:09
*/
public class KthLargest{
    PriorityQueue<int, int> pq;
    int k;

    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int, int>();
        this.k = k;
        
        foreach(int num in nums)
        {
            pq.Enqueue(num, num);
            
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        if (pq.Count > k)
        {
            pq.Dequeue();            
        }
        return pq.Peek();
    }
}

