struct Solution{}

impl Solution {
    pub fn max_satisfied(customers: Vec<i32>, grumpy: Vec<i32>, minutes: i32) -> i32 {
        Self::get_grumpy_count(&customers, &grumpy, minutes as usize)
            + Self::get_kind_minutes_count(&customers, &grumpy)
    }

    fn get_grumpy_count(customers: &[i32], grumpy: &[i32], mins: usize) -> i32 {
        let (mut left, mut right) = (0, mins);
        let mut grumpy_cur_count = 0;
        for i in 0..right {
            if(grumpy[i] == 1){
                grumpy_cur_count += customers[i];
            }
        }

        let mut grumpy_res_count = grumpy_cur_count;
        left += 1;
        while right < customers.len() {
            let substractor = if grumpy[left - 1] == 1 {
                customers[left - 1]
            } else { 0 };
            let addor = if grumpy[right] == 1 {
                customers[right]
            } else { 0 };
            grumpy_cur_count = grumpy_cur_count - substractor + addor;
            grumpy_res_count = grumpy_res_count.max(grumpy_cur_count);
            left += 1;
            right += 1;
        }
        grumpy_res_count
    }

    fn get_kind_minutes_count(customers: &[i32], grumpy: &[i32]) -> i32 {
        (0..customers.len())
            .map(|i| if grumpy[i] == 0 { customers[i] } else { 0 })
            .sum()
    }
}
