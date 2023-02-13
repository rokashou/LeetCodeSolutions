/*
Runtime 42 ms, Beats 47.20%
Memory 29.3 MB, Beats 33.3%
Feb 13, 2023 21:47
*/

public class Solution {
    public bool IsHappy(int n) {
        var table = new HashSet<int>();
        while (n > 1)
        {
            table.Add(n);
            int count = 0;
            while(n >= 1)
            {
                int k = n % 10;
                count += k * k;
                n /= 10;
            }
            n = count;
            while (n % 10 == 0) n /= 10;
            if (table.Contains(n)) return false;
        }
        return true;
    }
}
