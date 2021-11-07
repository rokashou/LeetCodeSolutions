/*
Uploaded: 10/03/2021 21:53
Runtime: 112 ms, 72.88% faster
Memory Usage: 28.4 MB, 80.02% less
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        int index = 0;
        int maxCount = 0;
        int count = 0;
        int reIndex = 0;
        string subString = "";
        char current;

        while (index < s.Length)
        {
            current = s[index];

            reIndex = subString.IndexOf(current);
            if (reIndex == -1)
            {
                subString+=current;
                count++;
                if (count > maxCount) maxCount = count;
            }
            else
            {
                subString = subString.Substring(reIndex+1);
                subString+=current;
                count = subString.Length;
            }

            index++;
        }

        return maxCount;
    }
}
