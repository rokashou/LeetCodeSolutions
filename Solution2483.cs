/*
Aug 30, 2023 00:25
Runtime 68 ms Beats 66.67%
Memory 42.2 MB Beats 33.33%
*/


public class Solution {
    public int BestClosingTime(string customers) {
        int curPenalty = 0;
        for(int i = 0; i < customers.Length; i++)
        {
            if (customers[i] == 'Y')
                curPenalty++;
        }

        // Start with closing at hour 0, the penalty equals all 'Y' in closed hours.
        int minPenalty = curPenalty;
        int earliestHour = 0;

        for(int i = 0; i < customers.Length; i++)
        {
            var ch = customers[i];
            // If status in hour i is 'Y', moving it to open hours decrement
            // penalty by 1. Otherwise, moving 'N' to open hours increment
            // penalty by 1.
            if (ch == 'Y')
                curPenalty--;
            else
                curPenalty++;

            if(curPenalty < minPenalty)
            {
                earliestHour = i + 1;
                minPenalty = curPenalty;
            }
        }

        return earliestHour;
    }
}
