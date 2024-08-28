using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Data.Entites
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public DateTime CreatedAt { get; set; } // Timestamp when the entity was created

        public DateTime? UpdatedAt { get; set; } // Timestamp when the entity was last updated

        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }

}
