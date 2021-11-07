public class Solution {
    /*
    Runtime: 166 ms, faster than 22.36% of C# online submissions for Multiply Strings.
    Memory Usage: 36.4 MB, less than 39.14% of C# online submissions for Multiply Strings.
    */
    public string Multiply(string num1, string num2)
    {
        int[] result = new int[num1.Length + num2.Length];
        if (num1[0] == '0' || num2[0] == '0') return "0";

        for(int idx1 = 0; idx1 < num1.Length; idx1++)
        {
            for(int idx2 = 0; idx2 < num2.Length; idx2++)
            {
                int mulpy = (num1[idx1] - '0') * (num2[idx2] - '0');
                result[idx1 + idx2] +=  mulpy / 10;
                result[idx1 + idx2 + 1] += mulpy % 10;

                // carry up
                for(int i = idx1 + idx2 + 1; i > 0; i--)
                {
                    result[i - 1] += result[i] / 10;
                    result[i] %= 10;
                }

            }
        }

        string newResult=string.Empty;
        for(int i = 0; i < result.Length; i++)
        {
            if (i == 0 && result[i] == 0) continue;
            newResult += result[i].ToString();
        }

        return newResult;
    }
}
