using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    public class CommunityUser
    {
        public string Nickname { get; set; }
        public string Descryption { get; set; }
        public List<string> SocialMedia { get; set; }
        public string IsInGroup { get; set; }
        public List<string> GroupName { get; set; }
        public List<string> Roles { get; set; }
    }
}
