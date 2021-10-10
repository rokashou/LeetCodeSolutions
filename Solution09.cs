        // string solution: 48 ms, 33 MB
        public bool IsPalindrome(int x) {
            if(x<0) return false;
            string origin = x.ToString();
            string reverseX = string.Empty;
            int length = origin.Length;

            for(int i=length-1;i>=0;i--){
                reverseX += origin[i];
            }

            return origin.Equals(reverseX);
        }

        // No string solution: 56 ms, 29.6 MB
        public bool IsPalindrome2(int x){

            // if the number < 0, it fail.
            // if the last digit is 0, it fail too.
            // 0 ~ 9 is good.
            if(x<0) return false;
            if(x<10) return true;
            if(x%10 == 0) return false;
            
            int rev=0;
            while(x>rev){
                rev = (10*rev) + (x % 10);
                x /= 10;
            }

            if(rev == x) return true;
            if(rev / 10 == x) return true;

            return false;
        }
