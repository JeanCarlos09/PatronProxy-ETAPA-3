using System;
using System.Collections.Generic;
// Clase principal que utiliza la aplicación
public class AplicacionEnvioPaquetes
{
    private ProxyServicioEnvioPaquetes proxy;
    
    // El constructor crea una instancia del objeto ProxyServicioEnvioPaquetes
    // para poder utilizar sus métodos.
    public AplicacionEnvioPaquetes()
    {
        proxy = new ProxyServicioEnvioPaquetes();
    }

    // Este método invoca el método "RegistrarUsuario" del objeto proxy,
    // que se encarga de registrar un nuevo usuario en el servicio de envío de paquetes.
    public void RegistrarUsuario()
    {
        proxy.RegistrarUsuario();
    }

    // Este método invoca el método "IniciarSesion" del objeto proxy,
    // que se utiliza para iniciar sesión en el servicio de envío de paquetes.
    public void IniciarSesion()
    {
        proxy.IniciarSesion();
    }

    // Este método invoca el método "CerrarSesion" del objeto proxy,
    // que se utiliza para cerrar la sesión en el servicio de envío de paquetes.
    public void CerrarSesion()
    {
        proxy.CerrarSesion();
    }

    // Este método invoca el método "EnviarPaquete" del objeto proxy,
    // que se utiliza para enviar un paquete a través del servicio de envío de paquetes.
    public void EnviarPaquete()
    {
        proxy.EnviarPaquete();
    }
}

