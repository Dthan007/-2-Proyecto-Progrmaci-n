import json
import os
import socket
from datetime import date
 
CONFIG_PATH = os.path.join(os.path.dirname(os.path.abspath(__file__)), "Config.json")
 
 
def cargar_configuracion(path):
    with open(path, "r", encoding="utf-8") as archivo:
        return json.load(archivo)
 
 
def enviar_trama(host, port, trama):
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as cliente:
        cliente.connect((host, port))
        cliente.sendall(json.dumps(trama).encode("utf-8"))
        respuesta = cliente.recv(4096)
        return json.loads(respuesta.decode("utf-8"))
 
 
if __name__ == "__main__":
    configuracion = cargar_configuracion(CONFIG_PATH)
    host = configuracion["host"] if configuracion["host"] != "0.0.0.0" else "127.0.0.1"
 
    trama_compra = {
        "historia": "VERIFICADOR2",
        "numero_compra": 2526202099,
        "identificacion_cliente": "305260546",
        "fecha_compra": date.today().isoformat(),
        "total_compra": 15000.50,
        "tarjeta_cifrada": "YWJjMTIz",
        "vencimiento_cifrado": "ZGVmNDU2",
        "cvv_cifrado": "Z2hpNzg5",
        "productos": [
            {"codigo_producto": 8888888888, "cantidad": 2},
        ],
    }
 
    print(enviar_trama(host, configuracion["port"], trama_compra))