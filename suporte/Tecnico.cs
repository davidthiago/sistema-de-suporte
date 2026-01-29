public class Tecnico : Usuario{
    public Tecnico(int id, string nome, string email)
        : base(id, nome, email){
    }

    public void ExibirDados(){
        Console.WriteLine("Tecnico: " + Nome);
        Console.WriteLine("Email: " + Email);
    }
}
