public class Solution {
    /*
    Runtime: 164 ms, faster than 77.14% of C# online submissions for Single Number III.
    Memory Usage: 43.4 MB, less than 7.62% of C# online submissions for Single Number III.
    */
    public int[] SingleNumber(int[] nums) {
        int size = (30000 - 2) / 2 + 2;
        int[] list = new int[size];
        int[] list2 = new int[size];
        int n=0;

        foreach(var item in nums)
        {
            int i = 0;
            for(; i < n; i++)
            {
                if(item == list[i])
                {
                    list2[i]++;
                    break;
                }
            }
            if (i == n)
            {
                list[i] = item;
                list2[i] = 1;
                n++;
            }
        }

        List<int> result = new List<int>();
        for(int i = 0; i < n; i++)
        {
            if (list2[i] == 1) result.Add(list[i]);
        }

        return result.ToArray();

    }
}
