SELECT 
    employee_id,
    CASE
        WHEN employee_id % 2 = 0 THEN 0
        WHEN name LIKE 'M%' THEN 0
        ELSE salary
    END as bonus
FROM Employees
ORDER BY employee_id
