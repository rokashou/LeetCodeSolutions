/*
Mar 19, 2023 12:24
Runtime 252 ms, Beats 71.61%
Memory 61.7 MB, Beats 20.39%
*/

public class Solution {
    public void ReverseString(char[] s) {
        for (int i = 0; i < s.Length / 2; i++)
        {
            char tmp = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = tmp;
        }
    }
}
