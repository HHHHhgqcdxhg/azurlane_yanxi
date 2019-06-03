using Newtonsoft.Json;
using System.IO;

namespace azurlane_yanxi
{
    public class ConfigController
    {
        public Config Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@"./config.json"));
    }
}