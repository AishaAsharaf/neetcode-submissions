-- Write your query below
 select s.seller_name from seller s 
 left join orders o on s.seller_id = o.seller_id 
 AND O.sale_date BETWEEN '2020-01-01' AND '2020-12-31'
 WHERE o.order_id IS NULL order by s.seller_name;