namespace Steam.DI
{
    using Microsoft.Practices.Unity;

    public static class Container
    {
        private static IUnityContainer _unityContainer;

        public static IUnityContainer UnityInstance
        {
            get
            {
                return Container._unityContainer;
            }
        }

        static Container()
        {
            Container.InitializeUnity();
        }

        public static T Resolve<T>()
        {
            return Container.UnityInstance.Resolve<T>();
        }

        public static void RegisterType<TInterface, TConcrete>() where TConcrete : TInterface
        {
            Container.UnityInstance.RegisterType<TInterface, TConcrete>();
        }

        private static void InitializeUnity()
        {
            Container._unityContainer = new UnityContainer();

            Container._unityContainer.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);
        }
    }
}