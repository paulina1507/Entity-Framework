create database TiendaEF2
use TiendaEF2
create table categoria(
       id integer primary key identity,
       nombre varchar(50) not null unique,
       descripcion varchar(256) null
);
create table producto(
       id integer primary key identity,
       id_categoria int not null,
       id_usuario int not null,
       nombre varchar(100) not null unique,
       descripcion varchar(256) null,
       precio decimal(11,2) not null,
       existentes int not null,
       FOREIGN KEY (id_categoria) REFERENCES categoria(id)
       ON DELETE CASCADE ON UPDATE CASCADE);
create table usuario(
       id integer primary key identity,
       id_producto int not null,
       nombre varchar(32) not null,
       apellidos varchar(32) not null,
       direccion varchar(70) null,
       email varchar(50) null,
       passw varchar(50) null,
       cp int null,
       localidad varchar(50) null,
       FOREIGN KEY (id_producto) REFERENCES producto(id)
       ON DELETE CASCADE ON UPDATE CASCADE);