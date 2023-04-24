/*
Apr 24, 2023 20:40
Runtime 97 ms Beats 10.23%
Memory 37.7 MB Beats 90.6%
*/

public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        foreach (var stone in stones)
            pq.Enqueue(stone, stone);

        while(pq.Count > 1){
            int a = pq.Dequeue();
            int b = pq.Dequeue();
            a -= b;
            if(a>0) pq.Enqueue(a,a);
        }
        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}


/*
Runtime: 140 ms, faster than 22.17% of C# online submissions for Last Stone Weight.
Memory Usage: 37.1 MB, less than 33.00% of C# online submissions for Last Stone Weight.
Uploaded: 04/07/2022 23:37
*/


public class Solution {
    public int LastStoneWeight(int[] stones) {
        List<int> list = new List<int>();
        list.AddRange(stones);
        while(list.Count > 1){
            list.Sort();
            int a = list[list.Count - 1];
            int b = list[list.Count - 2];
            list.RemoveRange(list.Count - 2, 2);
            if(a-b>0) list.Add(a - b);
        }
        if(list.Count == 1) return list[0];
        return 0;
    }
}
