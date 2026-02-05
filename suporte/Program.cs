using System;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {

            var cliente1 = new Cliente(112233, "Tony", "Tony01@gmail.com");
            var tecnico1 = new Tecnico(334422, "Pietro", "Pietro@gmail.com");

            var categoria1 = new Categoria(009988, "Problema na internet");

            var chamadoservice1 = new ChamadoService();
        }
    }
}