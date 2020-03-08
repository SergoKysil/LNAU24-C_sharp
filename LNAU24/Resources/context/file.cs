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


        file (string Name_file, string Path)
        {
            this.name_file = Name_file;
            this.path = Path;
        }

        int id { get; set; }

        string path { get; set; }

        string name_file { get; set; }

        user owner;



    }
}
