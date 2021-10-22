public class Solution {

        class StockChar : IComparable<StockChar>
        {
            char ch;
            int count=0;

            public StockChar(char ch, int count=0)
            {
                this.ch = ch;
                this.count = count;
            }

            public int CompareTo(StockChar other)
            {
                int compare;
                compare = this.count.CompareTo(other.count);
                compare = -compare;
                if(compare == 0){
                    compare = this.ch.CompareTo(other.ch);
                }
                return compare;
            }

            public override string ToString()
            {
                string result=string.Empty;
                for(int i=0;i<count;i++){
                    result += ch;
                }
                return result;
            }
        }

        // LeetCode 451
        public string FrequencySort(string s) {
            int[] countChar = new int[255];
            
            foreach(char c in s){
                countChar[c]+=1;
            }

            List<StockChar> stocklist=new List<StockChar>();
            for(int i=0;i<255;i++){
                char ch = (char)i;
                if(countChar[i]>0)
                    stocklist.Add(new StockChar(ch,countChar[i]));
            }
            stocklist.Sort();

            string result=string.Empty;
            foreach(var item in stocklist){
                result+=item.ToString();
            }

            return result;
        }
}
