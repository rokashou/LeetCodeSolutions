/*
Runtime 301 ms, Beats 30.34%
Memory 59.5 MB, Beats 6.74%
Accepted: Feb 02, 2023 23:35
*/


public class Solution {
    private bool CompareList(IList<int> list1, IList<int> list2)
    {
        for(int i = 0; i < 4; i++)
        {
            if (list1[i] != list2[i]) return false;
        }
        return true;
    }

    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort<int>(nums);
        var hs = new List<IList<int>>();

        for(int i = 0; i <= nums.Length - 4; i++)
        {
            for(int j = nums.Length - 1; j >= i + 2; j--)
            {
                int l = i + 1;
                int r = j - 1;
                while (l < r) { 
                    long sum = (long)nums[i] + nums[l] + nums[r] + nums[j];
                    if (sum < target)
                    {
                        l++;
                    }
                    else if(sum > target)
                    {
                        r--;
                    }
                    else
                    {
                        var tmp = new List<int>(new int[]{ nums[i], nums[l], nums[r], nums[j] });

                        bool flag = false;
                        foreach(var item in hs)
                        {
                            if (CompareList(item, tmp))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if(flag==false)
                            hs.Add(tmp);

                        l++;
                    }

                }

            }
        }

        return hs;

    }
}
