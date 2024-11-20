drop database if exists Proyecto;
create database Proyecto;
use Proyecto;


-- --------------------------------------------------------------------------------
-- ----------ROLES-----------------------------------------------------------------
create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');


-- --------------------------------------------------------------------------------
-- ----------USUARIO---------------------------------------------------------------
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

-- --------------------------------------------------------------------------------
-- ----------CLIENTE---------------------------------------------------------------
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

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (452, 'Juana', 'Mendez', 'DNI', '12356877', '26 896', 15289856, 'juana_m@gmail.com', 1, 452, 1);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (453, 'Guillermo', 'Velazquez', 'DNI', '36524898', '56 1236', 15238755, 'guillevelazquez@gmail.com', 1, 453, 1);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (454, 'Natalia', 'Mas', 'DNI', '142356991', 'Av Brown 4200', 15238952, 'nati@gmail.com', 1, 454, 0);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (455, 'Paloma', 'Herrera', 'DNI', '38235564', 'Diag San Jose 800', 15232321, 'paloma_herrera20@gmail.com', 1, 455, 1);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (456, 'Matias', 'Gilmoure', 'DNI', '29235644', '59 5800', 15298756, 'gilmouremat@gmail.com', 1, 456, 0);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (457, 'Rodrigo', 'Suarez', 'DNI', '34252981', 'Av 2 1200', 15238534, 'suarez.ro@gmail.com', 1, 457, 1);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (458, 'Valentina', 'Gonzalez', 'DNI', '46289523', '18 966', 15421423, 'valenhermi@gmail.com', 1, 458, 1);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (459, 'Juan Ignacio', 'Wolff', 'DNI', '32568234', '580 4326', 1523289, 'juaniw230@gmail.com', 1, 459, 1);

insert into cliente (IdCliente, Nombre, Apellido, TDoc, Dni, Domicilio, Telefono, Email, AptoFisico, NumCarnet, Socio)
values (460, 'Alejo', 'Sanz', 'DNI', '18255654', 'Av Cristobal 1320', 15238952, 'ale_ale_s@gmail.com', 1, 460, 1);

-- --------------------------------------------------------------------------------
-- ----------ACTIVIDAD-------------------------------------------------------------
create table actividad(
idActividad int,
nombreA varchar(40),
cupoA int,
precioA float,
constraint pk_actividad primary key(idActividad)
);

-- --------------------------------------------------------------------------------
-- ----------CUOTA-----------------------------------------------------------------
create table cuota(
idCuota int AUTO_INCREMENT,
idCliente int,
monto float,
fechaPago date,
fechaVencimiento date,
constraint pk_cuota primary key(idCuota),
constraint fk_pago foreign key (idCliente) references cliente(idCliente)
);

insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (452, 8500, '2024-11-16', DATE_ADD(NOW(), INTERVAL 1 MONTH));

insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (457, 8500, '2024-11-18', DATE_ADD(NOW(), INTERVAL 1 MONTH));

insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (458, 8500, '2024-11-19', DATE_ADD(NOW(), INTERVAL 1 MONTH));

insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (459, 8500, '2024-11-15', DATE_ADD(NOW(), INTERVAL 1 MONTH));


-- Datos para la carga de la tabla de cuotas vencidas de los socios
insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (453, 8500, '2024-11-10', NOW());

insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (455, 8500, '2024-11-10', NOW());

insert into cuota (idCliente, monto, fechaPago, fechaVencimiento)
values (460, 8500, '2024-11-10', NOW());


-- ///////////////////////////////////////////////////////////////////////////////////////////////////////////
-- ///////////////////////////////////////////////////////////////////////////////////////////////////////////


-- --------------------------------------------------------------------------------
-- ---- PROCEDIMIENTO PARA EL LOGIN------------------------------------------------
DELIMITER //  
CREATE PROCEDURE IngresoLogin(in Usu varchar(20),in Pass varchar(15))
BEGIN
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass 
			and Activo = 1;
END//

CALL IngresoLogin('dato1', 'dato2')//


-- ----------------------------------------------------------------------------------------------
-- ---- PROCEDIMIENTO PARA REGISTRAR UN NUEVO CLIENTE--------------------------------------------
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
-- PROCEDIMIENTO PARA EL PAGO DE LA CUOTA --------------------------------------
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


     
     