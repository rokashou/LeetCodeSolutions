/*
Runtime: 33 ms, faster than 45.24% of C# online submissions for Count Sorted Vowel Strings.
Memory Usage: 25.2 MB, less than 64.29% of C# online submissions for Count Sorted Vowel Strings.
Uploaded: 05/11/2022 23:26
*/

public class Solution {
    int[,] summary;

    public int CountVowelStrings(int n)
    {
        summary = new int[5, 51];
        for (int i = 5; i > 0; i--) summary[i-1, 0] = 1;
        return CountSubVowel(5, n);
    }

    private int CountSubVowel(int k, int n)
    {
        if (summary[k-1, n] > 0) return summary[k-1, n];

        int sum = 0;
        for(int i = k; i > 0; i--)
        {
            sum += CountSubVowel(i,n-1);
        }
        summary[k - 1, n] = sum;
        return sum;
    }
}


/*
Runtime: 96 ms, faster than 19.05% of C# online submissions for Count Sorted Vowel Strings.
Memory Usage: 25.3 MB, less than 64.29% of C# online submissions for Count Sorted Vowel Strings.
Uploaded: 05/11/2022 23:08
*/

public class Solution {
    public int CountVowelStrings(int n)
    {
        return CountSubVowel(5, n);
    }

    private int CountSubVowel(int k, int n)
    {
        if (n == 1) return k;
        int sum = 0;
        for(int i = k; i > 0; i--)
        {
            sum += CountSubVowel(i,n-1);
        }
        return sum;
    }
}

