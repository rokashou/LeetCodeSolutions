/*
Feb 13, 2023 22:11
Runtime 46 ms, Beats 17.1%
Memory 28.4 MB, Beats 26.56%
*/


public class Solution {
    public bool IsUgly(int n) {
        if (n<=0) return false;

        while (n % 2 == 0) n /= 2;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;

        return n < 6;
    }
}
