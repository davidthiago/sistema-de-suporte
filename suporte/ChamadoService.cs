namespace Sistema
{

    class ChamadoService
    {
        private List<Chamado> chamados { get; set; }

        public ChamadoService()
        {
            chamados = new List<Chamado>();
        }

        public Chamado AbrirChamado(Cliente cliente, Categoria categoria, string descricao)
        {
            int novoId = chamados.Count + 1;
            Chamado novoChamado = new Chamado(novoId, descricao, cliente, categoria);
            chamados.Add(novoChamado);
            return novoChamado;
        }

        public List<Chamado> ListarPorStatus(Status status)
        {
            return chamados.Where(c => c.Status == status).ToList();
        }

        public List<Chamado> ListarPorTecnico (Tecnico tecnico)
        {
             return chamados.Where(c => c.Tecnico == tecnico).ToList();
        }

        internal Chamado CriarChamado(string titulo, string descricao, Cliente cliente, Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}