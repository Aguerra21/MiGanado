create database proyecto;
use proyecto;


create user administrador identified by 'administrador';
grant insert, delete, update, select on * to administrador;

create user contable identified by 'contable';
grant insert, update, select on compra to contable;
grant insert, update, select on venta to contable;

create user supervisor identified by 'supervisor';
grant select on * to supervisor;

create user empleado identified by 'empleado';
grant select, insert, update on movimientos to empleado;
grant select on animal to empleado;
grant select on potrero to empleado;
grant select on categoria to empleado;


create table usuarios (nombre varchar(50), 
apellido varchar(50), 
cedula int primary key, 
email varchar(60), 
contraseña varchar(256));
select * from usuarios;

create table animal (ID_animal int primary key auto_increment, 
fecha_nacimiento date, 
ID_categoria int, foreign key (ID_categoria) references categoria(ID_categoria),
ID_potrero int, foreign key (ID_potrero) references potrero(ID_potrero),
guia_compra varchar(30), foreign key (guia_compra) references compra(guia_compra),
guia_venta varchar(30), foreign key (guia_venta) references venta(guia_venta));


create table potrero(ID_potrero int primary key auto_increment, 
nombre varchar(30), 
hectareas int);
select * from potrero;

create table categoria(ID_categoria int primary key auto_increment,
nombre varchar(70),
unidad_ganadera decimal(5,2),
tipo varchar(40));
select * from categoria;
-- Agregar todas las categorias (Fijas)
-- Bovino
insert into categoria(nombre, unidad_ganadera, tipo) values ("Toro", 1.2, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría(primavera ternero menor de 2 meses)", 1.1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría(primavera ternero de 3 a 6 meses)", 1.3, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de criía(otoño desterneradas)", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría invierno(preñadas)", 0.8, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de invernada", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vaquillonas +2 años", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vaquillonas 1-2 años", 0.7, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Novillos +3 años ", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Novillos 2-3 años", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Novillos 1-2 años", 0.7, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Terneros/as", 0.4, "Bovinos");
-- Ovinos
insert into categoria(nombre, unidad_ganadera, tipo) values ("Carneros", 0.17, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Ovejas de cría", 0.17, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Ovejas de cría con cordero al pie", 0.18, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Capones y borregos de 2 a 4 dientes", 0.15, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Borregas 2-4 dientes", 0.15, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Borregos/as diente de leche", 0.11, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Ovejas de refugo", 0.15, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Corderos/as menos de 20kg", 0.08, "Ovinos");
-- Equinos
insert into categoria(nombre, unidad_ganadera, tipo) values ("Equinos adultos", 1.2, "Equinos");

create table compra(guia_compra varchar(30) primary key, 
fecha date, 
origen varchar(40));
select * from compra;

create table venta(guia_venta varchar(30) primary key,
fecha date,
destino varchar(40));
select * from venta;

create table movimientos ( 
ID_animal int, foreign key (ID_animal) references animal(ID_animal),
ID_potreroOrigen int, foreign key (ID_potreroOrigen) references potrero(ID_potrero),
ID_potreroDestino int, foreign key (ID_potreroDestino) references potrero(ID_potrero),
fecha date);
select * from movimientos;

create table calendario (ID_tarea int primary key auto_increment, tarea varchar(50), fecha date);
select * from calendario;

-- CONSULTAS
-- ordenar por id
SELECT p.nombre AS NombrePotrero, p.hectareas AS Hectareas, COUNT(a.ID_animal) AS CantidadAnimales
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
GROUP BY p.ID_potrero;

-- ordenar por hectareas
SELECT p.nombre AS NombrePotrero, p.hectareas AS Hectareas, COUNT(a.ID_animal) AS CantidadAnimales
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
GROUP BY p.ID_potrero ORDER BY p.hectareas DESC;

-- ordenar por cantidad animales
SELECT p.nombre AS NombrePotrero, p.hectareas AS Hectareas, COUNT(a.ID_animal) AS CantidadAnimales
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
GROUP BY p.ID_potrero ORDER BY CantidadAnimales DESC;
