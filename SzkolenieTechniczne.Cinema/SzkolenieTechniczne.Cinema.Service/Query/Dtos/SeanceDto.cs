using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Query.Dtos
{
    public class SeanceDto
    {
        public SeanceDto(long id, DateTime date)
        {
            Id = id;
            Date = date;

        }
        public long Id { get; set; }
        public DateTime? Date { get; set; }

    }
}
