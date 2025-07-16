struct Solution;

impl Solution {
    pub fn is_prefix_of_word(sentence: String, search_word: String) -> i32 {
        let mut word_idx = 0;
        let mut i = 0;

        loop {
            word_idx += 1;

            // Check if the substring starting at `i` matches `search_word`
            if sentence[i..].starts_with(&search_word) {
                return word_idx;
            }

            // Find the next space in the sentence
            match sentence[i..].find(' ') {
                Some(pos) => i += pos + 1, // Move to the next word
                None => break,            // No more words in the sentence
            }
        }

        -1
    }
}