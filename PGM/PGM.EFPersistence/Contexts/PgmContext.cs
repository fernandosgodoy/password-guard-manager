using Microsoft.EntityFrameworkCore;
using PGM.EFPersistence.Configurations;
using PGM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGM.EFPersistence.Contexts
{
    public class PgmContext
        : DbContext
    {

        #region DbSets

        public DbSet<AccountInfo> Accounts { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<AccountInfo>(new AccountInfoConfiguration());
        }

    }
}
