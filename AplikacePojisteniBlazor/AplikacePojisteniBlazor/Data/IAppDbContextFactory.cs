namespace AplikacePojisteniBlazor.Data
{
    public interface IAppDbContextFactory
    {
        AppDbContext CreateDbContext();

    }
}
