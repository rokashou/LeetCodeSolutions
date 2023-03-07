/*
Mar 08, 2023 00:38
Runtime 93 ms, Beats 82.86%
Memory 40.6 MB, Beats 76%
*/

public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var sb1 = string.Join("",word1);
        var sb2 = string.Join("",word2);

        if (sb1.Length != sb2.Length) return false;

        for (int i = sb1.Length-1; i >= 0; i--)
            if (sb1[i] != sb2[i]) return false;

        return true;
    }
}
