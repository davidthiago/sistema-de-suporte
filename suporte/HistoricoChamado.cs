namespace Sistema
{
    public class HistoricoChamado
    {
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public Status StatusAnterior;
        public HistoricoChamado(string descricao, Status statusAnterior)
        {
            Data = DateTime.Now;
            Descricao = descricao;
            this.StatusAnterior = statusAnterior;
        }
    }

}