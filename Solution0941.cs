/*
Runtime: 124 ms, faster than 77.90% of C# online submissions for Valid Mountain Array.
Memory Usage: 44.1 MB, less than 10.34% of C# online submissions for Valid Mountain Array.
Uploaded: 01/25/2022 21:18
*/

public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if(arr.Length < 3) return false;

        int status = 0;
        int pre = arr[0];
        for (int i = 1; i < arr.Length;i++){
            switch(status){
                case 0: // start: it must bigger than pre
                    if(arr[i] > pre){
                        status = 1;
                    }else{
                        return false;
                    }
                    break;
                case 1: // increasing
                    if(arr[i] > pre){
                        break; // do nothing
                    }else if(arr[i] < pre){
                        status = 2;
                    }else{
                        return false;
                    }
                    break;
                case 2:
                    if(arr[i] < pre){
                        break; // do nothing
                    }else{
                        return false;
                    }

                    break;
            }
            pre = arr[i];
        }
        if(status == 2) return true;
        return false;
    }
}
