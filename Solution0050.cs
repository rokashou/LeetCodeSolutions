/*
Apr 15, 2023 20:38
Runtime 25 ms Beats 71.71%
Memory 26.8 MB Beats 64.97%
*/

public class Solution {
    public double MyPow(double x, int n) {
        double result = 1;

        while (n != 0) {
            if (n % 2 == 0) {
                x *= x;
                n /= 2;
            } else {
                result = n > 0 ? result * x : result / x;
                if (n > 0) {
                    n--;
                } else {
                    n++;
                }
            }
        }
        
        return result;
    }
}
