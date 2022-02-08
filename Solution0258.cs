/*
Runtime: 29 ms, faster than 76.19% of C# online submissions for Add Digits.
Memory Usage: 25.5 MB, less than 57.14% of C# online submissions for Add Digits.
Uploaded: 02/08/2022 23:22
Url: https://ja.wikipedia.org/wiki/%E6%95%B0%E5%AD%97%E6%A0%B9
*/

public class Solution {
    public int AddDigits(int num) {
        if(num<10) return num;
        int n = num % 9;
        if(n==0) return 9;
        return n;
    }
}

