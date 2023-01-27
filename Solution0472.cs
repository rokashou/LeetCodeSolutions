/*
Runtime 333 ms, Beats 82.35%
Memory 51.2 MB, Beats 88.24%
Accepted: Jan 27, 2023 15:37
Approach: Dynamic Programming
*/

public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        var dict = new HashSet<string>();
        foreach (var w in words) dict.Add(w);

        var result = new List<string>();
        foreach(var w in words)
        {
            int length = w.Length;
            bool[] dp = new bool[length + 1];
            dp[0] = true;
            for(int i = 1; i <= length; i++)
            {
                for(int j=(i==length?1:0); !dp[i] && j < i; ++j)
                {
                    dp[i] = dp[j] && dict.Contains(w.Substring(j, i-j));
                }
            }
            if (dp[length])
            {
                result.Add(w);
            }
        }
        return result;

    }
}
