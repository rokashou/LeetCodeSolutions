/*
Runtime 56 ms, Beats 95.28%
Memory 36.2 MB, Beats 7.8%
Feb 12, 2023 21:00
Best Time Solution
*/



/*
Runtime 74 ms Beats 23.11%
Memory 35.8 MB Beats 41.4%
Feb 12, 2023 20:54
Decrease memory usage
*/
public class Solution {
    public int BalancedStringSplit(string s) {
        char currChar = 'K';
        int stackCount = 0;
        int count = 0;
        int idx = 0;
        while(idx < s.Length)
        {
            if(stackCount == 0)
            {
                currChar=s[idx];
                stackCount++;
                idx++;
                continue;
            }

            if (s[idx] == currChar)
                stackCount++;
            else
                stackCount--;
            idx++;

            if (stackCount == 0)
                count++;
        }
        return count;
    }
}



/*
Runtime 67 ms, Beats 53.77%
Memory 36.2 MB, Beats 7.8%
Feb 12, 2023 20:44
*/

public class Solution {
    public int BalancedStringSplit(string s) {
        var stack = new Stack<char>();

        int count = 0;
        int idx = 0;
        while(idx < s.Length)
        {
            if(stack.Count == 0)
            {
                stack.Push(s[idx]);
                idx++;
                continue;
            }

            switch (s[idx])
            {
                case 'L':
                    if (stack.Peek() == 'R')
                        stack.Pop();
                    else
                        stack.Push(s[idx]);
                    break;
                case 'R':
                    if (stack.Peek() == 'L')
                        stack.Pop();
                    else
                        stack.Push(s[idx]);
                    break;
            }
            idx++;

            if (stack.Count == 0)
                count++;
        }
        
        return count;
    }
}
