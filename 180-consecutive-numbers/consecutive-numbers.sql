# Write your MySQL query statement below
WITH CombinedLogs AS(
    select num,
    lag(num,1) over(order by id) as numlag,
    lead(num,1) over(order by id)as numlead
    from Logs
)
select distinct num as ConsecutiveNums
from CombinedLogs
where num=numlag and num =numlead;