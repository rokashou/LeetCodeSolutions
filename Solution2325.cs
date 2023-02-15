/*
Feb 15, 2023 22:24
Runtime 81 ms, Beats 89.10%
Memory 37.6 MB, Beats 37.97%
*/

public class Solution {
    public string DecodeMessage(string key, string message) {
        char[] dict = new char[26];
        int idx = 0;
        foreach(var ch in key)
        {
            if (ch == ' ') continue;
            if (dict[ch-'a']==0)
            {
                dict[ch - 'a'] = (char)('a' + idx);
                idx++;
            }
            if (idx == 26) break;
        }
        var ans = new System.Text.StringBuilder();
        foreach(var ch in message)
        {
            if (ch == ' ')
                ans.Append(' ');
            else
                ans.Append(dict[ch-'a']);
        }
        return ans.ToString();

    }
}


/*
Best Time Solution with Lampda
Runtime 82 ms, Beats 86.47%
Memory 37.9 MB, Beats 21.5%
*/

public class Solution {
    public string DecodeMessage(string key, string message) 
    {
        var decoder = new char[128];

        decoder[' '] = ' ';

        var alphabet = 'a';

        foreach(var c in key)
        {
            if(decoder[c] == 0)
            {
                decoder[c] = alphabet++;
            }
        }

        return new string(message.Select(_ => decoder[_]).ToArray());
    }
}
