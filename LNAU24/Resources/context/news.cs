﻿using LNAU24.Resources.types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.context
{
    class news
    {

        int ID { get; set; }

        string title { get; set; }

        string body { get; set; }

        string author { get; set; }

        int vievs { get; set; }

        user user;

        cathedra cathedra;

        Image[] images { get; set; }

        string created_At { get; set; }

        string updated_At { get; set; }

        
    }
}