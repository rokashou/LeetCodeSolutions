/*
Runtime: 69 ms, faster than 87.38% of C# online submissions for Longest Common Subsequence.
Memory Usage: 36.2 MB, less than 96.74% of C# online submissions for Longest Common Subsequence.
Uploaded: 04/16/2022 00:32
*/


public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        const int maxLength = 1000;
        int[][] matrix = new int[2][];
        matrix[0] = new int[maxLength];
        matrix[1] = new int[maxLength];
        for(int i = 0; i < text1.Length; i++)
        {
            for(int j = 0; j < text2.Length; j++)
            {
                int idx = i % 2;
                int anidx = 1 - idx;
                if (text1[i] == text2[j]) {
                    matrix[anidx][j + 1] = matrix[idx][j] + 1;
                }
                else
                {
                    matrix[anidx][j + 1] = Math.Max(matrix[idx][j + 1], matrix[anidx][j]);
                }

            }
        }
        return matrix[text1.Length % 2][text2.Length];
    }
}
