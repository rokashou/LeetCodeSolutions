/*
Runtime: 112 ms, faster than 63.49% of C# online submissions for Basic Calculator.
Memory Usage: 37.5 MB, less than 89.42% of C# online submissions for Basic Calculator.
Uploaded: 11/20/2022 22:02
*/


public class Solution {
    public int Calculate(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int result = 0;
        int sign = 1;
        int num = 0;

        var stack = new Stack<int>();
        stack.Push(sign); // start from +1 sign

        for(int i = 0;i<s.Length; i++)
        {
            var c = s[i];
            switch (c)
            {
                case char ch when ch >= '0' && ch <= '9':
                    // if c == digit, continue add it to number
                    num = num * 10 + (c - '0');
                    break;
                case '+':
                case '-':
                    // if c == '+' or '-',
                    // add num to result before this sign;
                    // This sign = Last context sign * 1; clear num;
                    result += sign * num;
                    sign = stack.Peek() * (c == '+' ? 1 : -1);
                    num = 0; 
                    break;
                case '(':
                    // if c == '(', push the context sign to stack
                    stack.Push(sign);
                    break;
                case ')':
                    // if c == ')', pop the context sign and go back to last context;
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }

        result += sign * num; // Add the last num. 
        return result;
    }
}
