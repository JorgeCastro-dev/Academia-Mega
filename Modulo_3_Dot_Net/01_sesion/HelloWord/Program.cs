using System;
using System.Diagnostics.Contracts;

class Program 
{
    private static Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        {"admin","admin"},
        {"usaurio", "pass"},
        {"test", "test"}
    };


    static void Main(string[] args )
    {
        // Mensaje de bienvenida
        Console.WriteLine ("Este es el programa oficial del Hola mundo");
        Console.WriteLine ("Tienes que iniciar sesion");

/*        //Definimos el usuario y contraseña
        string usuarioCorrecto = "admin";
        string passCorrecta = "qwerty";
*/


        Console.WriteLine ("Escribe tu usuario");
        string? usuario = Console.ReadLine();
        
        Console.WriteLine ("Escribe tu contraseña");
        string? pass = Console.ReadLine();

        if(usuario != null && pass != null)
        {
            if(usuarios.ContainsKey(usuario) && (usuarios[usuario] == pass))
            {
                    Console.WriteLine ("Bienvenido " + usuario);
                    for (int i = 1; i <= 50; i++)
                        {
                            Console.WriteLine($"{i} Hola {usuario}  Bienvenido");
                        }
                    Console.WriteLine("\n Presiona Enter para salir del programa...");
                    Console.ReadLine();
                    
            }
            else
                {
                    Console.WriteLine("Usuario o contraseña incorrecta.");
                    Console.WriteLine("\n Presiona Enter para salir del programa...");
                    Console.ReadLine();
                }
            }
    }

}