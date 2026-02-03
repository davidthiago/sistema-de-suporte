namespace Sistema{
    public class Cliente{
        public Cliente(int id, string nome, string email)
            : base(id, nome, email){
        }

        public override void ExibirDados(){
            Console.WriteLine("Cliente: " + Nome);
            Console.WriteLine("Email: " + Email);
        }

        public Chamado AbrirChamado(string titulo, string descricao, Categoria categoria, ChamadoService service){
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Descreva o problema");
            return service.CriarChamado(titulo, descricao, this, categoria);
        }
    }
}
