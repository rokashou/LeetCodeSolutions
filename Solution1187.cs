/*
Jun 17, 2023 13:38
Runtime 118 ms Beats 100%
Memory 60.2 MB Beats 33.33%
*/


public class Solution {
    private static int Higher(int[] array, int value) {
        if (value == int.MaxValue)
            return -1;
        
        int result = Array.BinarySearch(array, value + 1);
        
        if (result >= 0)
            return result;
        
        result = ~result;
        
        if (result >= array.Length)
            result = -1;
        
        return result;
    }
    
    public int MakeArrayIncreasing(int[] arr1, int[] arr2) {
        arr2 = arr2
            .Distinct()
            .OrderBy(x => x)
            .ToArray();
        
        int p = Math.Min(arr1.Length, arr2.Length);
        
        int[][] dp = Enumerable
            .Range(0, arr1.Length)
            .Select(_ => Enumerable.Repeat(int.MaxValue, p + 1).ToArray())
            .ToArray();
        
        dp[0][0] = arr1[0];
        
        for (int i = 1; i < arr1.Length; ++i)
            if (arr1[i] <= arr1[i - 1])
                break;
            else
                dp[i][0] = arr1[i];
        
        for (int j = 1; j <= p; ++j)
            dp[0][j] = Math.Min(arr1[0], arr2[0]);
        
        for (int i = 1; i < arr1.Length; ++i) {
            for (int j = 1; j <= Math.Min(i + 1, p); ++j) {
                if (arr1[i] > dp[i - 1][j])
                    dp[i][j] = arr1[i];
                
                if (dp[i - 1][j - 1] == int.MaxValue)
                    continue;
                    
                int index = Higher(arr2, dp[i - 1][j - 1]);
                
                if (index >= 0)
                    dp[i][j] = Math.Min(dp[i][j], arr2[index]);
            }
        }
        
        for (int i = 0; i <= p; ++i)
            if (dp[arr1.Length - 1][i] != int.MaxValue)
                return i;
        
        return -1;
    }
}
