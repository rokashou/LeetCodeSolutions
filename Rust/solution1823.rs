struct Solution{}

impl Solution {
    pub fn find_the_winner(n: i32, k: i32) -> i32 {
        let mut ans = 0;
        for i in (2..(n+1)){
            ans = (ans + k) % i;
        }
        // add 1 to convert back to 1 indexing
        ans + 1 
    }
}