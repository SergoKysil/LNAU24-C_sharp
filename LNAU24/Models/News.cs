using System.Collections.Generic;

namespace LNAU24.Models
{
    public class News
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Author { get; set; }

        public int Views { get; set; }

        public List<string> Files { get; set; }

    }
}
