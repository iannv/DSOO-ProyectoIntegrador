use proyecto;

alter table cliente change Dni Doc int;
select * from cliente;

delete from cliente where IdCliente = 450;

select * from cuota;
select * from cliente;


INSERT INTO cuota (idCuota, idCliente, monto, fechaPago, fechaVencimiento)
VALUES (4, 453, 12000, NOW(), '2024-11-16');

SELECT c.dni, c.nombre, c.apellido, cu.fechaPago, cu.fechaVencimiento, c.socio FROM cliente c
INNER JOIN cuota cu
ON c.idCliente = cu.idCliente;

SELECT c.dni FROM cliente c
INNER JOIN cuota cu
ON c.idCliente = cu.idCliente;

SELECT 
    cliente.numCarnet AS 'N° CARNET',
    cliente.nombre AS 'NOMBRE',
    cliente.apellido AS 'APELLIDO',
    cliente.telefono AS 'TELEFONO',
    cliente.email AS 'EMAIL',
    cuota.fechaVencimiento AS 'VENCIMIENTO'
FROM cliente
INNER JOIN cuota 
    ON cliente.idCliente = cuota.idCliente
WHERE cliente.socio = 1 AND cuota.fechaVencimiento = CURDATE();


SELECT socio, nombre FROM cliente WHERE socio = 1;
SELECT socio, nombre FROM cliente WHERE socio = 0;




select * from usuario;



DELIMITER //
CREATE PROCEDURE Cuota(
    IN IdCliente INT,
    IN Monto FLOAT,
    IN FechaPago DATE,
    IN FechaVencimiento DATE,
    OUT rta INT
)
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        SET rta = -1;
    END;

    INSERT INTO cuota (idCliente, monto, fechaPago, fechaVencimiento)
    VALUES (IdCliente, Monto, NOW(), DATE_ADD(NOW(), INTERVAL 1 MONTH));

    SET rta = LAST_INSERT_ID();
END //
DELIMITER ;