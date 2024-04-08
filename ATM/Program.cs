// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cajero cajero = new Cajero();
var funciona = true;
while (funciona)
{
    while (cajero.CurrentUser != null)
    {
        string opcion;


        Console.WriteLine(@"
        Que decea hacer ahora:
        1. Checkear saldo
        2. Ingresar saldo
        3. Retirar saldo
        4. Borrar cuenta
        5. Salir
        ");
        opcion = Console.ReadLine();

        if (opcion.Equals("1"))
        {
            cajero.CheckSaldo();
        }
        else if (opcion.Equals("2"))
        {

            int monto;
            Console.WriteLine(" Cuanto desea ingresar a su cuenta");
            int.TryParse(Console.ReadLine(), out monto);
            cajero.Ingresar(monto);
        }
        else if (opcion.Equals("3"))
        {
            int monto;
            Console.WriteLine(" Cuanto desea retirar a su cuenta");
            int.TryParse(Console.ReadLine(), out monto);
            cajero.Retirar(monto);
        }
        else if (opcion.Equals("4"))
        {
            cajero.EliminarUsuario(cajero.CurrentUser.id);

        }
        else if (opcion.Equals("5"))
        {
            cajero.CurrentUser = null;
        }
        else
        {
            Console.WriteLine("Opcion no valida ingresada");
            Console.ReadLine();
        }

    }

    string Opcion;
    Console.WriteLine(@"
        Que decea hacer ahora:
        1. Registrar Usuario
        2. Login a Usuario
        3. Salir
        ");
    Opcion = Console.ReadLine();

    if (Opcion.Equals("1"))
    {
        Console.WriteLine(" Ingrese su nombre");
        string nombre = Console.ReadLine();

        Console.WriteLine(" Ingrese su contrasena");
        string contrasena = Console.ReadLine();

        Console.WriteLine(" Ingrese su email");
        string email = Console.ReadLine();

        cajero.RgistrarUsuario(new Usuario
        {
            nombre = nombre,
            contrasena = contrasena,
            Email = email,

        });
    }
    else if (Opcion.Equals("2"))
    {
        cajero.GetUsuario();
    }
    else if (Opcion.Equals("3"))
    {
        Console.WriteLine("Gracias por usar mi programa");
        funciona = false;
        break;
    }
    else
    {
        Console.WriteLine("Opcion no valida ingresada");
        Console.ReadLine();
    }


}
