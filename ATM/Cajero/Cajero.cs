public class Cajero : ICajero
{
    public Cajero()
    {
        users =
        [
            new Usuario
            {
                nombre = "A",
                contrasena = "B",
                Email = "C"
            },
        ];
    }
    private List<Usuario> users;

    public Usuario? CurrentUser = null;


    public void Retirar(int amount)

    {
        try
        {
            if (amount == 0 || amount < 0) return;
            if (amount > CurrentUser.cuenta.saldo)
            {
                Console.WriteLine($"No se puede retirar mas de lo que tiene");
                return;
            }
            CurrentUser.cuenta.saldo -= amount;

            Console.WriteLine($"El saldo actual del cliente es de: {CurrentUser.cuenta.saldo} pesos");
            Console.ReadLine();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Ingresar(int amount)
    {
        try
        {
            if (amount == 0 || amount < 0) return;
            CurrentUser.cuenta.saldo += amount;
            Console.WriteLine($"El saldo actual del cliente es de: {CurrentUser.cuenta.saldo} pesos");
            Console.ReadLine();
        }
        catch (System.Exception)
        {

            throw;
        }

    }

    public void CheckSaldo()
    {
        var Saldo = CurrentUser.cuenta.saldo;
        try
        {

            Console.WriteLine($"El saldo del cliente es de: {Saldo} pesos");
            Console.ReadLine();
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public void RgistrarUsuario(Usuario usuario)
    {
        try
        {
            if (users.Any(cd => cd.nombre == usuario.nombre))
            {
                Console.WriteLine("El usuario ya existe");
                return;
            }

            users.Add(usuario);
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public void EliminarUsuario(int id)
    {
        var usuarioDeleted = new Usuario();
        try
        {
            usuarioDeleted = users.Find(cd => cd.id == id);
            if (usuarioDeleted is null)
            {
                Console.WriteLine("Usuario no existe o id ingraesada erroneamente");
                return;
            };

            users.Remove(usuarioDeleted);
            Console.WriteLine("Usuario Eliminado con exito");
            CurrentUser = null;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Error borrando el usuario");
            throw;
        }

    }

    public Usuario GetUsuario()
    {

        var usuario = new Usuario();
        Console.WriteLine("Ingrese el usuario a manejar");

        var nombre = Console.ReadLine();
        var contrasena = Console.ReadLine();
        try
        {
            usuario = users.Find(cd => cd.nombre == nombre.Trim() && cd.contrasena == contrasena.Trim());
            if (usuario is null)
            {
                Console.WriteLine("El usuario no ha sido encontrado");
                return CurrentUser = null;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("El usuario no ha sido encontrado");
            throw;
        }
        CurrentUser = usuario;
        Console.WriteLine($"Bienvenido {CurrentUser.nombre}");
        return CurrentUser;
    }
}