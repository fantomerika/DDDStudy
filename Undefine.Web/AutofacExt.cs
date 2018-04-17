using Autofac;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Undefine.App;
using Undefine.Domain.IRepository;
using Undefine.Repository;
using Undefine.Repository.Repositories;

namespace Undefine.Web
{
    public class AutofacExt
    {
        private static Autofac.IContainer _container;

        public static void InitAutofac()
        {
            var builder = new ContainerBuilder();

            //注册数据库基础操作和工作单元
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IRepository<>));
            builder.RegisterType(typeof(EFUnitOfWork)).As(typeof(IUnitOfWork));

            //注册app层
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(UserManagerApp)));

            //注册领域服务
            //builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(AuthoriseService)))
            //    .Where(u => u.Namespace == "OpenAuth.Domain.Service"
            //    || u.Namespace == "OpenAuth.Domain.Interface");

            //注册Repository
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(Sys_UserRepository)))
                .AsImplementedInterfaces();

            // 注册controller，使用属性注入
            //builder.register .RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            //builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            //builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            //builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            //builder.RegisterSource(new ViewRegistrationSource());

            // 注册所有的Attribute
            //builder.RegisterFilterProvider();

            // Set the dependency resolver to be Autofac.
            _container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(_container));
        }

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetFromFac<T>()
        {
            return _container.Resolve<T>();
            //   return (T)DependencyResolver.Current.GetService(typeof(T));
        }
    }
}
