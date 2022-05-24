SELECT 
    customer_id,
    COUNT(visit_id) as count_no_trans
FROM
    Visits
WHERE
    Visits.visit_id NOT IN (
        SELECT DISTINCT visit_id FROM Transactions
    )
GROUP BY customer_id
