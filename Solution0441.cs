public class Solution {

    /*
        Uploaded: 11/05/2021 17:31
        Runtime: 36 ms, faster than 90.28% of C# online submissions for Arranging Coins.
        Memory Usage: 27 MB, less than 11.11% of C# online submissions for Arranging Coins.
    */
    public int ArrangeCoins(int n)
    {
        int level = 0;

        int cnt = 1;

        while(n >= cnt)
        {
            n -= cnt;
            cnt+=1;
            level+=1;
        }

        return level;
    }
}
