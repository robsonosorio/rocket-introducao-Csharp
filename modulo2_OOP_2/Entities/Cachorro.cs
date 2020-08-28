
using modulo2_OOP_2.Entities.Enums;

namespace modulo2_OOP_2.Entities
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base (nome, idade)
        {
        }

        public override Som SomEmitido => Som.Latido;
    }
}
