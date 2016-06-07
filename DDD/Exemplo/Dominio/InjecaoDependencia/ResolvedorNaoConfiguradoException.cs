namespace Saudador.Dominio.InjecaoDependencia
{
    using System;

    public class ResolvedorNaoConfiguradoException : Exception
    {
        public ResolvedorNaoConfiguradoException() :
            base(string.Format("Nenhuma instância de \"{0}\" foi configurada no domínio.", typeof(IResolvedor).Name)) { }
    }
}
