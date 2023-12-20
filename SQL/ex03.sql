-- Created by: Efimov Artyom on 20.12.2023
-- Вывести среднюю сумму продажи с товаром 'Фанера'

SELECT ROUND(AVG(sum), 2)
FROM sells AS s
WHERE 
    s.id_prod = (SELECT id FROM products WHERE name = 'Фанера')    
; 