﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.types
{
    class user
    {

        public user(string Name, string Surname, string Email)
        {
            name = Name;

            surname = Surname;
            
            email = Email;
        }

        public int ID { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string email { get; set; }

        public string createdAt { get; set; }

        public string updatedAt { get; set; }

        public string position { get; set; }

        public Image user_image { get; set; }




    }
}