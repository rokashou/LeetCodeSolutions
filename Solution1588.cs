/*
Mar 26, 2023 15:50
Runtime 80 ms Beats 93%
Memory 38.4 MB, Beats 30.45%
*/

public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        // initialize answer as 0
        int ans = 0, n=arr.Length;

        // Iterate over arr, calculate the occurrence of each index i:
        //   odd_left = left / 2 + 1
        //   odd_right = right / 2 + 1
        //   even_left = (left+1) / 2
        //   even_right = (right+1) / 2
        // add the current element arr[i] for (odd_left * odd_right + even_left * even_right) to answer
        for (int i = 0; i < arr.Length; i++)
        {
            int left = i, right = n - i - 1;
            ans += arr[i] * (left / 2 + 1) * (right / 2 + 1);
            ans += arr[i] * ((left + 1) / 2) * ((right + 1) / 2);
        }

        return ans;
    }
}
