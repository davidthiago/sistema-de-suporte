namespace Sistema
{
    public class HistoricoChamado
    {
        public DateTime Data;
        public string Descricao; 
        Status StatusAnterior;

        HistoricoChamado(string descricao, Status statusAnterior)
        {
            this.Data = DateTime.Now;
            this.Descricao = descricao;
            this.StatusAnterior = statusAnterior;
        }

        public HistoricoChamado(string descricao)
        {
            this.Data = DateTime.Now;
            this.Descricao = descricao;
        }
    }

}