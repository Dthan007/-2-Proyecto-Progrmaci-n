import socket
import threading

HOST = "0.0.0.0"
PUERTO = 5000

def construir_respuesta_para(trama):
    campos = trama.split("|")
    codigos_producto = campos[4::2]

    if "8888888888" in codigos_producto:
        return "PRODUCTO INVALIDO"
    if "9999999999" in codigos_producto:
        return "CANTIDAD INSUF"
    return "EXITOSO"

def manejar_cliente(conexion, direccion):
    with conexion:
        datos = conexion.recv(4096)
        if not datos:
            return

        trama = datos.decode("utf-8")
        print("STUB ALMACEN RECIBO:", trama)

        respuesta = construir_respuesta_para(trama)
        conexion.sendall(respuesta.encode("utf-8"))

        print("STUB ALMACEN RECIBIO", trama)

def iniciar_stub():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as servidor:
        servidor.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        servidor.bind((HOST, PUERTO))
        servidor.listen()
        print("STUB ALMACEN ESCUCHANDO EN: ", HOST, PUERTO)

        while True:
            conexion, direccion = servidor.accept()
            hilo = threading.Thread(target=manejar_cliente, args=(conexion, direccion), daemon=True,)
            hilo.start()

if __name__ == "__main__":
    iniciar_stub()