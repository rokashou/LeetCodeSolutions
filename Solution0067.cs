/*
Runtime: 154 ms, faster than 5.77% of C# online submissions for Add Binary.
Memory Usage: 36.8 MB, less than 71.68% of C# online submissions for Add Binary.
Uploaded: 01/10/2022 11:07
Url: https://leetcode.com/problems/add-binary

*/


public class Solution {
    public string AddBinary(string a, string b) {
        string result = string.Empty;
        int carry = 0;

        int lenA = a.Length;
        int lenB = b.Length;

        while(lenA > 0 || lenB > 0){
            int sum = carry;
            if (lenA > 0) {
                sum += (a[lenA - 1] - '0');
                lenA--;
            }
            if(lenB > 0) {
                sum += (b[lenB - 1] - '0');
                lenB--;
            }
            if(sum>1){
                carry = 1;
                sum -= 2;
            }else{
                carry = 0;
            }
            result = sum.ToString() + result;
        }
        if(carry>0){
            result = carry.ToString() + result;
        }

        return result;
    }
}
