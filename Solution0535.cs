/*
Runtime: 90 ms, faster than 66.93% of C# online submissions for Encode and Decode TinyURL.
Memory Usage: 37.4 MB, less than 90.55% of C# online submissions for Encode and Decode TinyURL.
Uploaded: 04/23/2022 19:04	
Ref: https://www.geeksforgeeks.org/how-to-design-a-tiny-url-or-url-shortener/

*/

public class Codec {
    Dictionary<string, string> table=new Dictionary<string, string>();

    // Function to generate a short url from integer ID
    static string idToShortURL(int n)
    {
        // Map to store 62 possible characters
        char[] map = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

        string shorturl = "";

        // Convert given integer id to a base 62 number
        while (n > 0)
        {
            // use above map to store actual character
            // in short url
            shorturl += (map[n % 62]);
            n = n / 62;
        }

        // Reverse shortURL to complete base conversion
        return shorturl;
    }

    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        int hc = longUrl.GetHashCode();

        string shortUrl = idToShortURL(hc);
        table.Add(shortUrl, longUrl);

        return shortUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        return table[shortUrl];
    } 
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));


