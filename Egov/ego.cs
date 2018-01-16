using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
namespace Egov
{
    public class ego
    { [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("i")]
        public int price  { get; set; }
    }
}
