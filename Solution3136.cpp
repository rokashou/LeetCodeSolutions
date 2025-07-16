/*
Runtime 0ms, Beats 100.00%
Memory 7.84MB, Beats 86.98%

submitted at Jul 16, 2025 22:17
*/


class Solution {
public:
    bool isValid(string word) {
        if (word.length() < 3) return false;

        int vowel = 0;
        int consonant = 0;
        int digit = 0;
        for (int i = 0; i < word.length(); i++) {
            char c = word[i];
            if (c >= 'A' && c <= 'Z') c = c - 'A' + 'a';

            if (c >= 'a' && c <= 'z') {
                switch (c) {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowel += 1;
                        break;
                    default:
                        consonant += 1;
                }
                continue;
            }

            if (c >= '0' && c <= '9') {
                digit += 1;
                continue;
            }

            return false;
        }
        if(vowel > 0 && consonant > 0)
            return true;
        return false;
    }
};
