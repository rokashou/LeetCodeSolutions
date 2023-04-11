
/*
Approach: Array Access(C# 8.0 and above, because the range access)
Apr 11, 2023 21:13
Runtime 105 ms Beats 92.59%
Memory 43 MB Beats 61.11%
*/


public class Solution {
    public string RemoveStars(string s) {
        int len = 0;
        char[] buf = new char[s.Length];
        foreach(var ch in s)
        {
            if (ch == '*')
                len -= 1;
            else
                buf[len++] = ch;
        }
        return new string(buf[..len]);
    }
}

/*
Approach: Built-in StringBuilder
Apr 11, 2023 20:19
Runtime 111 ms, Beats 77.78%
Memory 43.8 MB, Beats 42.59%
*/

public class Solution {
    public string RemoveStars(string s) {
        var buf = new System.Text.StringBuilder();
        foreach(var ch in s)
        {
            switch (ch)
            {
                case '*':
                    buf.Length -= 1;
                    break;
                default:
                    buf.Append(ch);
                    break;
            }
        }
        return buf.ToString();        
    }
}
