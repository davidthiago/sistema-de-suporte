public abstract class Usuario : Cliente {
    public int id;
    public string nome; 
    public string email; 

        public Usuario (int newId, string newNome , string newEmail){
            Newid = id;
            newNome = nome;
            newEmail = email;  
        }         

    public abstract void ExibirDados();
}

