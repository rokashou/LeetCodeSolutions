public class Solution {
    /*
    Uploaded: 10/10/2021 12:59
    Runtime: 57 ms, 41.38% faster
    Memory Usage: 26 MB, 68.70% less memory
    */
    public int RangeBitwiseAnd(int left, int right) {
        if(left==0) return 0;
        if(left==1 && right > 1) return 0;
        
        int result=left & right;
        int nextStep = 1;
        for(int i=left+1;i>left && i<right;i+=nextStep){
            nextStep <<= 1;
            result &= i;
            if(result == 0) return 0;
        }
        
        return result;
    }
    
    /*
    Uploaded: 10/10/2021 12:52
    Runtime: 69 ms, 29.44% faster
    Memory Usage: 16 MB, 94.43% less memory
    */
    public int RangeBitwiseAnd2(int left, int right) {
        if(left==0) return 0;
        if(left==1 && right > 1) return 0;
        
        int result=left & right;
        int nextStep = 1;
        for(int i=left+1;i>left && i<right;i+=nextStep){
            nextStep *= 2;
            result &= i;
            if(result == 0) return 0;
        }
        
        return result;
    }
}
