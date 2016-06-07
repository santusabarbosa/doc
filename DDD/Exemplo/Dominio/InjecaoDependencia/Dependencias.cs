namespace Saudador.Dominio.InjecaoDependencia
{
    public static class Dependencias
    {
        private static IResolvedor _resolvedor;

        public static IResolvedor Resolvedor
        {
            get
            {
                if (_resolvedor == null)
                    throw new ResolvedorNaoConfiguradoException();

                return _resolvedor;
            }

            set
            {
                _resolvedor = value;
            }
        }
    }
}
