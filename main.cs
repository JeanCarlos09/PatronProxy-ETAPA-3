using System;
using System.Collections.Generic;
// Ejemplo de uso de la aplicación
public class Program
{
    public static void Main()
    {
        // Crear una instancia de la aplicación
        AplicacionEnvioPaquetes aplicacion = new AplicacionEnvioPaquetes();

        // Registrar un usuario
        aplicacion.RegistrarUsuario();

        // Iniciar sesión
        aplicacion.IniciarSesion();

        // Enviar un paquete
        aplicacion.EnviarPaquete();

        // Cerrar sesión
        aplicacion.CerrarSesion();
    }
}