public class Cliente{
    public Cliente(int id, string nome, string email)
        : base(id, nome, email){
    }

    public override void ExibirDados(){
        Console.WriteLine("Cliente: " + Nome);
        Console.WriteLine("Email: " + Email);
    }
}
