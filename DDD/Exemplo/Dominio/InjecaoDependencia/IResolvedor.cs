namespace Saudador.Dominio.InjecaoDependencia
{
    public interface IResolvedor
    {
        T Resolve<T>();
    }
}
