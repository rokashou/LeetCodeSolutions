/*
Runtime 244 ms, Beats 47.6%
Memory 52.1 MB, Beats 71.32%
Accept: Feb 07, 2023 22:56
*/

public class Solution {
    public int TotalFruit(int[] fruits) {
        int l = 0, r = 1;
        var stock = new Dictionary<int,int>();
        stock.Add(fruits[0],1);
        int maxcount = 1;

        while (r < fruits.Length)
        {
            if (!stock.TryAdd(fruits[r], 1)) stock[fruits[r]]++;

            if (stock.Count <= 2)
                maxcount = Math.Max(maxcount, r - l + 1);
            else
            {
                stock[fruits[l]]--;

                if (stock[fruits[l]] == 0) stock.Remove(fruits[l]);

                l++;
            }

            r++;
        }

        return maxcount;
    }
}

