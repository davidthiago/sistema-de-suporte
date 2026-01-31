class Chamado : IAtribuivel, IEncerravel {
    public int id;
    public string descricao;
    public status status;
    public Cliente cliente;
    public Tecnico tecnico;
    public Categoria categoria; 

    public Chamado (int Id, string Descricao, string Cliente ){
        this.id = Id;
        this.descricao = Descricao;
        this.cliente = Cliente;
        this.tecnico = Tecnico;
        this.categoria = categoria;
    }

    public AdicionarHistorico (string descricao){

    }

    public SetStatus ()
}