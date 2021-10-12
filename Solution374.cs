/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int left=1;
        int right = n;
        int k=1;
        while(left <= right){
            // beware here: can not use the statement as below
            // int result = (left + right) / 2;
            // because it may bigger than the maximum of int32!
            int result = left+ ((right-left) >> 1);
            k=guess(result);
            if(k == 0)
            {
                return result;
            }
            else if(k<0)
            {
                right = result - 1;
            }
            else
            {
                left = result + 1;
            }
        }
        return -1;
    }
}
