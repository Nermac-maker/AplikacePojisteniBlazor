namespace AplikacePojisteniBlazor.Data
{
    public class AppDbContextFactory : IAppDbContextFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AppDbContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public AppDbContext CreateDbContext()
        {
            return _serviceProvider.GetRequiredService<AppDbContext>();
        }
    }
}
