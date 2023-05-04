/*
May 04, 2023 22:47
Runtime 191 ms Beats 48%
Memory 55.9 MB Beats 12%
*/

public class Solution {
    public string PredictPartyVictory(string senate) {
        int idx = 0;
        while(senate.Length > 1)
        {
            int k;
            if (senate[idx] == 'R'){
                k = senate.IndexOf('D', idx + 1);
                if (k == -1) k = senate.IndexOf('D');
            }
            else
            {
                k = senate.IndexOf('R', idx + 1);
                if (k == -1) k = senate.IndexOf('R');
            }
            if (k != -1)
                senate = senate.Remove(k, 1);
            else
                break;
            idx++;
            if (idx >= senate.Length) idx = 0;
        }

        if (senate[0] == 'R')
            return "Radiant";
        else
            return "Dire";
    }
}
