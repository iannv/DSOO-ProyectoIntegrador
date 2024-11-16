drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'Administrador','123456',120);


create table cliente(
IdCliente int,
Nombre varchar(30),
Apellido varchar(40),
TDoc varchar(20),
Dni int,
Domicilio varchar(60),
Telefono int,
Email varchar(30),
AptoFisico bool,
NumCarnet int,
Socio bool,
constraint pk_cliente primary key(IdCliente)
);


create table actividad(
idActividad int,
nombreA varchar(40),
cupoA int,
precioA float,
constraint pk_actividad primary key(idActividad)
);


create table cuota(
idCuota int AUTO_INCREMENT,
idCliente int,
monto float,
fechaPago date,
fechaVencimiento date,
constraint pk_cuota primary key(idCuota),
constraint fk_pago foreign key (idCliente) references cliente(idCliente)
);

INSERT INTO cuota (idCuota, idCliente, monto, fechaPago, fechaVencimiento)
VALUES (8, 455, 7000, NOW(), NOW());
-- --------------------------------------------------------------------------------
-- ---- PROCEDIMIENTO PARA EL LOGIN
DELIMITER //  
CREATE PROCEDURE IngresoLogin(in Usu varchar(20),in Pass varchar(15))
BEGIN
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass 
			and Activo = 1;
END//

CALL IngresoLogin('dato1', 'dato2')//


-- ------------------------------------------------------------------------------
-- ---- PROCEDIMIENTO PARA REGISTRAR UN NUEVO CLIENTE
use Proyecto;

DELIMITER //

 create procedure NuevoCliente(in Nom varchar(30), in Ape varchar(40), in Tip varchar(20), in Doc int, in Domicilio varchar(60), in Telefono int, in Email varchar(30), in Socio booL, in AptoFisico bool, out rta int)
 begin
     declare filas int default 0;
	 DECLARE existe int default 0;
    
     set filas = (select count(*) from cliente);
     if filas = 0 then
		set filas = 452;
     else
		set filas = (select max(IdCliente) + 1 from cliente);
		set existe = (select count(*) from cliente where TDoc = Tip and Dni = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into cliente values(filas,Nom,Ape,Tip,Doc, Domicilio, Telefono, Email, AptoFisico, filas, Socio);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end //
     
     DELIMITER ;

-- -----------------------------------------------------------------------------
-- PROCEDIMIENTO PARA EL PAGO DE LA CUOTA
DELIMITER //
CREATE PROCEDURE Cuota(
    IN IdCliente INT,
    IN Monto FLOAT,
    IN FechaPago DATE,
    /* IN FechaVencimiento DATE, */
    OUT rta INT
)
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        SET rta = -1;
    END;

    INSERT INTO cuota (idCliente, monto, fechaPago, fechaVencimiento)
    VALUES (IdCliente, Monto, FechaPago, DATE_ADD(NOW(), INTERVAL 1 MONTH));

    SET rta = LAST_INSERT_ID();
END //
DELIMITER ;


     
     