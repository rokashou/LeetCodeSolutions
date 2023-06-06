/*
Jun 06, 2023 23:28
Runtime 104 ms Beats 39.77%
Memory 40.6 MB Beats 40.91%
*/

public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);

        int a = arr[1] - arr[0];
        for(int i = 2; i < arr.Length; i ++)
        {
            if (arr[i] - arr[i - 1] != a) return false;
        }
        return true;
    }
}

