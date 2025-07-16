struct Solution {
    max_score: i32,
    freq: Vec<i32>,
}

impl Solution {
    fn new() -> Self {
        Solution {
            max_score: 0,
            freq: vec![0; 26],
        }
    }

    fn max_score_words(&mut self, words: Vec<String>, letters: Vec<char>, score: Vec<i32>) -> i32 {
        let w = words.len();
        let mut subset_letters = vec![0; 26];

        // Count how many times each letter occurs
        for c in letters {
            self.freq[(c as usize) - ('a' as usize)] += 1;
        }

        self.check(w as i32 - 1, &words, &score, &mut subset_letters, 0);
        self.max_score
    }

    fn is_valid_word(&self, subset_letters: &Vec<i32>) -> bool {
        for c in 0..26 {
            if self.freq[c] < subset_letters[c] {
                return false;
            }
        }
        true
    }

    fn check(&mut self, w: i32, words: &Vec<String>, score: &Vec<i32>, subset_letters: &mut Vec<i32>, total_score: i32) {
        if w == -1 {
            // If all words have been iterated, check the score of this subset
            self.max_score = self.max_score.max(total_score);
            return;
        }
        // Not adding words[w] to the current subset
        self.check(w - 1, words, score, subset_letters, total_score);
        // Adding words[w] to the current subset
        let word_len = words[w as usize].len();
        for i in 0..word_len {
            let c = (words[w as usize].chars().nth(i).unwrap() as usize) - ('a' as usize);
            subset_letters[c] += 1;
            let score_index = c as usize;
            total_score += score[score_index];
        }

        if self.is_valid_word(subset_letters) {
            // Consider the next word if this subset is still valid
            self.check(w - 1, words, score, subset_letters, total_score);
        }
        // Rollback effects of this word
        for i in 0..word_len {
            let c = (words[w as usize].chars().nth(i).unwrap() as usize) - ('a' as usize);
            subset_letters[c] -= 1;
            let score_index = c as usize;
            total_score -= score[score_index];
        }
    }
}

fn main() {
    let mut solution = Solution::new();
    let words = vec!["abc".to_string(), "def".to_string()];
    let letters = vec!['a', 'b', 'c', 'd', 'e', 'f'];
    let score = vec![1, 2, 3, 4, 5, 6];
    let max_score = solution.max_score_words(words, letters, score);
    println!("Max Score: {}", max_score);
}
