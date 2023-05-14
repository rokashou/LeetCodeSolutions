/*
May 14, 2023 14:39
Runtime 260 ms Beats 66.67%
Memory 45.8 MB Beats 33.33%
*/

public class Solution
{
    public int MaxScore(int[] nums)
    {
        int n = nums.Length;

        var map = new Dictionary<int, int>();
        var index = new Dictionary<int, int>();
        
        var list = new List<int>();
        for (int mask = 3; mask < 1 << n; mask++) {
            for (int i = 0; i < n; i++) 
                if (((mask >> i) & 1) > 0) 
                    list.Add(nums[i]);

            if (list.Count == 2) {
                map.Add(mask, Gcd(list[0], list[1]));
                index.Add(mask, index.Count);
            }

            list.Clear();
        }

        int m = n / 2;
        var current = new Dictionary<int, int>();

        foreach (int mask in map.Keys) 
            current.Add(mask, map[mask]);

        int key;
        for (int i = 2; i <= m; i++)
        {
            var next = new Dictionary<int, int>();

            foreach (int mask1 in map.Keys) {
                foreach (int mask2 in current.Keys) {
                    if ((mask1 & mask2) == 0) {
                        key = mask1 | mask2;
                        if (!next.ContainsKey(key)) 
                            next.Add(key, 0);

                        next[key] = Math.Max(next[key], current[mask2] + i * map[mask1]);
                    }
                } 
            }

            current = next;
        }

        int max = 0;

        foreach (int mask in current.Keys)
            max = Math.Max(max, current[mask]);

        return max;
    }

    private int Gcd(int a, int b) {
        if (b == 0) return a;
        
        return Gcd(b, a % b);
    }
}
