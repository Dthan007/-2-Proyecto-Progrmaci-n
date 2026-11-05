import mysql.connector

class ConexionBD:
    def __init__(self, configuracion):
        self.configuracion = configuracion

    def obtener_conexion(self):
        return mysql.connector.connect(
            host=self.configuracion["host"],
            port=self.configuracion["port"],
            user=self.configuracion["user"],
            password=self.configuracion["password"],
            database=self.configuracion["database"],
        )

    def existe_cliente(self, identificacion):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()

        #cursor.callproc("sp_existe_cliente", [identificacion, 0])
        #resultado = next(cursor.stored_results())

        resultado = cursor.callproc("sp_existe_cliente", [identificacion, 0])
        existe = resultado[1]

        #existe = resultado.fetchone()[0]

        cursor.close()
        conexion.close()
        return bool(existe)

    def insertar_cliente(self, cliente):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        cursor.callproc(
            "sp_insertar_cliente",
            [
                cliente["identificacion"],
                cliente["pais_origen"],
                cliente["nombre"],
                cliente["primer_apellido"],
                cliente["segundo_apellido"],
                cliente["correo_electronico"],
                cliente["telefono"],
                cliente["direccion"],
            ],
        )
        conexion.commit()
        cursor.close()
        conexion.close()

    def actualizar_cliente(self, cliente):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        cursor.callproc(
            "sp_actualizar_cliente",
            [
                cliente["identificacion"],
                cliente["pais_origen"],
                cliente["nombre"],
                cliente["primer_apellido"],
                cliente["segundo_apellido"],
                cliente["correo_electronico"],
                cliente["telefono"],
                cliente["direccion"],
            ],
        )
        conexion.commit()
        cursor.close()
        conexion.close()

    def tiene_facturas(self, identificacion):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        resultado = cursor.callproc("sp_tiene_facturas", [identificacion, 0])
        tiene = resultado[1]
        cursor.close()
        conexion.close()
        return bool(tiene)

    def borrar_cliente(self, identificacion):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        cursor.callproc("sp_borrar_cliente", [identificacion])
        conexion.commit()
        cursor.close()
        conexion.close()


#Funciones para Verificador2
    def existe_compra(self, numero_compra):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        resultado = cursor.callproc("sp_existe_compra", [numero_compra, 0])
        existe = resultado[1]
        cursor.close()
        conexion.close()
        return bool(existe)

    def insertar_compra(self, compra, estado):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        cursor.callproc(
            "sp_insertar_compra",
            [
                compra["numero_compra"],
                compra["identificacion_cliente"],
                compra["fecha_compra"],
                compra["total_compra"],
                compra["tarjeta_cifrada"],
                compra["vencimiento_cifrado"],
                compra["cvv_cifrado"],
                estado,
            ]
        )
        conexion.commit()
        cursor.close()
        conexion.close()

    def insertar_detalle_compra(self, numero_compra, producto):
        conexion = self.obtener_conexion()
        cursor = conexion.cursor()
        cursor.callproc(
            "sp_insertar_detalle_compra",
            [
                numero_compra,
                producto["codigo_producto"],
                producto["cantidad"],
            ],
        )
        conexion.commit()
        cursor.close()
        conexion.close()
#----------------------------------------------------------------------------------