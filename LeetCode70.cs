public class Solution {
    public int ClimbStairs(int n) {
        if(n==1) return 1;
        if(n==2) return 2;

        int a=1;
        int b=2;
        int k=3;
        for(short i=3;i<=n;i++)
        {
            k=a+b;
            a=b; 
            b=k;
        }

        return k;
    }
}
