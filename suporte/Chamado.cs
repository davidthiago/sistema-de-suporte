namespace Sistema{
class Chamado : IAtribuivel, IEncerravel {
    public int id;
    public string descricao;
    public string status;
    public string cliente;
    public string tecnico;
    public string categoria;

    public Chamado (int Id, string Descricao, string Cliente ){
        Id = id;
        Descricao = descricao;
        Cliente = cliente;
        Tecnico = Tecnico;
        Categoria = categoria;

    }
}

}