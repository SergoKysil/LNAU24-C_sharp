using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

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

        public ObservableCollection<string> Images { get; set; } = new ObservableCollection<string>();

    }
}
