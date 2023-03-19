/*
Mar 19, 2023 11:49
Runtime 107 ms, Beats 36.32%
Memory 56.9 MB, Beats 18.96%
*/

public class Solution {
    public string ReverseWords(string s)
    {
        var banks = s.Split(' ');
        for (int i = 0; i < banks.Length; i++)
        {
            banks[i] = ReverseString(banks[i]);
        }
        return string.Join(' ', banks);
    }

    private string ReverseString(string input) {
        string ans = string.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
            ans += input[i];
        return ans;
    }
}
