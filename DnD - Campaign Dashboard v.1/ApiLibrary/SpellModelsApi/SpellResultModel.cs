using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    public class Spells
    {
        public int count { get; set; }

        //[results]
        public IList<SpellModel> results { get; set; }
    }
}
