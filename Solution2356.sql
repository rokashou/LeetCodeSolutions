# Apr 03, 2023 22:13
# Runtime 949 ms, Beats 65.35%

SELECT teacher_id,COUNT(DISTINCT subject_id) as cnt 
FROM Teacher
GROUP BY teacher_id;
