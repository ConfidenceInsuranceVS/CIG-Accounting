SELECT
    claim, _branch, COUNT(*)
FROM
    claims
GROUP BY
    claim, _branch
HAVING 
    COUNT(*) > 1