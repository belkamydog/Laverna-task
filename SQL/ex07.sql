-- Created by: Efimov Artyom on 20.12.2023
-- Вывести историю продаж товаров, группируя по месяцу продажи наименованию товара

SELECT 
    (SELECT name FROM products WHERE id = s.id_prod) AS product_name,
    (SELECT SUM(count)) AS count,
    (SELECT SUM(sum)),
    EXTRACT(MONTH FROM date) AS month
FROM sells AS s
GROUP BY month, id_prod
ORDER BY month
; 