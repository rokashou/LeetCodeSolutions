/*
Mar 23, 2023 21:43
Runtime 72 ms, Beats 84.38%
Memory 37.8 MB, Beats 62.50%
*/

public class Solution {
    public bool CheckIfPangram(string sentence) {
        bool[] charArray = new bool[26];

        foreach (var ch in sentence)
        {
            charArray[ch - 'a'] = true;
        }

        foreach (var bl in charArray)
            if (bl == false) return false;

        return true;
    }
}
