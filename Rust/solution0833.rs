impl Solution {
    pub fn max_profit_assignment(difficulty: Vec<i32>, profit: Vec<i32>, worker: Vec<i32>) -> i32 {
        // Find maximum ability in the worker array
        let &maxAbility = worker.iter().max().unwrap_or(&0);
        let mut jobs: Vec<i32> = vec![0; (maxAbility + 1) as usize];

        let n:i32 = difficulty.len() as i32;

        for i in  0..n {
            if difficulty[i as usize] <= maxAbility {
                jobs[difficulty[i as usize] as usize] = 
                    std::cmp::max(jobs[difficulty[i as usize] as usize],profit[i as usize]);
            }
        }

        // Take maxima of prefixes
        for i in (1..(maxAbility+1)) {
            jobs[i as usize] = std::cmp::max(jobs[i as usize], jobs[(i-1) as usize]);
        }
        
        let mut netProfit:i32 = 0;
        for ability in worker{
            netProfit += jobs[ability as usize];
        }

        netProfit
    }
}


impl Solution2{
    pub fn max_profit_assignment(difficulty: Vec<i32>, profit: Vec<i32>, mut worker: Vec<i32>) -> i32 {
        let mut d: Vec<(i32,i32)> = difficulty.into_iter().zip(profit).collect();
        d.sort_unstable();
        worker.sort_unstable();
        let mut netProfit = 0;
        let (mut i, mut maxProfit) = (0,0);
        for w in worker {
            while i<d.len() && d[i].0 <= w {
                maxProfit = maxProfit.max(d[i].1);
                i+=1;
            }
            netProfit += maxProfit;
        }
        netProfit
    }
}