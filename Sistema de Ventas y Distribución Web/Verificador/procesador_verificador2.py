from validaciones_compra import validar_compra
from cliente_almacen import enviar_salida_almacen

HOST_ALMACEN = "127.0.0.1"
PUERTO_ALMACEN = 5000

def procesar_compra(trama, conexion_bd):
    if not validar_compra(trama):
        return {"status": "1"}

    numero_compra = trama["numero_compra"]
    identificacion_cliente = trama["identificacion_cliente"]

    if not conexion_bd.existe_cliente(identificacion_cliente):
        return {"status": "1"}

    if conexion_bd.existe_compra(numero_compra):
        return {"status": "1"}

    try:
        respuesta_almacen = enviar_salida_almacen(
            HOST_ALMACEN,
            PUERTO_ALMACEN,
            numero_compra,
            trama["fecha_compra"],
            trama["productos"],
        )
    except OSError:
        return {"status": "2"}

    if respuesta_almacen != "EXITOSO":
        return {"status": "2"}

    conexion_bd.insertar_compra(trama, "OK")

    for producto in trama["productos"]:
        conexion_bd.insertar_detalle_compra(numero_compra, producto)

    return {"status": "OK"}