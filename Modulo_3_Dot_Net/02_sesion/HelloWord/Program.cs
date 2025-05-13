using System;
using System.Text;

class Program 
{
    private static Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        {"admin","admin"},
        {"usaurio", "pass"},
        {"test", "test"}
    };

    private const int MAX_RETRIES = 3;


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
        string? usuario = TryLogin();

        if(usuario != null)
        {
            Console.WriteLine ($"Hola {usuario}");
        }else{
            Console.WriteLine("Has axcedido el número máximo de intentos");
        }

        Console.WriteLine("Presiona Enter para salir");
        Console.ReadLine();

        
 //       Console.WriteLine ("Escribe tu contraseña");
  //      string? pass = ReadPassword();   
    }
        /*
        TODO:
            Número máximo de intento
            Lea la contraseña sin mostrarla
            Mostrar info del usuario loggeado
        */  

    private static string? TryLogin()
    {
        int intentoRestante = MAX_RETRIES;
         while(intentoRestante > 0)
         {
            Console.WriteLine($"\nIntentos restantes: {intentoRestante}");
            Console.Write("Ingresa tu usuario: ");
            string? userLogged = Console.ReadLine();
            Console.WriteLine("Escribe tu contraseña");
            string? pass = ReadPassword();


            if (string.IsNullOrWhiteSpace(userLogged) || string.IsNullOrWhiteSpace(pass))
            {
                Console.WriteLine("\nError: El usuario y contraseña no pueden estar vacios");
                intentoRestante--;
                continue;
            }

            if(usuarios.ContainsKey(userLogged) && usuarios[userLogged] == pass){
                Console.WriteLine("\nAcceso concedido!!");
                return userLogged;
            }else{
                Console.WriteLine("Contraseña y/o usuario incorrecto");
                Console.WriteLine("\nIntentalo de nuevo");
                intentoRestante--;

            }

            
            
         }

         return null;
    }

    private static string? ReadPassword()
    {
        StringBuilder password = new StringBuilder();
        ConsoleKeyInfo keyInfo;
        
        do{
            keyInfo = Console.ReadKey(true);

            if (!char.IsControl(keyInfo.KeyChar))
            {
                password.Append(keyInfo.KeyChar);
                Console.Write("*");

            }
            else if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password.Remove(password.Length - 1, 1);
                Console.Write("\b \b");
            }   

        }while(keyInfo.Key != ConsoleKey.Enter);

        Console.WriteLine();
        
        return password.ToString();

    }

}