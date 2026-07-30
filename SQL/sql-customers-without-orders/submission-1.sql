-- Write your query below
SELECT C.name FROM customers C WHERE C.name NOT IN (SELECT C.name FROM customers C JOIN orders O ON C.id = O.customer_id); 