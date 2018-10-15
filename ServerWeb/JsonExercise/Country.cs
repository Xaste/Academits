using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise
{
    class Country
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public List<Currency> Currencies { get; set; }
    }
}
