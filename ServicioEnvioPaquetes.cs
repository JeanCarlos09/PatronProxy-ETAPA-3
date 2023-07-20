using System;
using System.Collections.Generic;

// Implementación real del servicio de envío de paquetes
public class ServicioEnvioPaquetes : IServicioEnvioPaquetes
{
    public void EnviarPaquete()
    {
      string desea = "si";
      string nodesea = "no";
      string Desea = "1";
      string Nodesea = "2";
      Console.WriteLine("Desea enviar paquete:");
      Console.WriteLine("1. si");
      Console.WriteLine("2. no");
      string propuesta = Console.ReadLine();
      if (propuesta == desea || propuesta == Desea){
      Console.WriteLine("Enviar paquete a : ");
      Console.WriteLine("Ingrese el nombre del destinatorio");
      string nombreDestinatorio = Console.ReadLine();
      Console.WriteLine("Ingrese la dirección del destinatorio");
      string direccionDestinatario = Console.ReadLine();
      Console.WriteLine("Envio exitoso ");
        }
    }
}