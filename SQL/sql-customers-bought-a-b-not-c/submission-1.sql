-- Write your query below
SELECT C.customer_id,C.customer_name FROM customers C JOIN orders O ON C.customer_id =O.customer_id GROUP BY C.customer_id HAVING 
SUM( CASE WHEN O.product_name='A' THEN 1 ELSE 0 END)>0 AND 
SUM( CASE WHEN O.product_name='B' THEN 1 ELSE 0 END)>0 AND 
SUM(CASE WHEN O.product_name='C' THEN 1 ELSE 0 END)=0 ORDER BY C.customer_name;