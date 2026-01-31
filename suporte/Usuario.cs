public abstract class Usuario : Cliente {
    public int id;
    public string nome; 
    public string email; 

        public Usuario (int newId, string newNome , string newEmail){
            this.id = Newid;
            this.nome = Newnome;  
            this.email = Newemail;
        }         

    public abstract void ExibirDados();
}

