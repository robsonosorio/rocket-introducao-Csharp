using modulo2_OOP_2.Entities.Enums;

namespace modulo2_OOP_2.Entities
{
    public abstract class Animal
    {
        public string Nome { get; }
        public int Idade { get; }
        public abstract Som SomEmitido { get; }
        public virtual string Locomocao { get { return "Está andando"; } }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
