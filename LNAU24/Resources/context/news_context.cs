using LNAU24.Resources.types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.Resources.context
{
    class news_context
    {
        public news_context()
        {

        }
        public news_context(string Title, string Body)
        {
            this.title = Title;
            this.body = Body;
        }

        public news_context(string Title, string Body, string[] Images)
        {
            this.title = Title;
            this.body = Body;
            this.images_path = Images;
        }

        int ID { get; }

        public string title { get; set; }

        public string body { get; set; }

        public string author { get; set; }

        public int vievs { get; set; }

        public user user;

        public cathedra cathedra;

        public file[] files { get; set; }

        public string[] images_path { get; set; }

        public string created_At { get; set; }

        public string updated_At { get; set; }

        
    }
}
