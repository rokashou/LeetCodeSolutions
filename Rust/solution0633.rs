impl Solution {
    pub fn judge_square_sum(c: i32) -> bool {
        let mut l:i64 = 0;
        let mut r:i64 = c.sqrt() as i64;

        while(l <= r){
            let sum = l * l + hi * hi;
            if (sum == c) {return true};
            if (sum > c) { 
                r-=1;
            }else {
                l+=1;
            }
        }

        false
    }
}