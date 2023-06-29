using MVC_Practical_11_Partial_View.DAL;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVC_Practical_11_Partial_View
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IUserDataAccess, UserDataAccess>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}