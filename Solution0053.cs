/*
    Divide and Conquer
    Runtime: 389 ms, faster than 9.20% of C# online submissions for Maximum Subarray.
    Memory Usage: 46.5 MB, less than 99.87% of C# online submissions for Maximum Subarray.
    Uploaded: 05/08/2022 00:27
    Ref: https://www.geeksforgeeks.org/maximum-subarray-sum-using-divide-and-conquer-algorithm/
*/

public class Solution {
    // Returns sum of maximum sum subarray in arr[]
    public int MaxSubArray(int[] nums)
    {
        // Base Case: Only one element
        if(nums.Length == 1)
        {
            return nums[0];
        }

        int m = (nums.Length - 1) / 2;

        /* Return maximum of following three possible cases:
         * a) Maximum subarray sum in left half
         * b) Maximum subarray sum in right helf
         * c) Maximum subarray sum such that the subarray crosses the midpoint */
        return MaxInThree(
            MaxSubArray(nums[0..(m+1)]),
            MaxSubArray(nums[(m + 1)..^0]),
            MaxCrossingSum(nums,m));
    }

    // find the maximum possible sum in arr[]
    // such that arr[m] is part of it
    private int MaxCrossingSum(int[] arr, int mid)
    {
        // Include elements on left of mid
        int sum = 0;
        int left_sum = int.MinValue;
        for (int i = mid; i >= 0; i--)
        {
            sum += arr[i];
            if (sum > left_sum) left_sum = sum;
        }

        // Include elements on right of mid
        sum = 0;
        int right_sum = int.MinValue;
        for (int i = mid + 1; i < arr.Length; i++)
        {
            sum += arr[i];
            if (sum > right_sum) right_sum = sum;
        }

        // Return sum of elements on left
        // and right of mid
        // returning only left_sum + right_sum will fail for [-2,1]
        return MaxInThree(left_sum + right_sum, left_sum, right_sum);
    }

    private int MaxInThree(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
}


/*
    Kadane Algorithm
    Runtime: 256 ms, faster than 58.36% of C# online submissions for Maximum Subarray.
    Memory Usage: 48.2 MB, less than 78.18% of C# online submissions for Maximum Subarray.
    Uploaded: 05/08/2022 00:51
*/

public class Solution {
    public int MaxSubArray(int[] nums)
    {
        // Initialize:
        int max_so_far = int.MinValue;
        int max_ending_here = 0;

        // loop every element in nums
        for(int i = 0; i < nums.Length; i++)
        {
            max_ending_here = max_ending_here + nums[i];
            max_so_far = Math.Max(max_so_far, max_ending_here);
            if (max_ending_here < 0) max_ending_here = 0;
        }

        return max_so_far;
    }
}


