CREATE TABLE Products (
    id serial primary key,
    Name CHARACTER VARYING(20),
    Cost MONEY,
    Volume integer
);

CREATE TABLE Managers (
    id serial primary key,
    Fio CHARACTER VARYING(20),
    Salary money,
    Age integer,
    Phone CHARACTER VARYING(20)
);

CREATE TABLE Sells (
    id serial primary key,
    ID_Manag int,
    ID_Prod int,
    count int, 
    Sum numeric,
    Date date
);

INSERT INTO managers (fio, salary, age, phone)
VALUES
('Efimov Artyom', 18000, 33, '+79027373068'),
('Ibragimova Inna', 120000, 36, '+79099999999')
;
INSERT INTO managers (fio, salary, age)
VALUES
('Ivanov Ivan', 10000, 100);


INSERT INTO products (name, cost, volume)
VALUES
('Фанера', 1200, 1800),
('Фанера-20', 1800, 1000),
('Фанера-10', 1100, 1000),
('Фанера-5', 600, 5000),
('ОСБ', 1200, 1000)
;

INSERT INTO sells (id_manag, id_prod, count, sum, date)
VALUES
(1, 2, 10, 1800*10, '2021.08.22'),
(2, 1, 10, 1200*10, '2021.07.25'),
(2, 1, 10, 1200*5, '2021.07.21'),

(1, 5, 10, 1200*5, '2021.06.20'),
(2, 5, 10, 1200*10, '2021.06.20'),
(1, 5, 10, 1200*10, '2021.06.22'),
(2, 5, 10, 1200*5, '2021.06.22')
;
