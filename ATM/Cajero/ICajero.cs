public interface ICajero
{


    void Retirar(int amount);
    void Ingresar(int amount);
    void CheckSaldo();
    void RgistrarUsuario(Usuario usuario);
    void EliminarUsuario(int id);

    Usuario GetUsuario();
}