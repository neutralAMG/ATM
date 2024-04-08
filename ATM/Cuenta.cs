public class Cuenta
{
    public Cuenta()
    {
        this.numCuenta = new Random().Next();
    }
    public int saldo { get; set; }

    public int numCuenta { get; set; }


}