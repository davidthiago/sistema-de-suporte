namespace Sistema
{
    public class HistoricoChamado
    {
        public DateTime Data;
        public string Descricao; 
        public Status StatusAnterior;
        public HistoricoChamado(string descricao, Status statusAnterior)
        {
            Data = DateTime.Now;
            Descricao = descricao;
            this.StatusAnterior = statusAnterior;
        }
    }

}