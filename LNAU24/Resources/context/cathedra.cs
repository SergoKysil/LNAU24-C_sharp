using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.types
{
    class cathedra
    {
        public cathedra(string Name, string Faculty, string Info, Image Image, Image[] Images)
        {
            this.name = Name;

            this.faculty = Faculty;

            this.information = Info;

            this.mainImage = Image;

            this.images = Images;
        }

        public cathedra(string Name, string Faculty)
        {
            this.name = Name;
            this.faculty = Faculty;
        }

        public cathedra(string Name, string Faculty, string Info)
        {
            this.name = Name;
            this.faculty = Faculty;
            this.information = Info;
        }

        public cathedra(string Name, string Faculty, string Info, Image Image)
        {
            this.name = Name;

            this.faculty = Faculty;

            this.information = Info;

            this.mainImage = Image;
        }

        public int ID { get; set; }

        public string name { get; set; }
        
        public string faculty { get; set; }

        public string information { get; set; }

        public Image mainImage { get; set; }

        public Image[] images { get; set; }

        public string  createdAt { get; set; }

        public string updatedAt { get; set; }

    }
}
