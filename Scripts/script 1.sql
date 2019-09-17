create table TiposContratos(
Id int primary key identity(1,1),
Nombre varchar(50) not null
);
insert into TiposContratos(nombre) values('Contrato salarial por hora'),('Contrato salarial mensual');
--select * from TiposContratos;



CREATE TABLE EMPLEADO (
ID INT PRIMARY KEY IDENTITY(1,1),
Identificacion varchar(20) not null,
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
SALARIO INT NOT NULL,
TIPOCONTRATO INT NOT NULL
);
ALTER TABLE EMPLEADO ADD FOREIGN KEY (TIPOCONTRATO) REFERENCES TIPOSCONTRATOS(ID);
insert into Empleado(Identificacion,Nombre, Apellido, Salario, TipoContrato) 
values ('123465789','Pedro','Perez',1000000,2),('1011121314','Juan','Juan',20000,1);
--select * from Empleado;