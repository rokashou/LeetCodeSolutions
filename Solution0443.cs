/*
Runtime 162 ms Beats 87.62%
Memory 59.7 MB, Beats 11.43%
Mar 02, 2023 21:53
*/

public class Solution {
    public int Compress(char[] chars) {
        int currCharIdx = 0;
        int appIdx = 1;
        int count = 1;
        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == chars[currCharIdx])
            {
                count++;
            }
            else
            {
                if (count == 1)
                {
                    chars[appIdx] = chars[i];
                    currCharIdx = appIdx;
                    appIdx++;
                    continue;
                }

                char[] tmp = new char[4];
                int k = 0;
                while (count > 0)
                {
                    tmp[k] = (char)('0' + (count % 10));
                    count /= 10;
                    k++;
                }
                for (k-=1; k >= 0; k--)
                {
                    chars[appIdx] = tmp[k];
                    appIdx++;
                }
                
                chars[appIdx] = chars[i];
                currCharIdx = appIdx;
                appIdx++;

                count = 1;
            }
        }

        if (count > 1)
        {
            char[] tmp = new char[4];
            int k = 0;
            while (count > 0)
            {
                tmp[k] = (char)('0' + (count % 10));
                count /= 10;
                k++;
            }
            for (k -= 1; k >= 0; k--)
            {
                chars[appIdx] = tmp[k];
                appIdx++;
            }
        }

        return appIdx;
    }
}
