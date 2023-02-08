/*
Runtime 142 ms, Beats 50.36%
Memory 42.7 MB, Beats 30.2%
Accept Feb 08, 2023 20:58
*/

public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        if (n == 1) return 0;
        var minJump = new int[n];
        Array.Fill(minJump, int.MaxValue);

        for (int j = 0; j <= nums[0] && j < n; j++)
            minJump[j] = 1;

        for(int i = 1; i < n-1; i++)
        {
            for(int j = 1; j <= nums[i] && i+j < n; j++)
            {
                minJump[i+j] = Math.Min(minJump[i] + 1, minJump[i+j]);
            }
        }

        return minJump[n-1];

    }
}


/*
Best Time Solution
Greedy
*/

public class Solution {
    public int Jump(int[] nums) {
        int current = 0; // current farthest step
        int farthest = 0; // the farthest step form i
        int jump = 0; // count for jump

        for (int i = 0; i < nums.Length - 1; i++)
        {
            // the farthest i from index i
            farthest = Math.Max(farthest, nums[i] + i);

            // when reach the current farthest point
            if (i == current)
            {
                // reset the farthest step
                current = farthest;
                // add jump count
                jump++;
            }
        }
        return jump;
    }
}

