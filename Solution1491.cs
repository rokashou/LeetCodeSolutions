/*
May 01, 2023 13:48
Runtime 77 ms Beats 91.28%
Memory 38.7 MB Beats 11.2%
*/


public class Solution {
    public double Average(int[] salary) {
        double total = 0.0d;
        int max = 0, min = int.MaxValue;
        for (int i = 0; i < salary.Length; i++)
        {
            total += salary[i];
            max = Math.Max(max, salary[i]);
            min = Math.Min(min, salary[i]);
        }
        total -= max + min;
        return (total / (salary.Length - 2));
    }
}
