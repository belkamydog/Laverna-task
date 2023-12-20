-- Created by: Efimov Artyom on 20.12.2023

-- Вывести количество повторяющихся значений и сами значения
-- из таблицы 'Товары', где количество повторений больше 1

SELECT 
    name AS product_name,
    COUNT(*) AS count
FROM products AS p
GROUP BY name
HAVING COUNT(*) > 1
;
