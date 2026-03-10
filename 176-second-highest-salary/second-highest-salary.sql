# Write your MySQL query statement below
select(select distinct salary from Employee ORDER BY salary DESC limit 1 OFFSET 1 ) as SecondHighestSalary