using System.Drawing;

namespace LNAU24.Models
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string UserEmail { get; set; }

        protected string Password { get; set; }

        public Image UserImage { get; set; }

        public bool StatusIn { get; set; }


    }
}
