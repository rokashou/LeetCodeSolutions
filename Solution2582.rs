/*
submitted at Jul 06, 2024 15:10
Time 0ms Beats 100.00%
Memory 2.09MB Beats 50.00%
*/

impl Solution {
    pub fn pass_the_pillow(n: i32, time: i32) -> i32 {
        let m = 2 * (n - 1);
        let curr = time % m;
        
        if curr < n 
            {curr+1}
        else
            {m-curr+1}
    }
}
