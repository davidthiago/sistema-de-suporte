public abstract class Usuario {
    public int id {get; protected set;}
    public string nome {get; protected set;}
    public string email {get; protected set;}

        protected Usuario (int id, string nome , string email){
            Id = id;
            Nome = nome;
            Email = email;  
        }         

    public abstract void ExibirDados();
}

