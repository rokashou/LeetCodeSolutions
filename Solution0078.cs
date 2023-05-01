/*
Backtrack
Runtime 137 ms Beats 76.84%
Memory 42.8 MB Beats 24.8%
*/

public class Solution {
    private List<int> subset = new List<int>();
    private List<IList<int>> result = new List<IList<int>>();
    private void backtrack(int i, int[] nums) {
        if(i >= nums.Length) {
            result.Add(new List<int>(subset));
            return;
        }
        subset.Add(nums[i]);
        backtrack(i + 1, nums);
        subset.Remove(nums[i]);
        backtrack(i + 1, nums);
            
    }
    public IList<IList<int>> Subsets(int[] nums) {
        backtrack(0, nums);
        return result;  
    }
}

/*
Recurrsive
May 01, 2023 19:28
Runtime 144 ms Beats 43.1%
Memory 43.1 MB Beats 6.80%
*/

public class Solution {   
    public IList<IList<int>> Subsets(int[] nums) {
        var res = new List<IList<int>> { new List<int>() };

        foreach (var num in nums) {
            var newSubsets = new List<IList<int>>();
            foreach (var item in res) {
                var temp = new List<int>(item);
                temp.Add(num);
                newSubsets.Add(temp);
            }
            res.AddRange(newSubsets);
        }
        return res;
    }
}

/*
Bitmask
May 01, 2023 19:25
Runtime 145 ms Beats 39.34%
Memory 43 MB Beats 6.80%
*/

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var output = new List<IList<int>>();
        int n = nums.Length;
        int max = (int)Math.Pow(2, n);
        output.Add(new List<int>());
        for (int i=1;i<max;i++)
        {
            // append subset corresponding to that bitmask
            var curr = new List<int>();
            for (int j = 0,k = 1; j < n; ++j) {
                if ((k&i) > 0) curr.Add(nums[j]);
                k <<= 1;
            }
            output.Add(curr);
        }
        return output;
    }
}
