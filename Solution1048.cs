/*
Runtime: 127 ms, faster than 87.37% of C# online submissions for Longest String Chain.
Memory Usage: 40.5 MB, less than 67.17% of C# online submissions for Longest String Chain.
Uploaded: 06/15/2022 20:24
*/


public class Solution {
    static int Compare(string s1, string s2)
    {
        return s1.Length - s2.Length;
    }

    public int LongestStrChain(string[] words)
    {
        Dictionary<string, int> dp = new Dictionary<string, int>();
        Array.Sort<string>(words, Compare);
        int res = 0;
        foreach(var word in words)
        {
            int best = 0;
            for(int i = 0; i < word.Length; i++)
            {
                string prev = word.Substring(0, i) + word.Substring(i + 1);
                int dpvalue = 0;
                if (dp.ContainsKey(prev)) { dpvalue = dp[prev]; }
                best = Math.Max(best, dpvalue + 1);
            }
            if (!dp.ContainsKey(word)) dp.Add(word, 0);
            dp[word] = Math.Max(best,dp[word]);
            res = Math.Max(res, best);
        }
        return res;
    }
}
