/*
Apr 18, 2023 14:53
Runtime 73 ms Beats 89.2%
Memory 37.3 MB Beats 56.71%
*/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        int len = Math.Max(word1.Length, word2.Length);
        int i;
        for(i=0;i<len; i++)
        {
            if(i<word1.Length)
                sb.Append(word1[i]);
            if(i<word2.Length)
                sb.Append(word2[i]);
        }
        return sb.ToString();
    }
}
