/*
Runtime 17 ms, Beats 98.48%
Memory 30.7 MB, Beats 27.27%
Feb 13, 2023 22:49

Best Time 
*/

public class Solution {
    public int NthUglyNumber(int n) {
        int[] numbers = new int[1690];
        if (n < 0) return -1;
        if (n == 1) return 1;
        if (numbers[n - 1] > 0) return numbers[n - 1];

        int index2 = 0, index3 = 0, index5 = 0;
        numbers[0] = 1;

        for (int i = 1; i < n; i++)
        {
            numbers[i] = Math.Min(Math.Min(numbers[index2] * 2, numbers[index3] * 3), numbers[index5] * 5);
            if (numbers[i] == numbers[index2] * 2) index2++;
            if (numbers[i] == numbers[index3] * 3) index3++;
            if (numbers[i] == numbers[index5] * 5) index5++;
        }

        return numbers[n - 1];
    }
}


/*
Runtime 44 ms, Beats 48.48%
Memory 31.6 MB, Beats 27.27%
Feb 13, 2023 22:47

My Try
*/

public class Solution {
    public int NthUglyNumber(int n) {
        List<int> table = new();
        table.Add(1);
        List<int> l1 = new();
        l1.Add(2);
        List<int> l2 = new();
        l2.Add(3);
        List<int> l3 = new();
        l3.Add(5);

        while (table.Count < n)
        {
            int min = Math.Min(l1[0], Math.Min(l2[0], l3[0]));
            table.Add(min);
            l1.Remove(min);
            l1.Add(min * 2);
            l2.Remove(min);
            l2.Add(min * 3);
            l3.Remove(min);
            l3.Add(min * 5);
        }

        return table[n - 1];
    }
}
