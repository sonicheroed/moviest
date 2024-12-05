using MovieStoreC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.Models.Responses
{
    public class MovieFullDetailsResponse
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        public int Name { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();

        public static implicit operator MovieFullDetailsResponse(MovieFullDetailsResponse v)
        {
            throw new NotImplementedException();
        }
    }
}
