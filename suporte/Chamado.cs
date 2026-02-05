namespace Sistema{
    public class Chamado : IAtribuivel, IEncerravel{
        public int Id;
        public string Descricao;
        public Status Status;
        public Cliente Cliente;
        public Tecnico? Tecnico;
        public Categoria Categoria;

        public List<HistoricoChamado> Historico { get; private set; }

        public Chamado(int id, string descricao, Cliente cliente, Categoria categoria){
            Id = id;
            Descricao = descricao;
            Cliente = cliente;
            Categoria = categoria;
            Status = Status.ABERTO;
            Historico = new List<HistoricoChamado>();
        }

        public void AdicionarHistorico(string descricao){
            Historico.Add(new HistoricoChamado(descricao));
        }

        private void SetStatus(Status status){
            Status = status;
        }

        public void AtribuirTecnico(Tecnico tecnico){
            Tecnico = tecnico;
            SetStatus(Status.EM_ANDAMENTO);
        }

        public void Encerrar(){
            SetStatus(Status.ENCERRADO);
        }

        public Tecnico? GetTecnico(){
            return Tecnico;
        }
    }
}
