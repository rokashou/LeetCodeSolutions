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

