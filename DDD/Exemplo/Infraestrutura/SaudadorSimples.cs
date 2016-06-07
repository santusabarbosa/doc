namespace Saudador.Infraestrutura
{
    using Saudador.Dominio.Entidades;
    using Saudador.Dominio.Infraestrutura;
    using System;

    public class SaudadorSimples : ISaudador
    {
        public void Sauda(Individuo individuo)
        {
            Console.WriteLine("Olá {0}.", individuo.Nome);
        }
    }
}
