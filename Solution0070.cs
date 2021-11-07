/*
Uploaded: 10/06/2021 00:18
Runtime: 48 ms, 34.53%
Memory Usage: 15.3 MB, 61.42%
*/

public class Solution {
    public int ClimbStairs(int n) {
        if(n==1) return 1;
        if(n==2) return 2;

        int a=1;
        int b=2;
        int k=3;
        for(short i=3;i<=n;i++)
        {
            k=a+b;
            a=b; 
            b=k;
        }

        return k;
    }
}
