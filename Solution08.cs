public int MyAtoi(string s) {
            if(s.Length == 0) return 0;
            bool negative = false;
            string result=string.Empty;
            string Maximum = Int32.MaxValue.ToString();
            string Minimum = Int32.MinValue.ToString();
            int resultValue=0;

            int i = 0;
            while(i < s.Length && s[i] == ' ') i++;

            if(i > s.Length) return 0;
            if(s[i] == '+' || s[i] == '-') {
                if(s[i] == '-'){
                    negative = true;
                    result += s[i];
                }
                i++;
            }

            while(i < s.Length && s[i] >= '0' && s[i] <= '9') {
                result += s[i];
                i++;
                continue;
            }

            if(result.Length == 0) return 0;
            if(result.Length == 1 && negative) return 0;

            if(Int32.TryParse(result,out resultValue)){
                return resultValue;
            }
            else
            {
                if(negative){
                    if(result.Length > Minimum.Length || string.Compare(result,Minimum) > 0){
                        return Int32.MinValue;
                    }
                }
                else
                {
                    if(result.Length > Maximum.Length || string.Compare(result,Maximum) > 0){
                        return Int32.MaxValue;
                    }
                }
                return 0;
            }


        }
        
