namespace Sistema
{
    public class Tecnico : Usuario
    {
        public Tecnico(int id, string nome, string email)
            : base(id, nome, email)
        {
        }
        public void ExibirDados()
        {
            Console.WriteLine("Tecnico: " + Nome);
            Console.WriteLine("Email: " + Email);
        }
        public void MudarStatus(Chamado chamado, Status novoStatus)
        {
            // Não é possível mudar se já estiver encerrado
            if (chamado.Status == Status.ENCERRADO)
            {
                throw new Exception("Chamado já foi encerrado.");
            }
            // Muda o status
            chamado.Status = novoStatus;

        }
    }
}