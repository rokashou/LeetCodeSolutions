/*
Runtime: 92 ms, faster than 34.46% of C# online submissions for String to Integer (atoi).
Memory Usage: 36.1 MB, less than 75.81% of C# online submissions for String to Integer (atoi).
Uploaded: 01/14/2022 23:15
*/

public class Solution {
    public int MyAtoi(string s) {
        int sign = 1;
        int result = 0;
        int index = 0;
        int n = s.Length;

        // Discard all spaces from the beginning of the input string.
        while (index < n && s[index] == ' ')
        {
            index++;
        }

        // sign = +1, if it's positive number, otherwise sign = -1.
        if(index < n && s[index] == '+'){
            sign = 1;
            index++;
        }else if(index < n && s[index] == '-'){
            sign = -1;
            index++;
        }

        // Traverse next digits of input and stop if it is not a digit
        while(index < n && char.IsDigit(s[index])){
            int digit = s[index] - '0';

            // Check overflow and underflow conditions.
            if((result > int.MaxValue / 10) || (result == int.MaxValue / 10 && digit > int.MaxValue % 10)){
                // If integer overflowed return 2^31-1, otherwise if underflowed return -2^31.
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            // Append current digit to the result
            result = 10 * result + digit;
            index++;
        }

        // We have formed a valid number without any overflow/underflow.
        // Return it after multiplying it with its sign.
        return sign * result;
    }
}
