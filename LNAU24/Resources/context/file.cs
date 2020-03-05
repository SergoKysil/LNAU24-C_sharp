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


        file (string Name_file, string Path, string Information)
        {
            this.name_file = Name_file;
            this.information = Information;
            this.path = Path;
        }

        int id { get; set; }

        string path { get; set; }

        user owner;

        string name_file { get; set; }

        string information { get; set; }

        string created_At { get; set; }

        string updated_At { get; set; }


       
    }
}
