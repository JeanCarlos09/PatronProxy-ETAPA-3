using System;
using System.Collections.Generic;

// Implementación real del servicio de envío de paquetes
public class ServicioEnvioPaquetes : IServicioEnvioPaquetes
{
    public void EnviarPaquete()
    {
    // Definición de algunas cadenas para simplificar las opciones de entrada.
      string desea = "si";
      string nodesea = "no";
      string Desea = "1";
      string Nodesea = "2";
      
      // Mostrar opciones al usuario.
      Console.WriteLine("Desea enviar paquete:");
      Console.WriteLine("1. si");
      Console.WriteLine("2. no");
      
      // Leer la respuesta del usuario.
      string propuesta = Console.ReadLine();
      
      // Verificar si el usuario desea enviar el paquete.
      if (propuesta == desea || propuesta == Desea){
      
      // Solicitar detalles del destinatario.
      Console.WriteLine("Enviar paquete a : ");
      Console.WriteLine("Ingrese el nombre del destinatorio");
      string nombreDestinatorio = Console.ReadLine();
      Console.WriteLine("Ingrese la dirección del destinatorio");
      string direccionDestinatario = Console.ReadLine();

      // Simular el envío exitoso.
      Console.WriteLine("Envio exitoso ");
        }
    }
}
