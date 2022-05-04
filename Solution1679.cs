/*
Runtime: 219 ms, faster than 87.10% of C# online submissions for Max Number of K-Sum Pairs.
Memory Usage: 50.2 MB, less than 19.35% of C# online submissions for Max Number of K-Sum Pairs.
Uploaded: 05/04/2022 21:20

By HashMap
*/
public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Dictionary<int, List<int>> table = new Dictionary<int, List<int>>();
        int sum = 0;
        foreach(var n in nums)
        {
            if (n >= k) continue;
            if (table.ContainsKey(k - n) && table[k-n].Count > 0)
            {
                sum++;
                table[k - n].RemoveAt(0);
            }
            else
            {
                if (!table.ContainsKey(n))
                    table.Add(n, new List<int>());
                table[n].Add(n);
            }
        }
        return sum;
    }
}





/*
Runtime: 473 ms, faster than 6.45% of C# online submissions for Max Number of K-Sum Pairs.
Memory Usage: 52.8 MB, less than 6.45% of C# online submissions for Max Number of K-Sum Pairs.
Uploaded: 05/04/2022 21:07

by Official Hint
*/



public class Solution {
    public int MaxOperations(int[] nums, int k) {
        SortedDictionary<int, int> table = new SortedDictionary<int, int>();
        foreach(var n in nums)
        {
            if (!table.ContainsKey(n))
            {
                table.Add(n, 0);
            }
            table[n]++;
        }

        int sum = 0;
        foreach(var key in table.Keys)
        {
            if (key > k / 2) break;
            if (key == k / 2.0) { sum += (table[key] / 2); continue; }
            if (table.ContainsKey(k - key)) { 
                sum += Math.Min(table[key], table[k - key]);
            }
        }
        return sum;
    }
}

