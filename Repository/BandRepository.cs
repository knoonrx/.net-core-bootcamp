using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;

namespace FirstApplication.Repository
{
    public class BandRepository : IBandRepository
    {
        public Band GetBand(int id)
        {
            throw new NotImplementedException();
        }

        public List<Band> GetBands()
        {
            var ListOfBands = new List<Band>()
            {
                new Band
                {
                    Title = "Scorpions",
                    Biography = "Banda veia da porra",
                    Genre = "Rock",
                    Origin = "USA"
                },
                new Band
                {
                    Title = "Legião Urbana",
                    Biography = "Banda veia da porra",
                    Genre = "Rock",
                    Origin = "USA"
                },
                new Band
                {
                    Title = "QUEEN",
                    Biography = "Banda veia da porra",
                    Genre = "Rock",
                    Origin = "USA"
                }
            };

            return ListOfBands;
        }
    }
}
