struct Solution;

impl Solution {
    pub fn average_waiting_time(customers: Vec<Vec<i32>>) -> f64 {
        let mut curTime = 0;
        let mut total: f64 = 0.0;

        for c in &customers{
            curTime = max(curTime, c[0]) + c[1];
            total += curTime - c[0];
        }

        total / customers.len()
    }
}