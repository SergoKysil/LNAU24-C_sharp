using LNAU24.Resources.types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.context
{
    class faculty
    {

        public faculty(string Name)
        {
            this.name = Name;
        }

        public faculty(string Name, string Info)
        {
            this.name = Name;
            this.information = Info;
        }

        public faculty(string Name, string Info, Image Main_img)
        {
            this.name = Name;
            this.information = Info;
            this.main_image = Main_img;
        }

        int ID { get; set; }

        string name { get; set; }

        string information { get; set; }

        Image main_image { get; set; }

        Image[] images { get; set; }

        string created_At { get; set; }

        string updated_at { get; set; }

        cathedra[] cathedras;

        group[] groups;

    }
}
