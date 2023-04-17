/*
Apr 17, 2023 22:08
Runtime 76 ms Beats 36.76%
Memory 37.1 MB Beats 41.18%
*/

public class Solution {
    public string GetPermutation(int n, int k) {
        List<int> numbers = new List<int>();
        int[] factorial = new int[n + 1];
        StringBuilder sb = new StringBuilder();

        // create an array of factorial lookup
        int sum = 1;
        factorial[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= i;
            factorial[i] = sum;
        }
        // factorial[] = {1, 1, 2, 6, 24, ... n!}

        // create a list of numbers to get indices
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        // numbers = {1, 2, 3, 4}

        k--;

        for (int i = 1; i <= n; i++)
        {
            int index = k / factorial[n - i];
            sb.Append(numbers[index].ToString());
            numbers.RemoveAt(index);
            k -= index * factorial[n - i];
        }

        return sb.ToString();

    }
}
