public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> result=new List<int>();
        int[] numbers=new int[nums.Length];
        for(int i = 0; i<nums.Length; i++)
        {
            numbers[nums[i]-1] += 1;
        }
        for(int j = 0; j<numbers.Length; j++)
        {
            if(numbers[j] == 0) result.Add(j+1);
        }
        return result;
    }
}
