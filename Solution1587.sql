SELECT * FROM
(
SELECT
    Users.name,
    SUM(amount) AS balance
FROM
    Transactions LEFT JOIN Users ON Users.account = Transactions.account
GROUP BY 
    Transactions.account
    
) AS T1
WHERE 
    balance > 10000;


SELECT
    U.name,
    SUM(T.amount) AS balance
FROM
    Users U JOIN Transactions T ON U.account = T.account 
GROUP BY 
    T.account HAVING balance > 10000
    
