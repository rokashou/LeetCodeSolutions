/*
Apr 06, 2023 23:28
Runtime 22 ms Beats 81.61%
Memory 26.6 MB, Beats 22.99%
*/

public class Solution {
    public int NumberOfMatches(int n) {
        int count = 0;
        while(n > 1)
        {
            if (n % 2 == 0)
            {
                count += n / 2;
                n /= 2;
            }
            else
            {
                count += (n - 1) / 2;
                n = (n - 1) / 2 + 1;
            }
        }
        return count;
    }
}
