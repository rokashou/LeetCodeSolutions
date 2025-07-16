struct Solution{}

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