/*
Aug 23, 2023 22:11
Runtime 78 ms Beats 74.29%
Memory 36.9 MB Beats 94.29%
*/


public class Solution {
    public string ReorganizeString(string s) {
        var charCounts = new int[26];
        for(int i = 0; i < s.Length; i++)
            charCounts[s[i] - 'a']++;
        int maxCount = 0, letter = 0;
        for(int i = 0; i < charCounts.Length; i++)
        {
            if (charCounts[i] > maxCount)
            {
                letter = i;
                maxCount = charCounts[i];
            }
        }
        if(maxCount > (s.Length + 1) / 2)
            return "";

        var ans = new char[s.Length];
        int index = 0;

        // Place the most frequent letter
        while (charCounts[letter] != 0)
        {
            ans[index] = (char)(letter + 'a');
            index += 2;
            charCounts[letter]--;
        }

        // Place rest of the letters in any order
        for(int i=0;i<charCounts.Length;i++){
            while (charCounts[i] > 0)
            {
                if (index >= s.Length) index = 1;
                ans[index] = (char)(i + 'a');
                index += 2;
                charCounts[i]--;
            }
        }

        return new string(ans);
    }
}

