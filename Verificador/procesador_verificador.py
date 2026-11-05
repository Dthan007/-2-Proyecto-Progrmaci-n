from validaciones import validar_cliente

def procesar_cliente(trama, conexion_bd):
    tipo_transaccion = trama.get("tipo_transaccion")

    if not validar_cliente(trama):
        return {"status": "1"}

    identificacion = trama["identificacion"].strip()

    if tipo_transaccion == "agregar":
        if conexion_bd.existe_cliente(identificacion):
            return {"status": "2"}
        conexion_bd.insertar_cliente(trama)
        return {"status": "OK"}

    if tipo_transaccion == "modificar":
        if not conexion_bd.existe_cliente(identificacion):
            return {"status": "3"}
        conexion_bd.actualizar_cliente(trama)
        return {"status": "OK"}

    if tipo_transaccion == "borrar":
        if not conexion_bd.existe_cliente(identificacion):
            return {"status": "3"}
        if conexion_bd.tiene_facturas(identificacion):
            return{"status": "Error: cliente con historial de compras"}
        conexion_bd.borrar_cliente(identificacion)
        return {"status": "OK"}

    return{"status": "4"}