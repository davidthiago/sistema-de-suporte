namespace Sistema{
    public abstract class Usuario{
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        protected Usuario (int id, string nome, string email){
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
        }

        public abstract void ExibirDados();
    }
}