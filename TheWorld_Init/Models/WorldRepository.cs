using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld_Init.Models
{
    public class WorldRepository
    {
        private WorldContext _context;

        public WorldRepository(WorldContext context)
        {
            _context = context;
        }
        //public IEnumerable<Trip> GetAllTrips()
        //{

        //}

    }
}
