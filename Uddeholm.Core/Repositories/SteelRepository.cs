using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uddeholm.Core.Entites;

namespace Uddeholm.Core.Repositories
{
    public class SteelRepository
    {
        public List<Steel> Steels = new List<Steel>();

        public SteelRepository()
        {

        }

        public void TakeSteel(Steel steel)
        {
            Steels.Add(steel);
        }


    }
}