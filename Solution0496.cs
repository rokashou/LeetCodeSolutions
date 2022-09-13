/*
Runtime: 187 ms, less than 67.95%
Memory Usage: 39.6 MB, less than 100%
Uploaded: 10/19/2021 22:01
*/

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] ans = new int[nums1.Length];
        int flag=0;
        for(int i=0;i<nums1.Length;i++){
            flag=0;
            for(int j=0;j<nums2.Length;j++){

                if(flag==0 && nums1[i]==nums2[j]){
                    flag=1;
                    continue;
                }

                if(flag==1 && (nums1[i] < nums2[j])){
                    flag=2;
                    ans[i]=nums2[j];
                    break;
                }

            }
            if(flag < 2){
                ans[i]=-1;
            }
        }
        return ans;

    }
}
