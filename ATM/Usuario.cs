public class Usuario
{
    public Usuario()
    {
        this.cuenta = new Cuenta();
        id = new Random().Next();
    }
    public string? nombre { get; set; }
    public string? contrasena { get; set; }
    public string? Email { get; set; }
    public int id { get; set; }
    public Cuenta cuenta { get; set; }

}