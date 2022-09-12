using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Profile
{
    [Serializable]
    public class ProfileClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Bitmap IconProfile { get; set; }
        public DateTime YearOfBirth { get; set; }
        public bool PassState { get; set; }
        public SecureString Password { get; set; }
        public string HelperQuestion {get; set; }
    }
}
