/*
Runtime: 234 ms, faster than 27.12% of C# online submissions for 132 Pattern.
Memory Usage: 50 MB, less than 71.19% of C# online submissions for 132 Pattern.
Uploaded: 05/07/2022 21:16	
*/

public class Solution {
    public bool Find132pattern(int[] nums) {
        Stack<int> stack = new Stack<int>();
        int prev = int.MinValue;

        for(int i = nums.Length-1; i >= 0; i--)
        {
            while(stack.Count > 0 && stack.Peek() < nums[i])
            {
                if (prev > stack.Peek()) return true;
                prev = stack.Peek();
                stack.Pop();
            }
            stack.Push(nums[i]);
        }

        return (stack.Count > 0 && prev > stack.Peek());

    }
}

