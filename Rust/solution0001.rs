/*
Jul 08, 2024 23:05
Runtime 1ms, Beats 49.02%
Memory 2.33MB, Beats 43.13%
*/


use std::collections::HashMap;

struct Solution;

impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut map = HashMap::new();
        for (i, &n) in nums.iter().enumerate() {
            if let Some(&index) = map.get(&(target - n)) {
                return vec![index, i as i32];
            } else {
                map.insert(n, i as i32);
            }
        }
        vec![]
    }
}
