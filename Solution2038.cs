/*
Oct 02, 2023 23:53
Runtime 145 ms Beats 15.38%
Memory 42.2 MB Beats 100%
*/

public class Solution {
    public bool WinnerOfGame(string colors) {
        int alice = 0;
        int bob = 0;
        for(int i = 1; i < colors.Length - 1; i++)
        {
            if (colors[i-1] == colors[i] && colors[i] == colors[i + 1])
            {
                if (colors[i] == 'A')
                    alice++;
                else
                    bob++;
            }
        }

        return alice - bob >= 1;        
    }
}
