impl Solution {
    pub fn is_valid(word: String) -> bool {
        if word.len() < 3 {
            return false;
        }

        let mut vowel = 0;
        let mut consonant = 0;
        let mut digit = 0;

        for mut c in word.chars() {
            // Convert uppercase to lowercase
            if c.is_ascii_uppercase() {
                c = c.to_ascii_lowercase();
            }

            if c.is_ascii_lowercase() {
                match c {
                    'a' | 'e' | 'i' | 'o' | 'u' => vowel += 1,
                    _ => consonant += 1,
                }
                continue;
            }

            if c.is_ascii_digit() {
                digit += 1;
                continue;
            }

            // If any other character (non-alphanumeric)
            return false;
        }

        vowel > 0 && consonant > 0
    }
}