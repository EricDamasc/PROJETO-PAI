CREATE DATABASE ControleDeGastos

CREATE TABLE Motoristas(
placa varchar(10) not null primary key,
senha varchar(30) not null,
nome varchar(70) not null,
carro varchar (20) not null,
datadeinicio datetime null,)

CREATE TABLE tbluber(
idcarro int not null primary key,
datadacorrida varchar(25) not null,
horas varchar(10) not null,
km varchar(10) not null,
corridas int not null,
combustivel varchar(10) not null,
ganhos varchar(10) not null,
gasto varchar (10) null,
observacao varchar (500) null,)

CREATE TABLE tbl99(
idcarro int not null primary key,
datadacorrida varchar(25) not null,
horas varchar(10) not null,
km varchar(10) not null,
corridas int not null,
combustivel varchar(10) not null,
ganhos varchar(10) not null,
gasto varchar (10) null,
observacao varchar (500) null,)