public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        int length = nums.Length;
        int[] DpArray = new int[length];
        for(int i=0;i<length;i++){
            DpArray[nums[i]-1] += 1;
        }

        List<int> result= new List<int>();
        for(int j=0;j<length;j++){
            if(DpArray[j]==2) result.Add(j+1);
        }

        return result;
    }
}
