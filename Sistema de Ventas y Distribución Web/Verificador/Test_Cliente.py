import json
import os
import socket

CONFIG_PATH = os.path.join(os.path.dirname(os.path.abspath(__file__)), "config.json")

def cargar_configuracion(path: str) -> dict:
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
    host = configuracion["host"] if configuracion ["host"] != "0.0.0.0" else "127.0.0.1"

        #PRUEBA
    trama_alta = {
        "tipo_transaccion": "agregar",
        "identificacion": "305260512",
        "pais_origen": "CR",
        "nombre": "Andres",
        "primer_apellido": "Sanchez",
        "segundo_apellido": "Brenes",
        "correo_electronico": "esanchezb@gmail.com",
        "telefono": "87122024",
        "direccion": "Cartago, Costa Rica,"
    }
    print(enviar_trama(host, configuracion["port"], trama_alta))