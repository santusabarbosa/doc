namespace Saudador.Infraestrutura
{
    using Saudador.Dominio.Entidades;
    using Saudador.Dominio.Infraestrutura;
    using System;

    public class SaudadorMomentoDoDia : ISaudador
    {
        private readonly TimeSpan madrugada = new TimeSpan(6, 0, 0);

        private readonly TimeSpan manha = new TimeSpan(12, 0, 0);

        private readonly TimeSpan tarde = new TimeSpan(18, 0, 0);

        public void Sauda(Individuo individuo)
        {
            var agora = DateTime.Now.TimeOfDay;

            string saudacao;
            if (agora < madrugada)
                saudacao = "{0}, é madrugada!";
            else if (agora < manha)
                saudacao = "Bom dia, {0}.";
            else if (agora < tarde)
                saudacao = "Boa tarde, {0}.";
            else
                saudacao = "Boa noite, {0}.";

            Console.WriteLine(saudacao, individuo.Nome);
        }
    }
}
