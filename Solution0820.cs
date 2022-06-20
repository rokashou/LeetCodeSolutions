/*
Runtime: 171 ms, faster than 25.00% of C# online submissions for Short Encoding of Words.
Memory Usage: 42.8 MB, less than 75.00% of C# online submissions for Short Encoding of Words.
Uploaded: 06/20/2022 20:50
*/

public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        HashSet<string> good = new HashSet<string>();
        foreach(var word in words)
        {
            good.Add(word);
        }

        foreach(var word in words)
        {
            for(int k = 1; k < word.Length; ++k)
            {
                good.Remove(word.Substring(k));
            }
        }

        int ans = 0;
        foreach(var word in good)
        {
            ans += word.Length + 1;
        }
        return ans;
    }
}
