using PGM.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGM.Model.Base
{
    public abstract class EntityBase
        : IEntity
    {

        public EntityBase()
        {
            this.CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
