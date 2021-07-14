using System;

namespace PGM.Model
{
    public class AccountInfo
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ExpiresPass { get; set; }
        public short? ExpiresPassDays { get; set; }
        public string Password { get; set; }

    }
}
