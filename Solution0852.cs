/*
Jul 25, 2023 22:04
Runtime 203 ms Beats 90.18%
Memory 51.9 MB Beats 63.80%
*/

public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int r = arr.Length-1;
        int l = 0;

        while (l < r) {
            int m = l + (r - l) / 2;
            if (arr[m] < arr[m + 1])
                l = m + 1;
            else
                r = m;
        }
        return l;
    }
}
