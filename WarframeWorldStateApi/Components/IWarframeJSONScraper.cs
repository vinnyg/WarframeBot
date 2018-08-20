using Newtonsoft.Json.Linq;

namespace WarframeWorldStateApi.Components
{
    public interface IWarframeJSONScraper
    {
        //JObject ScrapeWorldState();
        JObject WorldState { get; }
        JObject WarframeStatusWorldState { get; }
    }
}