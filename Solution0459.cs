/*
Aug 22, 2023 00:06
Runtime 76 ms Beats 79.65%
Memory 50.7 MB Beats 67.70%
*/

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string t = s+s;
        return t.Substring(1, t.Length-2).Contains(s);
    }
}
