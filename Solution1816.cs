/*
Apr 09, 2023 20:39
Runtime 77 ms, Beats 83.6%
Memory 37.1 MB, Beats 87.43%
*/

public class Solution {
    public string TruncateSentence(string s, int k) {
        StringBuilder sb = new StringBuilder();
        var sa = s.Split(' ');
        int i;
        for(i=0;i<sa.Length && i<k; i++)
        {
            sb.Append(sa[i]);
            sb.Append(' ');
        }

        return sb.ToString().TrimEnd();
    }
}
