-- Created by: Efimov Artyom on 20.12.2023
-- Вывести все товары, у которых в названии имеется 'Фанера' и цена не ниже 1750

SELECT * FROM products
WHERE name LIKE '%Фанера%' AND cost >= 1750 ;