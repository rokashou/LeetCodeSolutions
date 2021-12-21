/**
Runtime: 36 ms, faster than 94.02% of C# online submissions for Power of Two.
Memory Usage: 28.5 MB, less than 44.62% of C# online submissions for Power of Two.
Uploaded: 12/21/2021 23:43
Url: https://leetcode.com/problems/power-of-two/
*/

public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n>0) {
            if((n & n-1) == 0) return true;
            return false;
        }
        if(n < -1){
            if((n & n+1) == 0) return true;
            return false;
        }
        return false;
    }
}
