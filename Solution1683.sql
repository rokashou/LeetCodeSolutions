# Apr 03, 2023 22:03
# Runtime 1045 ms, Beats 84.28%
#



SELECT 
  tweet_id 
FROM
  Tweets
WHERE
  LENGTH(content) > 15;
