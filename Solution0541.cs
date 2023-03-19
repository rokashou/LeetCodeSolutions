/*
Mar 19, 2023 12:18
Runtime 82 ms, Beats 71.57%
Memory 39 MB, Beats 89.22%
*/


public class Solution {
    public string ReverseStr(string s, int k) {
        var arr = s.ToCharArray();
        bool reverse = true;

        for (int i = 0; i < s.Length; i += k)
        {
            if (reverse)
            {
                int rvlen = (s.Length - i > k) ? k : (s.Length-i);
                Array.Reverse(arr, i, rvlen);
            }
            reverse = (reverse == false);
        }

        return new string(arr);
    }
}
