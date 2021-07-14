using PGM.Model.Base;
using System;

namespace PGM.Model
{
    public class AccountInfo
        : EntityBase
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public bool ExpiresPass { get; set; }
        public short? ExpiresPassDays { get; set; }
        public string Password { get; set; }

    }
}
