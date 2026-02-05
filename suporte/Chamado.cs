namespace Sistema{
    public class Chamado : IAtribuivel, IEncerravel{
        public int Id;
        public string Descricao;
        public Status Status;
        public Cliente Cliente;
        public Tecnico Tecnico;
        public Categoria Categoria;

        //Quaqlq coisa tira o get private
        public List<HistoricoChamado> Historico { get; private set; }
        public Chamado(int id, string descricao, Cliente cliente, Categoria categoria){
            this.Id = id;
            this.Descricao = descricao;
            this.Cliente = cliente;
            this.Categoria = categoria;
            this.Status = Status.ABERTO;
            Historico = new List<HistoricoChamado>();
        }
        public void AdicionarHistorico(string descricao){
            Historico.Add(new HistoricoChamado(descricao));
        }
        void SetStatus(Status status){
            Status = status;
        }
        public void AtribuirTecnico(Tecnico tecnico){
            this.Tecnico = tecnico;
            SetStatus(Status.EM_ANDAMENTO);
        }
        public void Encerrar(){
            SetStatus(Status.EM_ANDAMENTO);
        }
        public Tecnico GetTecnico(){
            return Tecnico;
        }
    }
}
