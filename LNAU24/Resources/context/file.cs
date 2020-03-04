using LNAU24.Resources.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.context
{
    class file
    {
        int id { get; set; }

        string path { get; set; }

        user owner;

        string name_file { get; set; }

        string information { get; set; }

        string created_At { get; set; }

        string updated_At { get; set; }
    }
}
