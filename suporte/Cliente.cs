public class Cliente : Usuario{
    public Cliente(int id, string nome, string email)
        : base(id, nome, email){
    }

    public override void ExibirDados(){
        Console.WriteLine("liente: " + Nome);
        Console.WriteLine("Email: " + Email);
    }
}
