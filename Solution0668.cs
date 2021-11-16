// By Binary Search : Official Solution Approach 3
/*
Uploaded: 11/17/2021 00:16
Runtime: 40 ms, faster than 94.12% of C# online submissions for Kth Smallest Number in Multiplication Table.
Memory Usage: 27 MB, less than 5.88% of C# online submissions for Kth Smallest Number in Multiplication Table.
*/

public class Solution {
    public bool enough(int x, int m, int n, int k){
        int count = 0;
        for(int i=1;i<=m;i++){
            count += Math.Min(x/i,n);
        }
        return count >= k;
    }

    public int FindKthNumber(int m, int n, int k){
        // Official Solution: Binary Search
        int lo = 1, hi = m*n;
        while(lo < hi){
            int mi = lo +(hi-lo) / 2;
            if(!enough(mi,m,n,k)) lo = mi + 1;
            else hi = mi;
        }
        return lo;
    }
}
