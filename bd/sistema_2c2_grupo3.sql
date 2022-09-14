create database sistema_2c2_grupo3;
use sistema_2c2_grupo3;

create table cliente(
id int unsigned auto_increment not null primary key,
usuario varchar(100)  not null ,
nome varchar(150) not null,
senha varchar(25)not null,
email varchar(150) not null,
dt_nasc date not null,
sexo char(3) not null,
est_civil varchar(25) not null,
endereco varchar(100) not null,
cidade varchar(50) not null,
estado char(2) not null,
cep char(9) not null,
cpf char(14) not null
)engine=InnoDB;
drop table produtos;

create table produtos(
codigo int auto_increment not null primary key,
nome varchar(50) not null,
tipo varchar(50) not null,
marca varchar(50) not null,
valor double (9,2) not null,
frete double (9,2) not null
)engine=InnoDB;