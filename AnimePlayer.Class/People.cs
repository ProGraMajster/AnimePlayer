using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class People
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}
