-- ---------------------------------------------------------
-- Procedimiento: sp_existe_cliente
DELIMITER //
CREATE PROCEDURE sp_existe_cliente(
    IN p_identificacion VARCHAR(20),
    OUT p_existe TINYINT
)
BEGIN
    SELECT COUNT(*) INTO p_existe
    FROM clientes
    WHERE identificacion = p_identificacion;
END //
DELIMITER ;
 
-- ---------------------------------------------------------
-- Procedimiento: sp_insertar_cliente
DELIMITER //
CREATE PROCEDURE sp_insertar_cliente(
    IN p_identificacion   VARCHAR(20),
    IN p_pais_origen      CHAR(2),
    IN p_nombre           VARCHAR(60),
    IN p_primer_apellido  VARCHAR(60),
    IN p_segundo_apellido VARCHAR(60),
    IN p_correo           VARCHAR(100),
    IN p_telefono         VARCHAR(20),
    IN p_direccion        VARCHAR(200)
)
BEGIN
    INSERT INTO clientes (
        identificacion, pais_origen, nombre, primer_apellido,
        segundo_apellido, correo_electronico, telefono, direccion
    ) VALUES (
        p_identificacion, p_pais_origen, p_nombre, p_primer_apellido,
        p_segundo_apellido, p_correo, p_telefono, p_direccion
    );
END //
DELIMITER ;
 
-- ---------------------------------------------------------
-- Procedimiento: sp_actualizar_cliente
DELIMITER //
CREATE PROCEDURE sp_actualizar_cliente(
    IN p_identificacion   VARCHAR(20),
    IN p_pais_origen      CHAR(2),
    IN p_nombre           VARCHAR(60),
    IN p_primer_apellido  VARCHAR(60),
    IN p_segundo_apellido VARCHAR(60),
    IN p_correo           VARCHAR(100),
    IN p_telefono         VARCHAR(20),
    IN p_direccion        VARCHAR(200)
)
BEGIN
    UPDATE clientes
    SET pais_origen = p_pais_origen,
        nombre = p_nombre,
        primer_apellido = p_primer_apellido,
        segundo_apellido = p_segundo_apellido,
        correo_electronico = p_correo,
        telefono = p_telefono,
        direccion = p_direccion
    WHERE identificacion = p_identificacion;
END //
DELIMITER ;
 
-- ---------------------------------------------------------
-- Procedimiento: sp_tiene_facturas
DELIMITER //
CREATE PROCEDURE sp_tiene_facturas(
    IN p_identificacion VARCHAR(20),
    OUT p_tiene TINYINT
)
BEGIN
    SELECT COUNT(*) INTO p_tiene
    FROM compras
    WHERE identificacion_cliente = p_identificacion;
END //
DELIMITER ;
 
-- ---------------------------------------------------------
-- Procedimiento: sp_borrar_cliente
DELIMITER //
CREATE PROCEDURE sp_borrar_cliente(
    IN p_identificacion VARCHAR(20)
)
BEGIN
    DELETE FROM clientes WHERE identificacion = p_identificacion;
END //
DELIMITER ;