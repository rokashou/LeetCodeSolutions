/*
Runtime 70 ms Beats 15.07% of users with C#
Memory 41.38 MB Beats 76.71% of users with C#
May 03, 2024 02:27
*/


public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        var arr = word.ToCharArray();
        var idx = word.IndexOf(ch);

        if (idx >= 0)
            Array.Reverse(arr, 0, idx + 1);

        return new string(arr);
    }
}
