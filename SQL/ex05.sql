-- Created by: Efimov Artyom on 20.12.2023
-- Вывести менеджера и товар, который продали 22 августа 2021

SELECT
    (SELECT fio FROM managers WHERE id = s.id_manag) AS manager_name,
    (SELECT name FROM products WHERE id = s.id) AS product_name
FROM sells AS s
WHERE
    date = '2021.08.22'; 