create database if not exists `examen2`;
use `examen2`;

create table if not exists `usuarios`(
	id int primary key auto_increment,
	username VARCHAR(50) not null,
    password varchar(50) not null,
	nombre VARCHAR(50) not null,
	apellido VARCHAR(50) not null,
    dpi int not null,
    edad int not null,
    estado tinyint not null
);
create table if not exists `sede`(
	id int primary key auto_increment,
	nombre VARCHAR(50) not null,
    capacidad int,
    estado tinyint not null
);

create table if not exists `entrenador`(
	id int primary key auto_increment,
	equipo int,
    campeonato int,
    estado tinyint not null
);

create table if not exists `deporte`(
	id int primary key auto_increment,
	nombre VARCHAR(50) not null,
    estado tinyint not null
);

create table if not exists `campeonatos`(
	id int primary key auto_increment,
    sede int,
    deporte int,
	nombre VARCHAR(50) not null,
    cantidadEquipo int not null,
    estado tinyint not null
);

create table if not exists `equipos`(
	id int primary key auto_increment,
    propietario int,
    deporte int,
	nombre VARCHAR(50) not null,
    estado tinyint not null
);


create table if not exists `partido`(
	id int primary key auto_increment,
    campeonato int,
    fecha date not null,
    equipoLocal int not null,
    marcadorLocal int not null,
    equipoVisitante int not null,
    marcadorVisitante int not null,
    estado tinyint not null
);