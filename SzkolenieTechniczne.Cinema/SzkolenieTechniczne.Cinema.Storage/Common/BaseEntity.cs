using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne.Cinema.Storage.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
