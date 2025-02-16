using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fnPostDatabase
{
    internal class MovieRequest
    {
        public string id { get { return Guid.NewGuid().ToString(); } }

        public string title { get; set; }

        public string year { get; set; }

        public string video { get; set; }

        public string thumb { get; set; }
    }
}
