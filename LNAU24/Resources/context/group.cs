using LNAU24.Resources.types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.context
{
    class group
    {

        group (string Name, string Info, Image Image)
        {
            this.name = Name;
            this.information = Info;
            this.image = Image;
        }

        group (string Name)
        {
            this.name = Name;
        }

        group (string Name, string Info)
        {
            this.name = Name;
            this.information = Info;
        }

        group (string Name, Image Image)
        {
            this.name = Name;
            this.image = Image;
        }
        
        int ID { get; set; }

        string name { get; set; }

        cathedra cathedra;

        string information { get; set; }

        Image image { get; set; }

        user[] users;

        string created_At { get; set; }

        string updated_At { get; set; }



    }
}
