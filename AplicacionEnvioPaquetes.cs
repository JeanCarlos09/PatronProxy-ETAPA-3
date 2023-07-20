using System;
using System.Collections.Generic;
// Clase principal que utiliza la aplicación
public class AplicacionEnvioPaquetes
{
    private ProxyServicioEnvioPaquetes proxy;

    public AplicacionEnvioPaquetes()
    {
        proxy = new ProxyServicioEnvioPaquetes();
    }

    public void RegistrarUsuario()
    {
        proxy.RegistrarUsuario();
    }

    public void IniciarSesion()
    {
        proxy.IniciarSesion();
    }

    public void CerrarSesion()
    {
        proxy.CerrarSesion();
    }

    public void EnviarPaquete()
    {
        proxy.EnviarPaquete();
    }
}

