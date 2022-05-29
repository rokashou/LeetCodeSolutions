/*
Runtime: 418 ms, faster than 29.63% of C# online submissions for Maximum Product of Word Lengths.
Memory Usage: 39.8 MB, less than 59.26% of C# online submissions for Maximum Product of Word Lengths.
Uploaded: 05/29/2022 23:23
*/

public class Solution {
    private bool WordInString(string a, string b)
    {
        foreach(var ca in a)
        {
            if (b.Contains(ca)) return true;
        }
        return false;
    }

    public int MaxProduct(string[] words)
    {
        int maxCount = 0;
        for(int i=0; i < words.Length - 1; i++)
        {
            for(int j = i + 1; j < words.Length; j++)
            {
                if(WordInString(words[i],words[j]) == false)
                {
                    maxCount = Math.Max(maxCount, words[i].Length * words[j].Length);
                }
            }
        }
        return maxCount;
    }
}
