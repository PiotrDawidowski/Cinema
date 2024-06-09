using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Common;

namespace SzkolenieTechniczne.Cinema.Storage.Entities
{
    [Table("MovieCategory", Schema = "Cinema")]
    public class MovieCategory : BaseEntity
    {
        protected MovieCategory()
        {

        }
        public MovieCategory(string name)
        {
            Name = name;
        }
        [Required]
        public string Name { get; set; }


    }
}
