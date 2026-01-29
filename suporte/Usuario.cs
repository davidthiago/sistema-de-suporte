public abstract class Usuario : Cliente {
    public int id 
    public string nome 
    public string email 

        public Usuario (int id, string nome , string email){
            Id = id;
            Nome = nome;
            Email = email;  
        }         

    public abstract void ExibirDados();
}

