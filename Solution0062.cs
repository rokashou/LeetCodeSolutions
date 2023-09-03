/*
Sep 03, 2023 16:21
Runtime 27 ms Beats 31.1%
Memory 27 MB Beats 29.21%
*/
public class Solution {
    public int UniquePaths(int m, int n) {
        int N = m + n - 2;
        int k = m - 1;
        
        double result = 1;
        for(int i = 1; i <= k; i++)
        {
            result = result * (N - k + i)/i;
        }
        return (int)result;
    }
}



/*

https://leetcode.com/problems/unique-paths/

Uploaded: 11/18/2021 00:06
Runtime: 36 ms, faster than 59.72% of C# online submissions for Unique Paths.
Memory Usage: 26.8 MB, less than 38.03% of C# online submissions for Unique Paths.

*/

public class Solution {
    private int Combination(int n, int r){
        if(r < n-r) 
            r = n-r;
        long ans = 1;

        for(int i=r+1;i<=n;i++) ans *= i;
        for(int i = 2; i <= n-r; i++) ans /= i;
        return (int)ans;
    }

    public int UniquePaths(int m, int n) {
        // return C(m-1,n-1)
        return Combination((m+n-2),m-1);
    }
}
