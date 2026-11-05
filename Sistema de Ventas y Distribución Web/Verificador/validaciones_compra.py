from datetime import date

def es_numero_compra_valido(valor):
    if valor is None:
        return False
    try:
        numero = int(valor)
    except (ValueError, TypeError):
        return False
    return numero > 0

def es_fecha_compra_valida(valor):
    if valor is None:
        return False
    try:
        fecha = date.fromisoformat(valor)
    except ValueError:
        return False
    return fecha == date.today()

def es_total_valido(valor):
    if valor is None:
        return False
    try:
        total = float(valor)
    except (ValueError, TypeError):
        return False
    return total > 0

def es_lista_productos_valida(valor):
    if not isinstance(valor, list) or len(valor) == 0:
        return False
    for producto in valor:
        if "codigo_producto" not in producto or "cantidad" not in producto:
            return False
        try:
            codigo = int(producto["codigo_producto"])
            cantidad = int(producto["cantidad"])
        except (ValueError, TypeError):
            return False
        if codigo <= 0 or cantidad <= 0:
            return False
    return True

def validar_compra(compra):
    campos_cifrados_presentes = all(
        compra.get(campo) for campo in (
        "tarjeta_cifrada",
        "vencimiento_cifrado",
        "cvv_cifrado",
        )
    )

    return (
        es_numero_compra_valido(compra.get("numero_compra"))
        and compra.get("identificacion_cliente") is not None
        and es_fecha_compra_valida(compra.get("fecha_compra"))
        and es_total_valido(compra.get("total_compra"))
        and campos_cifrados_presentes
        and es_lista_productos_valida(compra.get("productos"))
    )