struct Solution{}


impl Solution {
    pub fn num_water_bottles(num_bottles: i32, num_exchange: i32) -> i32 {
        let mut count = 0;
        let mut remaining = 0;
        let mut current_bottles = num_bottles;
        while current_bottles > 0 {
            count += current_bottles;
            remaining += current_bottles % num_exchange;
            current_bottles /= num_exchange;
            if remaining >= num_exchange {
                current_bottles += remaining / num_exchange;
                remaining = remaining % num_exchange;
            }
        }
        count        
    }
}