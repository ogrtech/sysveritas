using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

/// <summary>
/// Descripción breve de Salt
/// </summary>
public class Salt
{
    public Salt()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static byte[] GenerateSalt()
    {
        RNGCryptoServiceProvider rncCsp = new RNGCryptoServiceProvider();
        //        byte[] salt = new byte[SaltByteLength];
        byte[] salt = new byte[32];
        rncCsp.GetBytes(salt);

        return salt;
    }
}