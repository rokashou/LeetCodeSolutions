/*
Runtime 223 ms, Beats 64.58%
Memory 46.9 MB, Beats 33.33%
Feb 12, 2023 19:32
*/

public class Solution {
    public int[] MinOperations(string boxes) {
        int[] result = new int[boxes.Length];

        for(int i = 0; i < boxes.Length-1; i++)
        {
            for(int j = i+1; j < boxes.Length; j++)
            {
                result[i] += Math.Abs((i - j) * (boxes[j] - '0'));
                result[j] += Math.Abs((i - j) * (boxes[i] - '0'));
            }
        }

        return result;
    }
}
