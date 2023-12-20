-- Created by: Efimov Artyom on 20.12.2023

-- Вывести менеджеров у которых имеется номер телефона

SELECT * FROM managers
WHERE phone IS NOT NULL;