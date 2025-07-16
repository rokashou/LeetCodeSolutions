struct Solution;

impl Solution {
    pub fn min_operations(logs: Vec<String>) -> i32 {
        let mut dist = 0;

        for cmd in logs.iter() {
            if cmd == "../" {
                dist = std::cmp::max(dist - 1, 0);
            } else if cmd != "./" {
                dist += 1;
            }
        }

        dist
    }
}