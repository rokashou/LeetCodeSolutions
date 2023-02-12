/*
Best Time Solution: O(n)
Runtime 128 ms, Beats 100%
Memory 46.7 MB, Beats 45.83%
Feb 12, 2023 19:41
*/

public class Solution {
    public int[] MinOperations(string boxes) {
        int[] result = new int[boxes.Length];

        int ballsRight = 0;
        int ballsLeft = 0;

        for (int i = 1; i < boxes.Length; i++)
        {
            if (boxes[i] == '1')
            {
                ballsRight++;
                result[0] += i;
            }
        }

        for(int i = 1; i < boxes.Length; i++)
        {
            if (boxes[i - 1] == '1') ballsLeft++;
            result[i] = result[i - 1] + ballsLeft - ballsRight;
            if (boxes[i] == '1') ballsRight--;
        }

        return result;
    }
}


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
