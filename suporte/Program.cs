using System;

namespace Sistema{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("iniciado");

            var cliente1 = new Cliente(112233, "Tony", "Tony01@gmail.com");
            var tecnico1 = new Tecnico(334422, "Pietro", "Pietro@gmail.com");
            var categoria1 = new Categoria(9988, "Problema na internet");

            Console.WriteLine("Coisa criada com sucesso");
        }
    }
}
