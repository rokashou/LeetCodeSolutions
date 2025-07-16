impl Solution {
    pub fn getNumOfBouquets(bloom_day: &Vec<i32>, mid: i32, k: i32) -> i32 {
        let mut numOfBouquets: i32 = 0;
        let mut count: i32 = 0;

        for flower in bloom_day{
            if *flower <= mid {
                count += 1;
            } else {
                count = 0;
            }

            if count == k {
                numOfBouquets += 1;
                count = 0;
            }
        }

        numOfBouquets
    }

    pub fn min_days(bloom_day: Vec<i32>, m: i32, k: i32) -> i32 {
        let mut start: i32 = 0;
        let mut end = 0;
        for day in &bloom_day{
            end = std::cmp::max(*day,end);
        }

        let mut minDays = -1;
        while start <= end {
            let mid = start + (end - start) / 2;
            if Self::getNumOfBouquets(&bloom_day, mid, k) >= m {
                minDays = mid;
                end = mid - 1;
            }else{
                start = mid + 1;
            }
        }

        minDays
    }

}