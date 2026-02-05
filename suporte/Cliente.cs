using System;

namespace Sistema{
    public class Cliente : Usuario{
        public Cliente(int id, string nome, string email)
            : base(id, nome, email){
        }
        public override void ExibirDados(){
            Console.WriteLine("Cliente: " + Nome);
            Console.WriteLine("Email: " + Email);
        }
        Chamado AbrirChamado(
            string titulo,
            string descricao,
            Categoria categoria,
            ChamadoService service)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new Exception("fale o problema");

            return service.CriarChamado(titulo, descricao, this, categoria);
        }
    }
}