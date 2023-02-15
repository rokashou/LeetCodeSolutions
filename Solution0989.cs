/*
Runtime 224 ms, Beats 32.94%
Memory 53.2 MB, Beats 71.76%
Feb 15, 2023 22:04
*/

public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        List<int> ans = new();
        int c = 0;
        int idx = num.Length-1;

        while(c > 0 || k > 0 || idx >= 0)
        {
            int d = c;
            if (k > 0)
            {
                d += k % 10;
                k /= 10;
            }
            if(idx >= 0)
            {
                d += num[idx--];
            }

            c = d / 10;
            d %= 10;

            ans.Insert(0, d);
        }

        return ans;

    }
}
