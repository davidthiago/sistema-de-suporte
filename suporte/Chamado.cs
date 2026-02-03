namespace Sistema{
    public class Chamado : IAtribuivel, IEncerravel{
        public int Id;
        public string Descricao;
        public Status Status;
        public Cliente Cliente;
        public Tecnico Tecnico;
        public Categoria Categoris;
        
        //Quaqlq coisa tira o get private
        public List<HistoricoChamado> Historico { get; private set; }
        public Chamado (int id, string descricao, Cliente cliente, Categoria categoria){
            Id = id;
            Descricao = descricao;
            Cliente = cliente;
            Categoria = categoria;
            Status = Status.Abertp;
            Historico = new List<HistoricoChamado>();
        }
        public void AdicionarHistorico (string descricao){
            Historico.Add(new HistoricoChamado(descricao));
        }
        public void SetStatus (Status status){
            Status = status;
        }
        public void AtribuirTecnico (Tecnico tecnico){
            Tecnico = tecnico;
            SetStatus(Status.EmAndamento);
        }
        public void Encerrar(){
            SetStatus(Status.Emcerrado);
        }
        public Tecnico GetTecnico(){
            return Tecnico;
        }
    }
}
