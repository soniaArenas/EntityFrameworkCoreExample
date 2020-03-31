using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context
{
   public interface IContextDb
    {
        DbSet<Song> Songs { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesSuccess, CancellationToken cancellationToken = default);



    }
}
