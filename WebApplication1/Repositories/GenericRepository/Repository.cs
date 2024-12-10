using System.Data.Entity;
using WebApplication1.Data;

namespace WebApplication1.Repositories.GenericRepository

public class Repository<T> : IRepository<T> where T : class
{
    #region Ctor & Properties

    private readonly DbSet<T> _dbSet;   

    public Repository(ApplicationDbContext) : base(DbContext)
    {
        _dbSet = DbContext.Set<T>();
    }

    #endregion

}
