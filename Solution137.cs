public class Solution {
/*
Runtime: 148 ms, faster than 25.67% of C# online submissions for Single Number II.
Memory Usage: 39.7 MB, less than 8.11% of C# online submissions for Single Number II.
*/
    public int SingleNumber(int[] nums) {
        int[,] list = new int[10000,2];
        int n=0;
        foreach(var item in nums)
        {
            int i = 0;
            for(; i < n; i++)
            {
                if(item == list[i, 0])
                {
                    list[i,1] +=1;
                    break;
                }
            }
            if (i == n)
            {
                list[i, 0] = item;
                list[i, 1] = 1;
                n++;
            }
        }

        int result=0;
        for(int i = 0; i < n; i++)
        {
            if (list[i, 1] == 1)
            {
                result = list[i, 0];
                break;
            }
        }

        return result;
    }
}
