/**
 Uploaded: 10/03/2021 19:39
 Runtime: 84 ms, 74.18%
 Memory Usage: 26.3 MB, 78.73%
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
