-- Created by: Efimov Artyom on 20.12.2023
-- Вывести фамилии менеджеров и общую сумму продаж для каждого с товаром 'ОСБ'

SELECT
    (SELECT fio FROM managers WHERE id = s.id_manag) AS manager_name,
    SUM(s.sum)
FROM sells AS s
WHERE
    s.id_prod = (SELECT id FROM products WHERE name = 'ОСБ')
GROUP BY manager_name
; 