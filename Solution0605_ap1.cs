/*
Runtime: 172 ms, faster than 24.81% of C# online submissions for Can Place Flowers.
Memory Usage: 39.9 MB, less than 72.59% of C# online submissions for Can Place Flowers.
Uploaded: 01/18/2022 21:56
*/


public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int i = 0, count = 0;
        while(i<flowerbed.Length){
            if(flowerbed[i] == 0 && 
                (i==0 || flowerbed[i-1] == 0) && 
                (i==flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {

                flowerbed[i] = 1;
                count++;
            }
            i++;
        }

        return count >= n;

    }
}
