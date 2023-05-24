/*
May 24, 2023 23:22
Runtime 321 ms Beats 72.73%
Memory 54.8 MB Beats 90.91%
*/

public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) 
    {
        var n = nums1.Length;
        var nums = new (int num1, int num2)[n];

        for (var i = 0; i < n; i++)
        {
            nums[i] = (nums1[i], nums2[i]);
        }

        Array.Sort(nums, (x, y) => y.num2.CompareTo(x.num2));

        var topK = new PriorityQueue<int, int>();

        long sum = 0;
        for (var i = 0; i < k; i++)
        {
            topK.Enqueue(nums[i].num1, nums[i].num1);
            sum += nums[i].num1;
        }

        long maxScore = sum * nums[k - 1].num2;

        for (var i = k; i < n; i++)
        {
            sum += nums[i].num1 - topK.Dequeue();
            topK.Enqueue(nums[i].num1, nums[i].num1);
            maxScore = Math.Max(maxScore, sum * nums[i].num2);
        }

        return maxScore;
    }
}
