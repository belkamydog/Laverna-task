-- Created by: Efimov Artyom on 20.12.2023
-- Вывести кол-во продаж за 20 июня 2021

SELECT
    COUNT(*) AS count_sailes_2021_06_20
FROM sells
WHERE date = '2021.06.20'
; 