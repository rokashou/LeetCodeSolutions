/*
Url: https://leetcode.com/problems/minimum-absolute-difference/
Uploaded: 12/21/2021 00:54
Runtime: 196 ms, faster than 57.33% of C# online submissions for Minimum Absolute Difference.
Memory Usage: 49.1 MB, less than 78.67% of C# online submissions for Minimum Absolute Difference.
*/

public class Solution {        
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        List<IList<int>> result=new List<IList<int>>();
        List<int> list = new List<int>(arr);
        int mini=1000000;
        list.Sort();
        for(int i=1;i<list.Count;i++){
            if(list[i]-list[i-1]<mini) mini=list[i]-list[i-1];
        }
        for(int i=1;i<list.Count;i++){
            if(list[i]-list[i-1]==mini){
            List<int> temp = new List<int>();
                temp.Add(list[i-1]);
                temp.Add(list[i]);
                result.Add(temp);
            } 
        }
        return (IList<IList<int>>)result; 
    }

}
