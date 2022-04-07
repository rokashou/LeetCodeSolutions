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
