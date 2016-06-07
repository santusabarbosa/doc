namespace Saudador.Dominio.Entidades
{
    using Saudador.Dominio.Infraestrutura;
    using Saudador.Dominio.InjecaoDependencia;

    public class Individuo
    {
        public Individuo(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public void FazSaudacao()
        {
            Dependencias.Resolvedor.Resolve<ISaudador>().Sauda(this);
        }
    }
}
