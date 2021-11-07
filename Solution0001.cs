public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int index1=0;
        int index2=1;

        int maxindex = nums.Length;

        while (true)
        {
            int solution = nums[index1] + nums[index2];
            if (solution == target)
            {
                int[] result = new int[] { index1, index2 };
                return result;
            }

            index2++;

            if(index2 >= maxindex)
            {
                index1++;
                index2 = index1 + 1;
            }
        }
    }
}
