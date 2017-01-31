using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Data.Infrastructure
{
    public interface IDatabaseFactory
    {
        DbContext Get();
    }
}
