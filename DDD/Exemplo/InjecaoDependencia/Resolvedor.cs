namespace Saudador.InjecaoDependencia
{
    using Microsoft.Practices.Unity;
    using Saudador.Dominio.Infraestrutura;
    using Saudador.Dominio.InjecaoDependencia;
    using Saudador.Infraestrutura;

    public class Resolvedor : IResolvedor
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public Resolvedor()
        {
            _container.RegisterType<ISaudador, SaudadorMomentoDoDia>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
