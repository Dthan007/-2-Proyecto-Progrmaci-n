import json
import queue
import threading
from datetime import datetime

cola_bitacora = queue.Queue()

def iniciar_hilo_bitacora(ruta_archivo):
    hilo = threading.Thread(target=procesar_cola, args=(ruta_archivo,), daemon=True)
    hilo.start()

def procesar_cola(ruta_archivo):
    while True:
        entrada = cola_bitacora.get()
        with open(ruta_archivo, "a", encoding="utf-8") as archivo:
            archivo.write(entrada + "\n")
        cola_bitacora.task_done()

def registrar(trama):
    fecha_hora = datetime.now().strftime("%d/%m/%y %H:%M:%S")
    linea = fecha_hora + ": " + json.dumps(trama)
    cola_bitacora.put(linea)

    