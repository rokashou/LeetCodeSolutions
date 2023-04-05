/*
Apr 05, 2023 14:04
Runtime 154 ms, Beats 95.45%
Memory 58.5 MB, Beats 18.18%
*/

public class Solution {
    private int GetMaxMove(int n, int[] startPos, string s)
    {
        int count = 0;
        int x = startPos[0], y = startPos[1];
        foreach(var ch in s)
        {
            switch (ch)
            {
                case 'U':
                    x -= 1;
                    break;
                case 'D':
                    x += 1;
                    break;
                case 'L':
                    y -= 1;
                    break;
                case 'R':
                    y += 1;
                    break;
            }
            if (x < 0 || x >= n || y < 0 || y >= n) break;
            count++;
        }
        return count;
    }

    public int[] ExecuteInstructions(int n, int[] startPos, string s)
    {
        var res = new int[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            res[i] = GetMaxMove(n, startPos, s.Substring(i));
        }
        return res;
    }
}
