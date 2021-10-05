public class Solution {
    public int Reverse(int x) {
            bool negative = x<0;
            
            string s = x.ToString();
            string s2 = string.Empty;
            for(int i=s.Length-1; i>=0; i--){
                if(negative && i==0) break;
                s2 += s[i];
            }

            if(negative) s2= "-" + s2;
            
            if(int.TryParse(s2,out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
    }
}
