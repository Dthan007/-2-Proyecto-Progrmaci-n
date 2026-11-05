USE verificador_db;

DELIMITER //
CREATE PROCEDURE sp_existe_compra(
    IN p_numero_compra BIGINT,
    OUT p_existe TINYINT
)
BEGIN
    SELECT COUNT(*) INTO p_existe
    FROM compras
    WHERE numero_compra = p_numero_compra;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE sp_insertar_compra(
    IN p_numero_compra BIGINT,
    IN p_identificacion_cliente VARCHAR(20),
    IN p_fecha_compra DATE,
    IN p_total_compra DECIMAL(12,2),
    IN p_tarjeta_cifrada VARBINARY(255),
    IN p_vencimiento_cifrado VARBINARY(255),
    IN p_cvv_cifrado VARBINARY(255),
    IN p_estado VARCHAR(20)
)
BEGIN
    INSERT INTO compras (
        numero_compra, identificacion_cliente, fecha_compra, total_compra,
        tarjeta_cifrada, vencimiento_cifrado, cvv_cifrado, estado
    ) VALUES (
        p_numero_compra, p_identificacion_cliente, p_fecha_compra, p_total_compra,
        p_tarjeta_cifrada, p_vencimiento_cifrado, p_cvv_cifrado, p_estado
    );
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE sp_insertar_detalle_compra(
    IN p_numero_compra BIGINT,
    IN p_codigo_producto BIGINT,
    IN p_cantidad INT
)
BEGIN
    INSERT INTO detalle_compra (numero_compra, codigo_producto, cantidad)
    VALUES (p_numero_compra, p_codigo_producto, p_cantidad);
END //
DELIMITER ;