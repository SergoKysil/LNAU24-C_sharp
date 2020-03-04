﻿using System;
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
            name = Name;

            faculty = Faculty;

            information = Info;

            mainImage = Image;

            images = Images;
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