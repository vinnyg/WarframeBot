using Newtonsoft.Json.Linq;

namespace WarframeWorldStateApi.Components
{
    public interface IWarframeJSONScraper
    {
        JObject WorldState { get; }
        JObject WarframeStatusWorldState { get; }
    }
}