SELECT 
    employee_id,
    IF(employee_id % 2 = 0 or name LIKE 'M%',0,salary) as bonus
FROM Employees
ORDER BY employee_id
