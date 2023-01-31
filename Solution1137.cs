/*
Runtime 28 ms, Beats 54.77%
Memory 26.4 MB, Beats 62.67%

Accepted: Jan 31, 2023 19:29
*/

public class Solution {
    public int Tribonacci(int n) {
        if(n<=1) return n;
        if(n==2) return 1;

        int[] table = new int[38];
        table[0]=0;
        table[1]=1;
        table[2]=1;

        for(int i=3;i<=n;i++){
            table[i]=table[i-1]+table[i-2]+table[i-3];
        }

        return table[n];
    }
}
