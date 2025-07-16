use std::collections::HashMap;

struct Solution;

impl Solution {
    pub fn frequency_sort(mut nums: Vec<i32>) -> Vec<i32> {
        let mut h:HashMap<i32, i32> = HashMap::new();
        for x in nums.iter() {
            *h.entry(*x).or_default() += 1;
        }
        nums.sort_by(|a,b| h.get(a).unwrap().cmp(h.get(b).unwrap()).then(b.cmp(a)));
        nums
    }
}