use std::collections::{BTreeMap, HashMap};



pub struct Solution;

impl Solution {
    pub fn count_of_atoms(formula: String) -> String {
        let mut running_mul = 1;
        let mut stack = vec![1];

        let mut final_map: HashMap<String, i32> = HashMap::new();

        let mut curr_atom = String::new();
        let mut curr_count = String::new();

        let mut chars = formula.chars().rev().peekable();

        while let Some(&ch) = chars.peek(){
            if ch.is_digit(10) {
                curr_count = ch.to_string() + &curr_count;
                chars.next();
            } else if ch.is_lowercase() {
                curr_atom = ch.to_string() + &curr_atom;
                chars.next();
            } else if ch.is_uppercase() {
                curr_atom = ch.to_string() + &curr_atom;
                let count = if curr_count.is_empty() {1} else {curr_count.parse::<i32>().unwrap()};
                *final_map.entry(curr_atom.clone()).or_insert(0) += count * running_mul;
                curr_atom.clear();
                curr_count.clear();
                chars.next();
            } else if ch==')' {
                chars.next();
                let curr_multiplier = if curr_count.is_empty() {1} else {curr_count.parse::<i32>().unwrap()};
                stack.push(curr_multiplier);
                running_mul *= curr_multiplier;
                curr_count.clear();
            }else if ch=='(' {
                chars.next();
                running_mul /= stack.pop().unwrap();
            }
        }

        let sorted_map: BTreeMap<_, _> = final_map.into_iter().collect();

        let mut ans = String::new();
        for(atom,count) in sorted_map{
            ans.push_str(&atom);
            if count > 1{
                ans.push_str(&count.to_string());
            }
        }

        ans

    }
}