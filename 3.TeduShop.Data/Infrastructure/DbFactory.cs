using System;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }

    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext dbContext;

        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}