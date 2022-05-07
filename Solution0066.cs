/*
Runtime: 257 ms, faster than 6.21% of C# online submissions for Plus One.
Memory Usage: 40.9 MB, less than 62.31% of C# online submissions for Plus One.
Uploaded: 05/08/2022 01:43
*/

public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> list = new List<int>(digits);
        int carry = 1;
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            list[i] += carry;
            carry = (list[i] == 10) ? 1 : 0;
            list[i] %= 10;
        }
        if (carry == 1)
        {
            list.Insert(0, 1);
        }
        return list.ToArray();
    }
}



/*
Faster if dont use List.ToArray()

Runtime: 146 ms, faster than 77.14% of C# online submissions for Plus One.
Memory Usage: 40.7 MB, less than 93.79% of C# online submissions for Plus One.
Uploaded: 05/08/2022 01:53
*/
public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int carry = 1;
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            if(digits[i]+carry > 9)
            {
                digits[i] = 0;
                carry = 1;
            }
            else
            {
                digits[i] += 1;
                carry = 0;
                break; // can break if there is no carry up.
            }
        }
        if (carry == 1)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            for(int i = 0; i < digits.Length; i++)
            {
                result[i + 1] = digits[i];
            }
            return result;
        }

        return digits;
    }
}

