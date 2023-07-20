using System;
using System.Collections.Generic;
// Proxy del servicio de envío de paquetes
public class ProxyServicioEnvioPaquetes : IServicioEnvioPaquetes
{
    private ServicioEnvioPaquetes servicioReal;
    private Dictionary<string, string> usuariosRegistrados;
    private string usuarioActual;
    
    // Constructor que inicializa el objeto del servicio real y otras variables necesarias.
    public ProxyServicioEnvioPaquetes()
    {
        servicioReal = new ServicioEnvioPaquetes();
        usuariosRegistrados = new Dictionary<string, string>();
        usuarioActual = string.Empty;
    }

    // Método que permite enviar un paquete. Antes de llamar al servicio real, se verifica
    // si hay una sesión iniciada para el usuario actual.
    public void EnviarPaquete()
    {
        // Verificar si el usuario ha iniciado sesión
        if (SesionIniciada())
        {
            // Si ha iniciado sesión, permitir el envío del paquete
            servicioReal.EnviarPaquete();
        }
        else
        {
            Console.WriteLine("Debe iniciar sesión para utilizar esta función.");
        }
    }

    // Método para registrar a un nuevo usuario en el sistema.
    public void RegistrarUsuario()
    {
        // Código para obtener los datos del nuevo usuario y agregarlo al diccionario
        // de usuarios registrados.
        
        Console.WriteLine("----- Registro de Usuario -----");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su cédula: ");
        string cedula = Console.ReadLine();

        Console.Write("Ingrese su número de celular: ");
        string celular = Console.ReadLine();

        Console.Write("Ingrese su correo electrónico: ");
        string correo = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        // Aquí se puede implementar la lógica de registro de usuario
        usuariosRegistrados[correo] = contrasena;
        Console.WriteLine("Usuario registrado con éxito.");
    }

    // Método para iniciar sesión en el sistema.
    public void IniciarSesion()
    {
        // Código para obtener las credenciales de inicio de sesión y verificar si coinciden
        // con las credenciales de algún usuario registrado en el diccionario.
        
        Console.WriteLine("----- Inicio de Sesión -----");
        Console.Write("Ingrese su correo electrónico: ");
        string correo = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        // Validar las credenciales de inicio de sesión
        if (usuariosRegistrados.ContainsKey(correo) && usuariosRegistrados[correo] == contrasena)
        {
            // Iniciar sesión exitosamente
            usuarioActual = correo;
            Console.WriteLine("Sesión iniciada con éxito.");
        }
        else
        {
            Console.WriteLine("Credenciales de inicio de sesión inválidas.");
        }
    }

    // Método para cerrar la sesión del usuario actual.
    public void CerrarSesion()
    {
        // Cerrar la sesión actual
        usuarioActual = string.Empty;
        Console.WriteLine("Sesión cerrada.");
    }

    // Método privado que verifica si hay una sesión iniciada para el usuario actual.
    private bool SesionIniciada()
    {
        // Verificar si hay una sesión iniciada
        return !string.IsNullOrEmpty(usuarioActual);
    }
}
