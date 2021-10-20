public class Solution {
    public string ReverseWords(string s) {
        string[] stock = s.Trim().Split(' ');
        StringBuilder sb = new StringBuilder();
        for(int len=stock.Length - 1;len>=0;len--){
            if(stock[len].Trim().Length > 0){
                sb.Append(stock[len]);
                sb.Append(' ');
            }
        }
        return sb.ToString().TrimEnd();
    }
}
