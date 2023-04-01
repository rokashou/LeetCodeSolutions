SELECT 
  unique_id, name 
FROM 
  Employees as EMP 
  LEFT JOIN EmployeeUNI as EUNI 
  ON EMP.id = EUNI.id
 
 
# Other Solution
SELECT 
  unique_id, name 
FROM 
  Employees as EMP 
  LEFT JOIN EmployeeUNI as EUNI 
  USING(id)
