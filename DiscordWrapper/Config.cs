using Newtonsoft.Json;

namespace DiscordWrapper
{
    public class Config
    {
        [JsonProperty("command_prefix")]
        public char commandPrefix { get; internal set; }

        [JsonProperty("discord_token")]
        public string DiscordToken { get; internal set; }
    }
}
