using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Query.Dtos
{
    public class MovieDetailsDto
    {
        public MovieDetailsDto(long id,string name,int year, int seanceTime,List<SeanceDto> seances) 
        {
            Id = id;
            Name = name;
            Seances = seances;
            Year = year;
            SeanceTime = seanceTime;

        }
        public long Id { get;}
        public string Name { get; }
        public int Year { get;}
        public int SeanceTime {  get;}
        public List<SeanceDto> Seances { get; }
    }
}
