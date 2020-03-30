using System.Collections.Generic;
using System.Drawing;

namespace LNAU24.Base
{
    public class BaseModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Information { get; set; }

        public Image MainImage { get; set; }

        public List<Image> Images { get; set; }

    }
}
