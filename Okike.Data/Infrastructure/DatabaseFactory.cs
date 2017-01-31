using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;


namespace Okike.Data.Infrastructure
{
    public class DatabaseFactory : Disposable , IDatabaseFactory
    {
        private DbContext _dbContext;


        public DbContext Get()
        {
            return _dbContext ?? (_dbContext = new ApplicationDbContext());
        }


        public override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
                
        }
    }
}
