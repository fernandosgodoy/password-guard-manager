using PGM.Model.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace PGM.Model.Base
{
    public abstract class EntityBase
        : IEntity
    {

        public EntityBase()
        {
            this.CreatedAt = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
