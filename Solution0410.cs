/*
Runtime: 111 ms, faster than 69.77% of C# online submissions for Split Array Largest Sum.
Memory Usage: 36.7 MB, less than 82.56% of C# online submissions for Split Array Largest Sum.
Uploaded: 03/31/2022 20:38
*/

public class Solution {
    private int MinimumSubarrayRequired(int[] nums, int maxSumAllowed){
        int currentSum = 0;
        int splitsRequired = 0;

        foreach(int element in nums){
            // Add element only if the sum doesn't exceed maxSumAllowed
            if(currentSum + element <= maxSumAllowed){
                currentSum += element;
            }else{
                // if the element addition makes sum more than maxSumAllowed
                // Increment the splits required and reset sum
                currentSum = element;
                splitsRequired++;
            }
        }

        // Return the number of subarrays, which is the number of splits + 1
        return splitsRequired + 1;
    }

    public int SplitArray(int[] nums, int m)
    {
        // find the sum of all elements and the maximum element
        int sum = 0;
        int maxElement = int.MinValue;
        foreach(int element in nums){
            sum += element;
            maxElement = Math.Max(maxElement, element);
        }

        // Define the left and right boundary of binary search
        int left = maxElement;
        int right = sum;
        int minimumLargesSplitSum = 0;
        while(left <= right){
            // find the mid value
            int maxSumAllowed = left + (right - left) / 2;

            // find the minimum splits. If splitsRequired is less than
            // or equal to m move towards left i.e., smaller values
            if(MinimumSubarrayRequired(nums,maxSumAllowed) <= m){
                right = maxSumAllowed - 1;
                minimumLargesSplitSum = maxSumAllowed;
            }
            else
            {
                // Move towards right if splitsRequired is more than m
                left = maxSumAllowed + 1;
            }
        }

        return minimumLargesSplitSum;

    }
}
