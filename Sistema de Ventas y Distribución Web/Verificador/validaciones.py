import re

PAISES_ISO_VALIDOS = { "CR", "US", "MX", "HN", "SV", "NI", "PA", "CO", "VE", "EC", "PE", "BO", "CL", "AR", "UY", "PY", "BR", "ES", "FR"}

PATRON_CORREO = re.compile(r"^[^@\s]+@[^@\s]+\.[^@\s]+$") #Estructura basica de un correo.    _____@gmail.com
PATRON_TELEFONO_CR = re.compile(r"^\d{8}$") #Valida que tenga 8 digitos que sean entre 0 y 9 c/u

def es_texto_valido(valor): #No debe ser numerico
    if valor is None:
        return False
    texto = valor.strip()
    if texto == "":
        return False
    if texto.isdigit():
        return False
    return True

def es_identificacion_valida(valor): #Valida que no este en blanco y que sean solo numeros
    if valor is None:
        return False
    texto = valor.strip()
    return texto.isdigit() and len(texto) > 0

def es_pais_valido(valor): #Solo paises validos
    if valor is None:
        return False
    return valor.strip().upper() in PAISES_ISO_VALIDOS

def es_correo_valido(valor):
    if valor is None:
        return False
    return bool(PATRON_CORREO.match(valor.strip()))

def es_telefono_cr_valido(valor): #Valida que no este en blanco, y que sea numero de 8 digitos
    if valor is None:
        return False
    return bool(PATRON_TELEFONO_CR.match(valor.strip()))

def es_direccion_valida(valor): #Valida que no este en blanco y retorna el texto.strip
    if valor is None:
        return False
    return valor.strip() != ""

def validar_cliente(cliente):
    return (
        es_identificacion_valida(cliente.get("identificacion"))
        and es_pais_valido(cliente.get("pais_origen"))
        and es_texto_valido(cliente.get("nombre"))
        and es_texto_valido(cliente.get("primer_apellido"))
        and es_correo_valido(cliente.get("correo_electronico"))
        and es_telefono_cr_valido(cliente.get("telefono"))
        and es_direccion_valida(cliente.get("direccion")))