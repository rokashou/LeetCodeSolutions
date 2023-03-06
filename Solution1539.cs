/*
Mar 06, 2023 22:12
Runtime 92 ms Beats 46.54%
Memory 39.4 MB Beats 31.15%
*/

public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int ans = 1;
        
        for (int i = 0; i < arr.Length; i++)
        {
            while (ans < arr[i] && k > 1) { ans++; k--; }
            while (i<arr.Length && ans == arr[i]) { ans++; i++; }

            if (k == 1) return ans;
            i--;
        }

        return ans + k-1;
    }
}
