public class ContaCorrente 
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo;

    public ContaCorrente(string Titular, int Agencia, int Numero)
    {
        this.Titular = Titular;
        this.Agencia = Agencia;
        this.Numero = Numero;
        Console.WriteLine("O titular da conta é " + this.Titular + ". A agência da conta é " + this.Agencia + ". O número da conta é " + this.Numero + ".");
    }

    public double deposita(double valor)
    {
        this.Saldo += valor;
        return this.Saldo;
    }

    public void saca(double valor)
    {
        if(valor <= this.Saldo ){
        this.Saldo -= valor;
    }
}
}