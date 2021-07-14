using Microsoft.EntityFrameworkCore;
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

    }
}
