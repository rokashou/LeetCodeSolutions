/*
Runtime 148 ms,Beats 91.4%
Memory 46.8 MB,Beats 82.45%
Uploaded Jan 02, 2023 13:08 TPE
*/

public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        // Get the prefix sum array of the sorted 'nums'.
        Array.Sort<int>(nums);
        for (int i = 1; i < nums.Length; i++)
            nums[i] += nums[i - 1];

        // For each query, find its insertion index to the prefix sum array.
        int n = queries.Length;
        int[] answer = new int[n];
        for(int i = 0; i < n; i++)
        {
            int index = BinarySearch(nums, queries[i]);
            answer[i] = index;
        }

        return answer;

    }

    int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
                return mid + 1;
            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return nums[left] > target ? left : left + 1;
    }
}

