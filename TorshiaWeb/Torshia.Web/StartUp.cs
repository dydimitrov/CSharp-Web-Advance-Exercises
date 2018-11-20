namespace Torshia.Web
{
    using SIS.Framework.Api;
    using SIS.Framework.Services;
    using Torshia.Data;
    using Torshia.Services;
    using Torshia.Services.Contracts;

    public class StartUp : MvcApplication
    {
        public override void ConfigureServices(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterDependency<IUserService, UserService>();
            dependencyContainer.RegisterDependency<TorshiaContext, TorshiaContext>();
            dependencyContainer.RegisterDependency<ITasksService, TasksService>();
            dependencyContainer.RegisterDependency<IReportService, ReportService>();

        }
    }
}