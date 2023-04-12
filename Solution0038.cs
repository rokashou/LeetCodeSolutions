/*
Apr 12, 2023 23:22
Runtime 69 ms, Beats 85.83%
Memory 37.2 MB, Beats 77.33%
*/


public class Solution {
    public string CountAndSay(int n)
    {
        string res = "1";
        for (int i = 1; i < n; i++)
        {
            res = Count(res);
        }
        return res;
    }

    private string Count(string s)
    {
        char ch = s[0];
        int count = 1;
        var sb = new StringBuilder();
        for(int i=1;i<s.Length;i++)
        {
            if (s[i] == ch)
                count++;
            else
            {
                sb.Append(count);
                sb.Append(ch);
                count = 1;
                ch = s[i];
            }
        }
        sb.Append(count);
        sb.Append(ch);

        return sb.ToString();
    }
}
