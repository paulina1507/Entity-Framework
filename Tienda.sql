create database Tienda
use Tienda
create table categoria(
       id integer primary key identity,
       nombre varchar(50) not null unique
);

create table producto(
       id integer primary key identity,
       marca varchar(100) not null,
       id_categoria int not null,
       nombre varchar(100) not null unique,
       precio decimal(11,2) not null,
       existentes int not null,
       FOREIGN KEY (id_categoria) REFERENCES categoria(id)
       ON DELETE CASCADE ON UPDATE CASCADE
);
create table usuario(
       id integer primary key identity,
       nombre varchar(32) not null,
       apellidos varchar(32) not null,
       direccion varchar(70) null,
       email varchar(50) null,
       passw varchar(50) null,
       cp int null,
       localidad varchar(50) null
);
create table carrito(
       id integer primary key identity,
       id_usuario int not null,
       id_producto int not null,
       FOREIGN KEY (id_producto) REFERENCES producto(id),
       FOREIGN KEY (id_usuario) REFERENCES usuario(id)
       ON DELETE CASCADE ON UPDATE CASCADE
);
create table factura(
       id integer primary key identity,
	   pago decimal(11,2) not null,
	   importe decimal(11,2) not null,
	   fecha date,
       id_usuario int not null,
	   id_carrito int not null,
	   FOREIGN KEY (id_usuario) REFERENCES usuario(id),
       FOREIGN KEY (id_carrito) REFERENCES carrito(id)
       ON DELETE CASCADE ON UPDATE CASCADE
);