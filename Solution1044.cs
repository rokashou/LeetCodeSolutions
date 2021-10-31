public class Solution {
    // Runtime: 2656 ms, faster than 33.33% of C# online submissions for Longest Duplicate Substring.
    // Memory Usage: 40.8 MB, less than 100.00% of C# online submissions for Longest Duplicate Substring.
    // Updated: 2021-10-30
    
    public string LongestDupSubstring(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length <= 1) return "";

        string subString = string.Empty;
        string lds = string.Empty;

        int len = 1;
        int idx = 0;

        while (idx + len < s.Length)
        {
            subString = s.Substring(idx, len);
            if (s.Substring(idx + 1).Contains(subString))
            {
                len+=1;
                lds=subString;
            }
            else
            {
                idx += 1;
            }
        }

        return lds;
    }
}
