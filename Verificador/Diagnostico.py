import json
import traceback

from db_verificador import ConexionBD

with open("Config.json", "r", encoding="utf-8") as archivo:
    configuracion = json.load(archivo)

conexion_bd = ConexionBD(configuracion["mysql"])

try:
    resultado = conexion_bd.existe_cliente("305260546")
    print("existe_cliente funciono, resultado:", resultado)
except Exception:
    traceback.print_exc()