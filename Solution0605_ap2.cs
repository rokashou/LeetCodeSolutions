/*
Uploaded: 01/18/2022 22:22
Runtime: 152 ms, faster than 31.85% of C# online submissions for Can Place Flowers.
Memory Usage: 39.3 MB, less than 98.52% of C# online submissions for Can Place Flowers.
*/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        for(int i=0;i<flowerbed.Length;i++){
            if(flowerbed[i] == 0 && 
                (i==0 || flowerbed[i-1] == 0) && 
                (i==flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {

                flowerbed[i] = 1;
                count++;
            }
            
            if(count >= n) return true;            
        }
        return false;
    }
}
