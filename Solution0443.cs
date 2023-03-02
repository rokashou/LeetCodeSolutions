/*
Runtime 154 ms, Beats 97.14%
Memory 59.4 MB, Beats 30.48%

Mar 02, 2023 22:13
*/

public class Solution {
    public int Compress(char[] chars) {
        int currCharIdx = 0;
        int count = 1;
        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == chars[currCharIdx])
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    int k = 0;
                    while (count > 0)
                    {
                        chars[currCharIdx+1 +k] = (char)('0' + (count % 10));
                        count /= 10;
                        k++;
                    }
                    Array.Reverse(chars, currCharIdx+1, k);
                    currCharIdx += k;
                    count = 1;
                }

                chars[currCharIdx+1] = chars[i];
                currCharIdx += 1;
            }
        }

        if (count > 1)
        {
            int k = 0;
            while (count > 0)
            {
                chars[currCharIdx+1+k] = (char)('0' + (count % 10));
                count /= 10;
                k++;
            }
            Array.Reverse(chars, currCharIdx+1, k);
            currCharIdx += k;
        }
        currCharIdx += 1;

        return currCharIdx;
    }
}
