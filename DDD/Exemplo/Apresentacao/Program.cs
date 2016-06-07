namespace Saudador.Apresentacao
{
    using Saudador.Dominio.Entidades;
    using Saudador.Dominio.InjecaoDependencia;
    using Saudador.InjecaoDependencia;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Injeta o resolvedor de dependência no domínio.
            Dependencias.Resolvedor = new Resolvedor();

            // Lê o nome do usuário
            var nome = LeNome();

            // Instanciando a entidade do domínio
            var individuo = new Individuo(nome);

            // Disparando a ação no domínio
            individuo.FazSaudacao();

            // Esperando uma tecla para sair
            Console.ReadKey();
        }

        private static string LeNome()
        {
            for (; ; )
            {
                Console.WriteLine("Qual o seu nome?");

                var nome = Console.ReadLine();

                if (nome == string.Empty)
                {
                    Console.WriteLine("Entre com seu nome!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    return nome;
                }
            }
        }
    }
}
