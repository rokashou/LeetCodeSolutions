/*
No recursive Looping: Best Space solution
Apr 15, 2023 19:03
Runtime 149 ms Beats 36.61%
Memory 43 MB Beats 85.27%
*/

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> ans = new List<IList<int>>();
        IList<int> first = new List<int>();
        first.Add(nums[0]);
        ans.Add(first);

        for(int i=1; i<nums.Length; i++)
        {
            IList<IList<int>> newAns = new List<IList<int>>();
            for(int j=0; j<=i; j++)
            {
                foreach(var list in ans)
                {
                    IList<int> newList = new List<int>(list);
                    newList.Insert(j,nums[i]);
                    newAns.Add(newList);
                }
            }
            ans=newAns;
        }
        return ans;
    }
}

/*
Best Time Solution
Apr 15, 2023 19:02
Runtime 135 ms Beats 91.2%
Memory 45 MB Beats 6.45%
*/
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        return PermuteImpl(new List<int>(), nums.ToList());
    }

    public IList<IList<int>> PermuteImpl(List<int> prefix, List<int> nums){
        List<IList<int>> ans = new List<IList<int>>();
        if(nums.Count>0){
            for(int i=0; i<nums.Count; i++){
                List<int> prefix_pi = new List<int>(prefix);
                prefix_pi.Add(nums[i]);
                List<int> nums_pi = new List<int>(nums);
                nums_pi.RemoveAt(i);
                ans.AddRange(PermuteImpl(prefix_pi, nums_pi));
            }
        }else{
            ans.Add(prefix);
        }

        return ans;
    }
}


/*
Backtracking
Apr 15, 2023 18:58
Runtime 147 ms Beats 43.90%
Memory 43.5 MB Beats 38.71%
*/

public class Solution {
    private void Recursive(List<int> numsList, IList<IList<int>> res, List<int> path)
    {
        if (numsList.Count == 0)
            res.Add(new List<int>(path));
        else
        {
            for(int i = 0; i < numsList.Count; i++)
            {
                var newNumsList = new List<int>(numsList);

                newNumsList.RemoveAt(i);
                path.Add(numsList[i]);
                Recursive(newNumsList, res, path);
                path.RemoveAt(path.Count - 1);
            }
        }
    }

    public IList<IList<int>> Permute(int[] nums)
    {
        var ans = new List<IList<int>>();
        var path = new List<int>();
        var numsList = new List<int>(nums);

        Recursive(numsList, ans, path);
        return ans;
    }
}
