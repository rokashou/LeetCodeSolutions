/*
Mar 29, 2023 23:55
Runtime 85 ms, Beats 82.76%
Memory 38.2 MB, Beats 79.31%
*/

public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        int result = 0; 
        Array.Sort(satisfaction); //Sort the array to check which dish will get X cooking time
        int j = 1;
        int tempMax = 0;

        //The sorting is because we want the least satisfaction dish to get the least cooking time
        //Naive Solution...
        //remove the least satisfaction dish each time and recalculate
        for (int i = 0; i < satisfaction.Length; i++)
        {
            j = 1;
            tempMax = 0;
            for (int k = i; k < satisfaction.Length; k++) //inside loop to check every single case
            {
                tempMax += satisfaction[k] * j;
                j++;
            }
            result = Math.Max(result, tempMax); //check if the tempmax is greater than the max itself (result)
        }
        return result;   
    }
}
