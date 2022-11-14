using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnimePlayer.Profile
{
    [Serializable, JsonObject(MemberSerialization.OptIn)]
    public class ProfileClass
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        public Bitmap IconProfile { get; set; }
        [JsonProperty]
        public DateTime YearOfBirth { get; set; }
        [JsonProperty]
        public bool PassState { get; set; }
        [JsonProperty]
        public string K { get; set; }
        [JsonProperty]
        public string Password { get; set; }
        [JsonProperty]
        public string HelperQuestion {get; set; }
    }
}
