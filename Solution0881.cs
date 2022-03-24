/*
Runtime: 300 ms, faster than 14.28% of C# online submissions for Boats to Save People.
Memory Usage: 46.5 MB, less than 23.81% of C# online submissions for Boats to Save People.
Upload: 03/24/2022 22:49

*/



public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort<int>(people);
        int i = 0, j = people.Length - 1;
        int ans = 0;

        while(i <= j){
            ans++;
            if(people[i] + people[j] <= limit){
                i++;
            }
            j--;
        }

        return ans;
    }
}
