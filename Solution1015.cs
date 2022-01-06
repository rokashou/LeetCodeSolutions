/*
Uploaded: 12/30/2021 16:35 JST
Runtime: 53 ms, faster than 33.33% of C# online submissions for Smallest Integer Divisible by K.
Memory Usage: 25.2 MB, less than 100.00% of C# online submissions for Smallest Integer Divisible by K.
*/

public class Solution {
    public int SmallestRepunitDivByK(int k) {
        int remainder=0;
        for(int length_N=1;length_N<=k; length_N++){
            remainder = (remainder * 10 + 1) % k;
            if(remainder == 0){
                return length_N;
            }
        }
        return -1;
        
    }
}
