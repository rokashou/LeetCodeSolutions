/*
Feb 13, 2023 21:34
Runtime 29 ms, Beats 40.94%
Memory 26.6 MB, Beats 28.65%
*/


public class Solution {
    public int CountDigits(int num) {
        string s = num.ToString();
        int count = 0;
        for(int i = 0; i < s.Length; i++) {
            if (num % (s[i] - '0') == 0)
                count++;
        }
        return count;
    }
}
